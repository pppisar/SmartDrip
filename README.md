# Smart drip
## DISCLAMER
The idea of a smart drip was not developed by me, but was taken from [International Journal of Computer Sciences and Engineering](https://www.ijcseonline.org/full_paper_view.php?paper_id=4637) and slightly modified according to my requirements.

Also, this project was developed as part of the "Peripheral Devices" course at Taras Shevchenko National University of Kyiv, so some comments in the code and the client application interface are implemented in Ukrainian.
## USED SOFTWARE
- `Proteus`: Release 8.11 SP00 (Build 30052) with Advanced Simulation;
- `Bascom-AVR`: Version 2.0.7.9;
- Development environment for the device control application: `Visual Studio 2022` (With .NET desktop development module installed); 
- COM port emulation: `Virtual Serial Ports Emulator` (VSPE).
## TASK
Assemble a circuit in Proteus with the Arduino Uno R3 microcontroller, to which the temperature sensor, the liquid level sensor (in the drip), and the motor should be connected. The microcontroller should send data of the liquid level in the drip and the patient's temperature to the clien(nurse) application.
Additionally, you need to add a display to the circuit that will show the current patient's temperature and the liquid level in the drip in an progress bar style. 
If the liquid level drops below 10%, a notification should be sent to the client(nurse) application, and the motor should be activated to stop the liquid supply in the drip. At the same time, the liquid level indicator on the display should blink, and a red LED should light up.
## USED COMPONENTS
- [Arduino Uno R3](https://www.theengineeringprojects.com/2015/12/arduino-uno-library-proteus.html)
- [Water Level Sensor](https://www.theengineeringprojects.com/2020/07/water-sensor-library-for-proteus.html)
- Display (**LN016L**)
- Temperature sensor (**LM35**)
- Serial Port (**COMPIM**)
- Relay (**G2R-14-DC5**)
- Transistor (**BC547**)
- Motor
- Red LED
- 12V battery
## CIRCUIT DIAGRAM
![Smart Drip Circuit Diagram](/images/circuit_diagram.png)
## EXAMPLES OF WORK
### High level of liquid
![High level of liquid example](/images/high_liquid_level.png)
### Low level of liquid
![Low level of liquid example](/images/low_liquid_level.png)