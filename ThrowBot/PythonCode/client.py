import cv2
import socket
import threading
import pickle
import struct

class CameraClient:
    def __init__(self, server_ip, server_port, camera_index=0):
        self.server_ip = server_ip
        self.server_port = server_port
        self.camera_index = camera_index
        self.camera = cv2.VideoCapture(self.camera_index, cv2.CAP_DSHOW)
        self.camera.set(cv2.CAP_PROP_FRAME_WIDTH, 320)
        self.camera.set(cv2.CAP_PROP_FRAME_HEIGHT, 240)
        self.running = True

    def open(self):
        if not self.camera.isOpened():
            print("Error: Could not open camera.")
            return False
        return True

    def send_frame(self, conn):
        while self.running:
            ret, frame = self.camera.read()
            if not ret:
                print("Error: Could not read frame.")
                continue

            # Serialize the frame
            data = pickle.dumps(frame)
            # Send frame size first
            conn.sendall(struct.pack("L", len(data)))
            # Send frame data
            conn.sendall(data)

    def start(self):
        # Connect to the server
        conn = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        conn.connect((self.server_ip, self.server_port))
        
        # Start sending frames in a separate thread
        self.send_thread = threading.Thread(target=self.send_frame, args=(conn,))
        self.send_thread.start()

        # Wait for the sending thread to finish
        self.send_thread.join()

        conn.close()
        self.camera.release()

if __name__ == "__main__":
    server_ip = '192.168.1.4'  # Change to your server's IP address
    server_port = 8000          # Change to your server's port
    client = CameraClient(server_ip, server_port)

    if client.open():
        client.start()
