import serial
import time

# Define the values to send
val = bytearray([0x02, 0x02])

# Set up the serial connection
ser = serial.Serial('COM6', baudrate=57600, timeout=1)  # Adjust baudrate as needed

# Give some time for the serial port to initialize
time.sleep(2)

try:
    # Write the values to the serial port
    ser.write(val)
    print("Values sent:", val)
except serial.SerialException as e:
    print("Error:", e)
finally:
    # Close the serial port
    ser.close()

