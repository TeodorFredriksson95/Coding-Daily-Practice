#include <Arduino.h>
#include <WiFi.h>
#include "secrets.h"
#include <HTTPClient.h>

// put function declarations here:
int myFunction(int, int);


WiFiServer server(80);

int ledPin = 5;
void setup() {
  Serial.begin(115200);
  pinMode(ledPin, OUTPUT);  // set the LED pin mode

  delay(10);

  // We start by connecting to a WiFi network

  Serial.println();
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(WIFI_SSID);

  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected.");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());

  server.begin();
}

void loop() {
int mockValue = 42;
  if (WiFi.status() == WL_CONNECTED) {
    HTTPClient http;

    // --- Send mockValue to ESP8266 as JSON ---
    String url = String("http://") + ESP8266_IP + "/send-data";
    http.begin(url);  // Start the POST request
    http.addHeader("Content-Type", "application/json");

    // Build JSON string
    String json = "{\"value\": " + String(mockValue) + "}";

    int httpCode = http.POST(json);

    if (httpCode > 0) {
      String response = http.getString();
      Serial.println("POST Response: " + response);
    } else {
      Serial.println("POST Failed. Code: " + String(httpCode));
    }
    http.end();


      
    delay(500); // Short delay before sending next request

    // Request soil moisture data from /soil-mostiure endpoint at 8266
    String moistureUrl = String("http://") + ESP8266_IP + "/soil-moisture";
    http.begin(moistureUrl);
    httpCode = http.GET();

    if (httpCode > 0) {
      String moistureValue = http.getString();
      Serial.println("Soil Moisture Value: " + moistureValue);
    } else {
      Serial.println("Failed to fetch soil data. HTTP Code: " + String(httpCode));
    }
    http.end();

  } else {
    Serial.println("WiFi not connected");
  }

  //Five second delay before repeating the loop
  delay(5000);


}


// put function definitions here:
int myFunction(int x, int y) {
  return x + y;
}