import cv2
import socket
import threading
import struct
import time

class CameraClient:
    def __init__(self, server_ip, server_port, camera_index=0):
        self.server_ip = server_ip
        self.server_port = server_port
        self.camera_index = camera_index
        self.camera = None
        self.running = True
        self.conn = None
        self.cameraMode = 1

    def open_camera(self):
        if self.camera is None or not self.camera.isOpened():
            self.camera = cv2.VideoCapture(self.camera_index, cv2.CAP_DSHOW)
            self.camera.set(cv2.CAP_PROP_FRAME_WIDTH, 640)
            self.camera.set(cv2.CAP_PROP_FRAME_HEIGHT, 480)
            self.camera.set(cv2.CAP_PROP_FPS, 15)
            return True
        return True

    def release_camera(self):
        if self.camera is not None and self.camera.isOpened():
            self.camera.release()
            self.camera = None

    def send_frame(self, conn):
        while self.running:
            if self.cameraMode == 0:
                self.release_camera()
            else:
                self.open_camera()
                ret, frame = self.camera.read()
                if not ret:
                    print("Error: Could not read frame.")
                    continue

                if self.cameraMode == 1:
                    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

                # Encode the frame as JPEG
                result, encoded_frame = cv2.imencode('.jpg', frame, [int(cv2.IMWRITE_JPEG_QUALITY), 90])
                if not result:
                    print("Error: Could not encode frame.")
                    continue

                # Convert encoded frame to bytes
                frame_data = encoded_frame.tobytes()

                # Send the length of the data first, then the data itself
                conn.sendall(struct.pack("L", len(frame_data)))  # Send frame size
                conn.sendall(frame_data)  # Send frame data

            time.sleep(0.1)  # Small delay to prevent overwhelming the server

    def receive_messages(self, conn):
        while self.running:
            try:
                response = conn.recv(1024).decode()
                print(f"receive_messages: {response}")
            except Exception as e:
                print(f"Error receiving message: {e}")
                break

    def send_messages(self, conn, message):
        conn.sendall(message.encode())
        print(f'Sent: {message}')

    def start(self):
        self.conn = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.conn.connect((self.server_ip, self.server_port))

        self.send_thread = threading.Thread(target=self.send_frame, args=(self.conn,))
        self.send_thread.start()

        self.receive_thread = threading.Thread(target=self.receive_messages, args=(self.conn,))
        self.receive_thread.start()

        self.send_thread.join()
        self.receive_thread.join()

        self.conn.close()
        self.release_camera()

if __name__ == "__main__":
    server_ip = '192.168.60.181'
    server_port = 8000
    cameraClient = CameraClient(server_ip, server_port)

    if cameraClient.open_camera():
        cameraClient.start()
