import socket

def send_message():
    server_address = ('192.168.60.181', 8000)  # Replace with your server's IP and port
    message = 'HSL!'

    # Create a TCP/IP socket
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    try:
        # Connect to the server
        sock.connect(server_address)

        # Receive response
        response = sock.recv(1024).decode()
        if response == "MRL?":
            # Send data
            sock.sendall(message.encode())
            print(f'Sent: {message}')

    finally:
        sock.close()

if __name__ == '__main__':
    send_message()
