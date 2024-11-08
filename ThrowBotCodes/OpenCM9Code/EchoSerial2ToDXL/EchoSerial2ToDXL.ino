void setup(){
  Serial2.begin(57600);  
  pinMode(BOARD_LED_PIN, OUTPUT);
}

void loop(){
  if(SerialUSB.available()){
    Serial2.print((char)SerialUSB.read());//send data coming from USB to Serial2
  }

  if(Serial2.available()){
    toggleLED();
    SerialUSB.print((char)Serial2.read()); //send data coming from Serial2 to USB(PC)
  }
}

