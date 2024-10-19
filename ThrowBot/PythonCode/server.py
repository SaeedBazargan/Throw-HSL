import socket
import cv2
import pickle
import struct

class CameraServer:
    def __init__(self, host='0.0.0.0', port=8000):
        self.server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.server_socket.bind((host, port))
        self.server_socket.listen(1)
        print(f'Server listening on {host}:{port}')

    def start(self):
        conn, addr = self.server_socket.accept()
        print(f'Connection from {addr}')

        while True:
            # Receive frame size first
            frame_size_data = conn.recv(struct.calcsize("L"))
            if not frame_size_data:
                break
            
            frame_size = struct.unpack("L", frame_size_data)[0]
            # Now receive the frame data
            frame_data = b''
            while len(frame_data) < frame_size:
                frame_data += conn.recv(4096)
            
            # Deserialize the frame
            frame = pickle.loads(frame_data)

            # Display the resulting frame
            cv2.imshow('Received Camera Stream', frame)

            # Break the loop if the 'q' key is pressed
            if cv2.waitKey(1) & 0xFF == ord('q'):
                break

        conn.close()
        self.server_socket.close()
        cv2.destroyAllWindows()

if __name__ == "__main__":
    server = CameraServer()
    server.start()
