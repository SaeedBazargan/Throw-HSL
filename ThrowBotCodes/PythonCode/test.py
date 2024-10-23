from ultralytics import YOLO
import cv2

model = YOLO("yolov9-e.pt")

results = model.predict(source="0", show=True)

print(results)

