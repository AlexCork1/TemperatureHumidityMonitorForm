# TemperatureHumidityMonitorForm

## Overview
The Windows Form application serves as a data reception and visualization platform, specifically tailored for temperature and humidity data received in JSON format over a serial port connection. It provides a comprehensive solution for users seeking an efficient and visually appealing method to monitor environmental conditions.

## Features
a. Serial Port Communication: The application establishes a communication link with external devices transmitting data through a serial port. It efficiently captures incoming JSON-formatted temperature and humidity data in background service (background worker)<br />
b. JSON Data Parsing: The application includes a parsing mechanism to extract relevant information from the incoming JSON data, ensuring accurate representation of temperature and humidity values and error state.<br />
c. User Interface: The graphical user interface (GUI) of the application is built using Windows Forms, offering an intuitive and user-friendly environment. Users can easily navigate and interact with the application.<br />
d. Real-time Data Visualization: A charting component is integrated into the application to dynamically visualize temperature and humidity trends over time. The graphical representation enhances the user's ability to interpret and analyze the data.<br />
e. Logging: Trace logging is used to save received data in output txt file.

## Implementation Details
a. Programming Language: C#<br />
b. Framework: .NET Framework 4.7.2<br />
c. Charting Library: System.Windows.Forms.DataVisualization.Charting.Chart<br />

## System Requirements
a. Operating System: The application is designed to run on Windows operating systems, ensuring compatibility with a wide range of Windows versions.<br />

## Conclusion
This Windows Form application offers a comprehensive solution for users seeking to receive, process, and visualize temperature and humidity data transmitted over a serial port. By combining effective serial communication, JSON data parsing, and real-time charting, the application provides a valuable tool for monitoring and analyzing environmental conditions.<br />
