#include <stdio.h>
#include <string.h>

#define GOAL_SPEED         32
#define DXL_BUS_SERIAL1    1
#define Left_ID            1
#define Right_ID           2

Dynamixel dxl(DXL_BUS_SERIAL1);

byte value[20];
byte rec, count = 0;

void setup()
{
  dxl.begin(3);
//  SerialUSB.begin(57600);
  pinMode(BOARD_LED_PIN, OUTPUT);
}

void loop(){
  if(SerialUSB.available())
  {
    rec = SerialUSB.read();
    value[count++] = rec;
    if(count == value[0])
    {
      dxl.writeWord(value[1], GOAL_SPEED, 400);
      memset(value, 0, sizeof(value));
    }
  }
}

