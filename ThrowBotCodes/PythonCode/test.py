import cv2
import socket
import threading
import struct
import time
import pickle
import serial
# from gpiozero import LED

# <---- ------------------------------------------------------- ---->
# led = LED(17)
# <---- ------------------------------------------------------- ---->
Forward_LowSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x00\xFA\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x04\xFA\xFF'
]
Forward_MidSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x01\xF4\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x05\xF4\xFF'
]
Forward_HighSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x03\xE8\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x07\xE8\xFF'
]
# <---- ------------------------------------------------------- ---->
Backward_LowSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x04\xFA\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x00\xFA\xFF'
]
Backward_MidSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x05\xF4\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x01\xF4\xFF'
]
Backward_HighSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x07\xE8\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x03\xE8\xFF'
]
# <---- ------------------------------------------------------- ---->
Rightward_LowSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x04\xFA\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x04\xFA\xFF'
]
Rightward_MidSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x05\xF4\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x05\xF4\xFF'
]
Rightward_HighSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x07\xE8\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x07\xE8\xFF'
]
# <---- ------------------------------------------------------- ---->
Leftward_LowSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x00\xFA\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x00\xFA\xFF'
]
Leftward_MidSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x01\xF4\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x01\xF4\xFF'
]
Leftward_HighSpeed = [
    b'\xFF\xFF\x01\x05\x03\x20\x03\xE8\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x03\xE8\xFF'
]
# <---- ------------------------------------------------------- ---->
Stop_Dynamixel = [
    b'\xFF\xFF\x01\x05\x03\x20\x00\x00\xFF',
    b'\xFF\xFF\x02\x05\x03\x20\x00\x00\xFF'
]
# <---- ------------------------------------------------------- ---->

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
        self.Speed = 0
        self.Gray_En = 0

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
                if self.Gray_En == 1:
                    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
                    # To send grayscale image, we should encode it properly
                    result, encoded_frame = cv2.imencode('.jpg', frame, [int(cv2.IMWRITE_JPEG_QUALITY), 90])
                else:
                    # No need to convert back to BGR
                    result, encoded_frame = cv2.imencode('.jpg', frame, [int(cv2.IMWRITE_JPEG_QUALITY), 90])
                if not result:
                    print("Error: Could not encode frame.")
                    continue

                frame_data = encoded_frame.tobytes()

                conn.sendall(struct.pack("L", len(frame_data)))  # Send frame size
                conn.sendall(frame_data)  # Send frame data

            time.sleep(0.1)

    def receive_messages(self):
        while self.running:
            if not ser.is_open:
                ser.open()

            try:
                while True:
                    response = self.message_conn.recv(1024).decode()
                    print(f"receive_messages: {response}")
                    # <---- -------------------------------------- ---->
                    match response:
                        case "MRL?":
                            self.send_messages("HSL!")
                    # <---- -------------------------------------- ---->
                        case "LowSpeed":
                            self.Speed = 0
                            self.send_messages("LowSpeed OK!")

                        case "MidSpeed":
                            self.Speed = 1
                            self.send_messages("MidSpeed OK!")

                        case "HighSpeed":
                            self.Speed = 2
                            self.send_messages("HighSpeed OK!")
                    # <---- -------------------------------------- ---->
                        case "Forward":
                            if self.Speed == 0:
                                ser.reset_input_buffer()
                                for message in Forward_LowSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Forward_LowSpeed OK!")

                            elif self.Speed == 1:
                                ser.reset_input_buffer()
                                for message in Forward_MidSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Forward_MidSpeed OK!")

                            elif self.Speed == 2:
                                ser.reset_input_buffer()
                                for message in Forward_HighSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Forward_HighSpeed OK!")
                    # <---- -------------------------------------- ---->
                        case "Backward":
                            if self.Speed == 0:
                                ser.reset_input_buffer()
                                for message in Backward_LowSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Backward_LowSpeed OK!")

                            elif self.Speed == 1:
                                ser.reset_input_buffer()
                                for message in Backward_MidSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Backward_MidSpeed OK!")

                            elif self.Speed == 2:
                                ser.reset_input_buffer()
                                for message in Backward_HighSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Backward_HighSpeed OK!")
                    # <---- -------------------------------------- ---->
                        case "Rightward":
                            if self.Speed == 0:
                                ser.reset_input_buffer()
                                for message in Rightward_LowSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Rightward_LowSpeed OK!")

                            elif self.Speed == 1:
                                ser.reset_input_buffer()
                                for message in Rightward_MidSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Rightward_MidSpeed OK!")
                            
                            elif self.Speed == 2:
                                ser.reset_input_buffer()
                                for message in Rightward_HighSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Rightward_HighSpeed OK!")
                    # <---- -------------------------------------- ---->
                        case "Leftward":
                            if self.Speed == 0:
                                ser.reset_input_buffer()
                                for message in Leftward_LowSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Leftward_LowSpeed OK!")
                            
                            elif self.Speed == 1:
                                ser.reset_input_buffer()
                                for message in Leftward_MidSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Leftward_MidSpeed OK!")

                            elif self.Speed == 2:
                                ser.reset_input_buffer()
                                for message in Leftward_HighSpeed:
                                    ser.write(message)
                                    time.sleep(0.1)
                                self.send_messages("Leftward_HighSpeed OK!")
                    # <---- -------------------------------------- ---->
                        case "Stop_Dynamixel":
                            ser.reset_input_buffer()
                            for message in Stop_Dynamixel:
                                ser.write(message)
                                time.sleep(0.1)
                            self.send_messages("Stop_Dynamixel OK!")
                    # <---- -------------------------------------- ---->
                        case "Gray_OFF":
                            self.Gray_En = 0
                            self.send_messages("Gray Disable OK!")
                        case "Gray_ON":
                            self.Gray_En = 1
                            self.send_messages("Gray Enable OK!")
                    # <---- -------------------------------------- ---->
                        case "LED_OFF":
                            # led.off()
                            self.send_messages("LED Turn-OFF OK!")
                        case "LED_ON":
                            # led.on()
                            self.send_messages("LED Turn-ON OK!")
                    # <---- -------------------------------------- ---->
                        case _:
                            print("Unexpected response.")
                            self.message_conn.close()
                            ser.close()
                            self.camera_conn.close()
                            self.release_camera()
                    # <---- -------------------------------------- ---->
                    time.sleep(0.1)  # Retry delay
            except Exception as e:
                print(f"Error receiving message: {e}")
                break

    def send_messages(self, message):
        self.message_conn.sendall(message.encode())
        print(f'Sent: {message}')

    def start(self):
        try:
            self.message_conn = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.message_conn.connect((self.server_ip, self.message_port))

            self.camera_conn = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.camera_conn.connect((self.server_ip, self.camera_port))
        except socket.error as e:
            print(f"Socket connection error: {e}")
            return

        self.receive_thread = threading.Thread(target=self.receive_messages)
        self.receive_thread.start()

        self.send_frame_thread = threading.Thread(target=self.send_frame, args=(self.camera_conn,))
        self.send_frame_thread.start()

        self.receive_thread.join()
        self.send_frame_thread.join()

        self.message_conn.close()
        ser.close()
        self.camera_conn.close()
        self.release_camera()

if __name__ == "__main__":
    ser = serial.Serial('COM6', baudrate=57600, timeout=1)
    server_ip = '192.168.1.5'
    camera_port = 8000
    message_port = 1234
    cameraClient = CameraClient(server_ip, camera_port, message_port)
    cameraClient.start()
