This project is going to serve as base for future daily coding practices. The reason for this project is that my efforts are scattered, tiny bits of enormous scopes of work. As these projects are generally slow-going, even in intervals, I feel the takeaways and learnings from the project assignments become muddied and without a clear foothold in my mind. This project will serve as a counter measure to this. It is here that I will consolidate my theoretical and practical experience. Functions, classes, utilites that serve a purpose without necessarily being influenced by a specific project task, which I feel might otherwise influence how I percieve and tackle the task.

17/7-2025
* Set up a basic C# environment with dictionary file.
* Dictionary Practice
-- Initialize and add values
-- TryGetValue method

18/7-2025
* Dictionary Practice
-- Create helper method to add values. Params consist of a dict, key and value. Use ContaindsKey method as safety check.

19/7-2025
* CPP, Arduino and PlatformIO IDE Setup

* Arduino
-- Set up ESP32 Devboard
-- Verified first build and initial upload completed

20/7-2025
* Arduino
-- Connected ESP32 Devkit to WIFI. Need a LED to further test I/O flow.

21/7-2025
* Home Plant Watering System
-- Prepared physical connection between breadboard --> ESP32 Devboard --> MT3608 regulator OUT/IN --> 3.7V litihum battery
-- Set up basic "Workflow & Diagnosis" schema

* C# Dictionaries
-- Tried out custom EqualityComparer for Dictionaries using objects as keys.
-- Made a Dictionary helper method. Lives in separate file, potential to grow into helper library.

22/7-2025
* HPWS
-- Tested electrical components of ESP8266 --> MT3608

23/7-2025
* HPWS
-- Spliced and connected wires from battery --> MT3608
-- Soldered MT3608 IN/OUT +/- pins
-- Soldered MT3608 pentiometer connector pins
-- Connected MT3608 to ESP32
-- External battery supply for ESP32 is now working. Proceed with ESP8266 Wifi connectivity.