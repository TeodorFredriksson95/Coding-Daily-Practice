#include <Arduino.h>


// put function declarations here:
int myFunction(int, int);

void setup() {
  // put your setup code here, to run once:
  int result = myFunction(2, 3);


  //ESP32 devkit board initialization
  delay(2000);
  Serial.begin(9600);
  Serial.println("ESP32 is up and running!");
}

void loop() {
  // put your main code here, to run repeatedly:
}

// put function definitions here:
int myFunction(int x, int y) {
  return x + y;
}