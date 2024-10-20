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
        self.camera = None
        self.running = True
        self.conn = None
        self.grayCounter = 1

    def open_camera(self):
        if self.camera is None or not self.camera.isOpened():
            self.camera = cv2.VideoCapture(self.camera_index, cv2.CAP_DSHOW)
            self.camera.set(cv2.CAP_PROP_FRAME_WIDTH, 320)
            self.camera.set(cv2.CAP_PROP_FRAME_HEIGHT, 240)
            self.camera.set(cv2.CAP_PROP_FPS, 15)
            return True
        return True

    def release_camera(self):
        if self.camera is not None and self.camera.isOpened():
            self.camera.release()
            self.camera = None

    def receive_messages(self, conn):
        while self.running:
            try:
                string_size_data = conn.recv(struct.calcsize("L"))
                if not string_size_data:
                    break

                string_size = struct.unpack("L", string_size_data)[0]                
                string_data = b''
                while len(string_data) < string_size:
                    string_data += conn.recv(4096)

                message = pickle.loads(string_data)
                if message == 'c':
                    self.grayCounter += 1
                    if self.grayCounter == 3:
                        self.grayCounter = 0

            except Exception as e:
                print(f"Error receiving message: {e}")
                break

    def send_frame(self, conn):
        while self.running:
            if self.grayCounter == 0:
                self.release_camera()
            else:
                self.open_camera()
                
                ret, frame = self.camera.read()
                if not ret:
                    print("Error: Could not read frame.")
                    continue

                if self.grayCounter == 1:
                    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

                result, encoded_frame = cv2.imencode('.jpg', frame, [int(cv2.IMWRITE_JPEG_QUALITY), 90])
                if not result:
                    print("Error: Could not encode frame.")
                    continue

                data = pickle.dumps(encoded_frame)
                conn.sendall(struct.pack("L", len(data)))
                conn.sendall(data)

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
