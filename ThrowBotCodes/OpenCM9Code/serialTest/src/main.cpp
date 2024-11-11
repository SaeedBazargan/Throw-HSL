#include <Arduino.h>

void setup()
{
  Serial.begin(57600);
  Serial.println("Ready to go!");
}

void loop()
{
  byte c;

  if (Serial.available() > 0) 
  {
    c = Serial.read();

    Serial.print("bytes = ");
    Serial.println(c);
  }
}
