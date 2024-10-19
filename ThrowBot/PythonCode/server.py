import cv2
import socket
import struct
import pickle

# Set up the server address and port
SERVER_IP = '0.0.0.0'  # Listen on all interfaces
SERVER_PORT = 5000

# Create a TCP socket
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Bind the socket to the address and port
server_socket.bind((SERVER_IP, SERVER_PORT))

# Listen for incoming connections
server_socket.listen(1)
print(f"Server listening on {SERVER_IP}:{SERVER_PORT}")

try:
    # Accept a connection from a client
    conn, addr = server_socket.accept()
    print(f"Connected by {addr}")

    while True:
        # Receive the length of the data
        payload_size = struct.unpack("L", conn.recv(struct.calcsize("L")))[0]
        
        # Receive the actual data
        data = b""
        while len(data) < payload_size:
            data += conn.recv(4096)
        
        # Deserialize the frame using pickle
        frame = pickle.loads(data)

        # Display the received frame
        cv2.imshow('Server Video', frame)

        # Exit on 'q' key press
        if cv2.waitKey(1) & 0xFF == ord('q'):
            break

finally:
    # Clean up OpenCV windows
    conn.close()
    server_socket.close()
    cv2.destroyAllWindows()
