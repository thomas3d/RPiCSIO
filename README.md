# RPiCSIO
Raspberry Pi C# IO library

A C# interface library "Cynic" have been working on for the Raspberry Pi2. RPi3 and RPi0 support is to follow soon. The home page is: http://www.ofitselfso.com/RPICSIO/RPICSIO.php


RPICSIO is a free and open source .NET v4 library which provides a pretty comprehensive C# input/output solution for the Raspberry Pi 2 Mono environment. The basic features of this software are:
Provides simple and transparent read/write access (including the triggering of events) to the GPIO pins of a Raspberry Pi 2. A maximum output frequency of about 
2.4MHz is possible when using a memory mapped port class and about 1.1Khz when using the SYSFS class.
The SPI port is fully supported. It is possible to use GPIO ports to provide a large number of SPI device select lines.
The I2C port is fully supported.
The Serial/UART port is fully supported.
The Pulse Width Modulation (PWM) device is fully supported. The PWM duty cycle can be specified in nano-seconds or as a percentage of the base frequency.
The RPICSIO software is completely written in C# and a .NET project is included with the source code. This software is offered as a binary and with source code under the terms of the MIT License.
