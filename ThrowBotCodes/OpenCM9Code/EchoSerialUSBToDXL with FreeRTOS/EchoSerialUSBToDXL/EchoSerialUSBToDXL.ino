#include <MapleFreeRTOS.h>
#include <stdint.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>


#define DXL_BUS_SERIAL1           1
#define Read_Instruction          0x02
#define Write_Instruction         0x03
#define LED_PIN                   11
#define PWR_PIN                   12

#define lengthOfRecData           50
#define msg_queue_length          10

static xQueueHandle Queue_1;
static xTaskHandle recordTask_Handle = NULL;
static xTaskHandle echoTask_Handle = NULL;

void startTask1(void* parameters);
void startTask2(void* parameters);

Dynamixel Dxl(DXL_BUS_SERIAL1);

void setup() 
{
  Serial2.begin(57600);
  Dxl.begin(3);
  pinMode(LED_PIN, OUTPUT);
  pinMode(PWR_PIN, OUTPUT);  
  
  Queue_1 = xQueueCreate(msg_queue_length, lengthOfRecData);

  xTaskCreate(startTask1, (signed char *)"RECORD_TASK", configMINIMAL_STACK_SIZE, NULL, 1, &recordTask_Handle);
  xTaskCreate(startTask2, (signed char *)"DXL_TASK", configMINIMAL_STACK_SIZE, NULL, 1, &echoTask_Handle);
  vTaskStartScheduler();
}

void loop()
{}

void startTask1(void* parameters)
{
  char recData[lengthOfRecData] = {0};
  uint8_t counterOfRecData = 0;
  
  while (1)
  {
    if (Serial2.available())
    {
      recData[counterOfRecData++] = Serial2.read();
      
      if (counterOfRecData >= (recData[3] + 4))
      {
        if(recData[4] == Write_Instruction)
        {
          if (xQueueSend(Queue_1, (void*)recData, 0) != pdTRUE)
          {
            Serial2.println("Queue Full!");
          }
          memset(recData, 0, lengthOfRecData);
          counterOfRecData = 0;
        }
      }
    }
    vTaskDelay(1);  // Yield to allow other tasks to execute
  }
}

void startTask2(void* parameters)
{
  char recData[lengthOfRecData] = {0};
  
  while (1)
  {
    if (xQueueReceive(Queue_1, (void*)recData, portMAX_DELAY) == pdTRUE)
    {
      if(recData[5] == 0x19)
      {
        if(recData[6] == 0x01)
          digitalWrite(LED_PIN, HIGH);
        else
          digitalWrite(LED_PIN, LOW);
      }
      else if(recData[5] == 0x18)
      {
        if(recData[6] == 0x01)
          digitalWrite(PWR_PIN, HIGH);
        else
          digitalWrite(PWR_PIN, LOW);
      }
      else
        Dxl.writeWord(recData[2], recData[5], ((recData[6] << 8) | recData[7]));

      memset(recData, 0, lengthOfRecData);
    }
    vTaskDelay(1);  // Yield to allow other tasks to execute
  }
}

