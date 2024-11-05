import cv2
import socket
import threading
import struct
import time

class CameraClient:
    def __init__(self, server_ip, camera_port, message_port, camera_index=0):
        self.server_ip = server_ip
        self.camera_port = camera_port
        self.message_port = message_port
        self.camera_index = camera_index
        self.camera = None
        self.running = True
        self.camera_conn = None
        self.message_conn = None
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

    def send_frame(self):
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

                result, encoded_frame = cv2.imencode('.jpg', frame, [int(cv2.IMWRITE_JPEG_QUALITY), 90])
                if not result:
                    print("Error: Could not encode frame.")
                    continue

                frame_data = encoded_frame.tobytes()

                try:
                    self.camera_conn.sendall(struct.pack("L", len(frame_data)))
                    self.camera_conn.sendall(frame_data)
                except socket.error as e:
                    print(f"Error sending frame: {e}")
                    break

            time.sleep(0.1)

    def receive_messages(self):
        while self.running:
            try:
                response = self.message_conn.recv(1024).decode()
                print(f"receive_messages: {response}")

                if response == "MRL?":
                    self.send_messages("HSL!")
                elif response == "12346":
                    self.send_messages("987654")
                # else:
                #     print("\nHandshake has not happened.\n\n\n")
                #     self.message_conn.close()
                #     self.release_camera()
            except Exception as e:
                print(f"Error receiving message: {e}")
                break

    def send_messages(self, message):
        self.message_conn.sendall(message.encode())
        print(f'Sent: {message}')

    def start(self):
        try:
            # self.camera_conn = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            # self.camera_conn.connect((self.server_ip, self.camera_port))

            self.message_conn = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.message_conn.connect((self.server_ip, self.message_port))
        except socket.error as e:
            print(f"Socket connection error: {e}")
            return

        # self.send_thread = threading.Thread(target=self.send_frame)
        # self.send_thread.start()

        self.receive_thread = threading.Thread(target=self.receive_messages)
        self.receive_thread.start()

        # self.send_thread.join()
        self.receive_thread.join()

        # self.camera_conn.close()
        self.message_conn.close()
        self.release_camera()

if __name__ == "__main__":
    server_ip = '192.168.1.4'
    camera_port = 8000
    message_port = 1234
    cameraClient = CameraClient(server_ip, camera_port, message_port)

    # if cameraClient.open_camera():
    cameraClient.start()
