import cv2
import threading

class CameraCapture:
    def __init__(self, camera_index=0):
        self.camera_index = camera_index
        self.camera = cv2.VideoCapture(self.camera_index, cv2.CAP_DSHOW)  # Use CAP_DSHOW for Windows

        # Set the desired frame width and height
        self.camera.set(cv2.CAP_PROP_FRAME_WIDTH, 640)
        self.camera.set(cv2.CAP_PROP_FRAME_HEIGHT, 480)
        self.camera.set(cv2.CAP_PROP_FPS, 30)

        self.running = True
        self.frame = None
        self.lock = threading.Lock()

        # Start the frame capture thread
        self.capture_thread = threading.Thread(target=self.capture_frames)
        self.capture_thread.start()

    def open(self):
        if not self.camera.isOpened():
            print("Error: Could not open camera.")
            return False
        return True

    def capture_frames(self):
        while self.running:
            ret, frame = self.camera.read()
            if ret:
                with self.lock:
                    self.frame = frame

    def get_frame(self):
        with self.lock:
            return self.frame

    def release(self):
        self.running = False
        self.capture_thread.join()
        self.camera.release()

def main():
    camera_index = 0  # Change this if you have multiple cameras
    capture = CameraCapture(camera_index)

    if not capture.open():
        return

    while True:
        frame = capture.get_frame()
        if frame is None:
            continue

        cv2.imshow('Camera Stream', frame)

        # Press 'q' on the keyboard to exit the loop
        if cv2.waitKey(10) & 0xFF == ord('q'):  # Adjust wait time for responsiveness
            break

    capture.release()
    cv2.destroyAllWindows()

if __name__ == "__main__":
    main()
