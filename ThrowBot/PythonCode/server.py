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

        hostname = socket.gethostname()                                 # Get the server IP address
        server_ip = socket.gethostbyname(hostname)
        print(f"Server IP Address: {server_ip}")

    def display_frame(self):
        while self.running:
            if self.frame is not None:
                with self.lock:
                    cv2.imshow('Received Camera Stream', self.frame)

            if cv2.waitKey(1) & 0xFF == ord('q'):                       # Break the loop if the 'q' key is pressed
                self.running = False

        cv2.destroyAllWindows()

    def start(self):
        conn, addr = self.server_socket.accept()
        print(f'Connection from {addr}')
        while True:
            frame_size_data = conn.recv(struct.calcsize("L"))           # Receive frame size first
            if not frame_size_data:
                break
            
            frame_size = struct.unpack("L", frame_size_data)[0]
            print(f"Received frame size: {frame_size} bytes")
            
            frame_data = b''                                            # Now receive the frame data
            while len(frame_data) < frame_size:
                frame_data += conn.recv(4096)
            
            encoded_frame = pickle.loads(frame_data)                    # Deserialize the frame
            frame = cv2.imdecode(encoded_frame, cv2.IMREAD_COLOR)       # Decode the JPEG frame
            with self.lock:
                self.frame = frame                                      # Store the frame in a thread-safe manner

        conn.close()
        self.server_socket.close()

if __name__ == "__main__":
    camServer = CameraServer()
    display_thread = threading.Thread(target=camServer.display_frame)   # Start the display thread
    display_thread.start()
    
    camServer.start()
    display_thread.join()                                               # Wait for the display thread to finish before exiting
