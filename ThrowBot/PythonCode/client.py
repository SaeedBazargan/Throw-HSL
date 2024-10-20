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
        self.camera.set(cv2.CAP_PROP_FPS, 15)
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

            result, encoded_frame = cv2.imencode('.jpg', frame, [int(cv2.IMWRITE_JPEG_QUALITY), 90])  # Compress the frame using JPEG and Adjust quality as needed
            if not result:
                print("Error: Could not encode frame.")
                continue

            data = pickle.dumps(encoded_frame)                                                      # Serialize the encoded frame
            print(f"Sending frame size: {len(data)} bytes")                                 
            conn.sendall(struct.pack("L", len(data)))                                               # Send frame size first
            conn.sendall(data)                                                                      # Send frame data

    def start(self):
        conn = socket.socket(socket.AF_INET, socket.SOCK_STREAM)                                    # Connect to the server
        conn.connect((self.server_ip, self.server_port))
        self.send_thread = threading.Thread(target=self.send_frame, args=(conn,))                   # Start sending frames in a separate thread
        self.send_thread.start()
        self.send_thread.join()                                                                     # Wait for the sending thread to finish

        conn.close()
        self.camera.release()

if __name__ == "__main__":
    server_ip = '192.168.60.181'  # Change to your server's IP address
    server_port = 8000          # Change to your server's port
    client = CameraClient(server_ip, server_port)

    if client.open():
        client.start()
