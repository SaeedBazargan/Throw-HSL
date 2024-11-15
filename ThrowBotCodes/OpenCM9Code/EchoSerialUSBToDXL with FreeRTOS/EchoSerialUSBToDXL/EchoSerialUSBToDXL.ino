#include <MapleFreeRTOS.h>
#include <stdint.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>


#define DXL_BUS_SERIAL1           1

#define lengthOfChar              50
#define msg_queue_length          10

static xQueueHandle Queue_1;
static xTaskHandle recordTask_Handle = NULL;
static xTaskHandle echoTask_Handle = NULL;

void startTask1(void* parameters);
void startTask2(void* parameters);

Dynamixel Dxl(DXL_BUS_SERIAL1);

void setup() 
{
  Dxl.begin(3);
  
  Queue_1 = xQueueCreate(msg_queue_length, lengthOfChar);

  xTaskCreate(startTask1, (signed char *)"TASK_1", configMINIMAL_STACK_SIZE, NULL, 1, &recordTask_Handle);
  xTaskCreate(startTask2, (signed char *)"TASK_2", configMINIMAL_STACK_SIZE, NULL, 1, &echoTask_Handle);
  vTaskStartScheduler();
}

void loop()
{}

void startTask1(void* parameters)
{
  char recChar_c[lengthOfChar] = {0};
  uint8_t counterOfRecChar = 0;
  
  while (1)
  {
    if (SerialUSB.available())
    {
      if (counterOfRecChar < lengthOfChar - 1) 
      {
        recChar_c[counterOfRecChar++] = SerialUSB.read();
      }
      if (counterOfRecChar >= (recChar_c[3] + 4))
      {
        if (xQueueSend(Queue_1, (void*)recChar_c, 0) != pdTRUE)
        {
          SerialUSB.println("Queue Full!");
        }
        memset(recChar_c, 0, lengthOfChar);
        counterOfRecChar = 0;
      }
    }
    vTaskDelay(1);  // Yield to allow other tasks to execute
  }
}

void startTask2(void* parameters)
{
  char recChar_c[lengthOfChar] = {0};
  
  while (1)
  {
    if (xQueueReceive(Queue_1, (void*)recChar_c, portMAX_DELAY) == pdTRUE)
    {
      Dxl.writeWord(recChar_c[2], recChar_c[5], ((recChar_c[6] << 8) | recChar_c[7]));

      memset(recChar_c, 0, lengthOfChar);
    }
    vTaskDelay(1);  // Yield to allow other tasks to execute
  }
}

