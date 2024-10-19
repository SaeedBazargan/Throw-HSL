import cv2
import socket
import struct
import pickle

# Set up the server address and port
SERVER_IP = '192.168.1.4'  # Replace with the server's IP address
SERVER_PORT = 5000

# Create a TCP socket
client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Connect to the server
client_socket.connect((SERVER_IP, SERVER_PORT))

# Open the camera
cap = cv2.VideoCapture(0)
cap.set(cv2.CAP_PROP_FRAME_WIDTH, 320)
cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 240)
cap.set(cv2.CAP_PROP_FPS, 15)

try:
    while True:
        # Capture frame-by-frame
        ret, frame = cap.read()
        if not ret:
            break
        
        # Serialize the frame using pickle
        data = pickle.dumps(frame)
        
        # Send the length of the serialized frame first
        client_socket.sendall(struct.pack("L", len(data)) + data)

        # Optional: Display the captured frame locally (for debugging)
        cv2.imshow('Client Video', frame)
        
        # Exit if 'q' is pressed
        if cv2.waitKey(1) & 0xFF == ord('q'):
            break

finally:
    # Release the camera and close the socket
    cap.release()
    client_socket.close()
    cv2.destroyAllWindows()
