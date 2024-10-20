import socket
import cv2
import pickle
import struct
import threading

class CameraServer:
    def __init__(self, host='0.0.0.0', port=8000):
        self.server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.server_socket.bind((host, port))
        self.server_socket.listen(1)
        print(f'Server listening on {host}:{port}')
        self.frame = None
        self.lock = threading.Lock()
        self.running = True
        self.conn = None

        # Get the server IP address
        hostname = socket.gethostname()
        server_ip = socket.gethostbyname(hostname)
        print(f"Server IP Address: {server_ip}")

    def display_frame(self):
        while self.running:
            if self.frame is not None:
                with self.lock:
                    cv2.imshow('Received Camera Stream', self.frame)

            key = cv2.waitKey(1) & 0xFF
            if key == ord('q'):
                print("Key 'q' pressed! Shutting down...")
                self.running = False

            if key == ord('c'):
                data = pickle.dumps('c')                                 # Serialize 'c' message
                self.conn.sendall(struct.pack("L", len(data)))           # Send string length first
                self.conn.sendall(data)                                  # Send the string data

        cv2.destroyAllWindows()

    def start(self):
        self.conn, addr = self.server_socket.accept()
        print(f'Connection from {addr}')

        while self.running:
            try:
                frame_size_data = self.conn.recv(struct.calcsize("L"))  # Receive frame size first
                if not frame_size_data:
                    break

                frame_size = struct.unpack("L", frame_size_data)[0]
                frame_data = b''  # Now receive the frame data
                while len(frame_data) < frame_size:
                    frame_data += self.conn.recv(4096)

                encoded_frame = pickle.loads(frame_data)  # Deserialize the frame
                frame = cv2.imdecode(encoded_frame, cv2.IMREAD_COLOR)  # Decode the JPEG frame
                with self.lock:
                    self.frame = frame  # Store the frame in a thread-safe manner

            except Exception as e:
                print(f"Error receiving frame: {e}")
                break

        self.conn.close()
        self.server_socket.close()

    def stop(self):
        self.running = False
        if self.conn:
            self.conn.close()
        self.server_socket.close()

if __name__ == "__main__":
    camServer = CameraServer()

    # Start the display thread
    display_thread = threading.Thread(target=camServer.display_frame)
    display_thread.start()

    try:
        camServer.start()
    finally:
        camServer.stop()  # Ensure server stops correctly
        display_thread.join()
