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

24/7-2025
* C#
-- Practicing GetAlternateLookup method for dictionaries in order to optimize lookups. As far as I understand so far, this method provides an allocation free lookup in dictionaries using an alternative type. This seems to be beneficial when looking up ReadOnlySpan<char> keys in a Dictionary<string, x> 
situation. However, if the search key already perfectly matches the key of the dictionary, this seems to cause an overhead instead. I haven't fully grasped this concept yet, as i'm seeing many who in fact vouch for the efficiency of this method even when not using ReeadyOnlySpan<char> as alternative type for lookups. To be further investigated..

25/7-2025
* HPWS Mini Controller (ESP8266)
-- Initialized Mini Controller One project, intended to read analog sensor data --> send/recieve data to/from ESP32 --> control peristaltic pump via MOSFET
-- Verified that intialization and setup is building correctly

* Folder Structure
-- Re-organized folder structure to separate Main Controller(ESP32) from Mini Controller (ESP8266)

26/7-2025
* HPWS Main Controller
-- Connected MOSFET logic SIG/VCC/GND to ESP8266
-- Connected MOSFET power VIN and GND to MT3608
    --* Realized I'm 1 MT3608 short. The peristaltic pump is going to need 12V via the MOSFET and thus I can't let the 5V ESP8266 draw power from the same MT3608. Buy another.
-- Tested MOSFET voltage output on signal from ESP8266 signal pin (D1). Successfully reaches 12V and 0V respectively on set intervals
-- Created endpoint on ESP8266 and registered as server. ESp32 successfully sends mockdata to this endpoint and recieves a response.

27/7-2025
* HPWS Electronics Components
-- Connected capcitive soil sensor to ESP8266

* HPWS Main & Mini Controller 1
-- Registered endpoint for reading soil data
-- Successfully sent request from ESP32 to ESP8266, recieving soil value within the expected range (645 out of 1037)

28/7-2025
* HPWS Main Controller
-- Tested and refactored mock data request code to a handler and changed it from GET to POST

29/7-2025
* HWPS Controllers
-- Changed all HTTP requests handle json instead of using query params
-- Added Start-pump endpoint and request

30/7-2025
* C#
** Arrays
-- 