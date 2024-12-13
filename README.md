# Robot Control System for Automated Guided Vehicles (AGVs)

## Overview

This project focuses on the development of a Robot Control System designed to streamline coordination and communication between Automated Guided Vehicles (AGVs) in warehouse operations. The system enhances the efficiency of warehouse processes by enabling seamless interaction and communication between the AGVs and a central control system. 

The control system utilizes a WinForm application for:
- Serializing data into JSON format
- Generating HTTP requests
- Retrieving responses via a web server

This system ensures smoother data flow and better coordination between the AGVs, which improves overall warehouse automation.

## Features

- **AGV Coordination**: Efficient communication between multiple AGVs.
- **Data Serialization**: Data is serialized into JSON format for easy transmission and parsing.
- **Web Server Integration**: HTTP requests are sent to a web server, which processes the data and responds accordingly.
- **WinForm Application**: A simple user interface built with WinForms for managing and controlling the AGVs.
- **Error Handling**: Robust error handling for reliable communication and data processing.

## Technologies Used

- **C#** for the WinForm application.
- **JSON** for data serialization.
- **HTTP** protocol for communication between the WinForm application and the web server.
- **Web Server** for receiving and processing requests from AGVs.
- **AGV Control**: Integration with the AGVs for data retrieval and communication.

## System Architecture

The system consists of three main components:
1. **WinForm Application**: Provides a user interface for interacting with the system. It manages data serialization and HTTP requests.
2. **Web Server**: Receives HTTP requests from the WinForm application, processes them, and sends back responses.
3. **Automated Guided Vehicles (AGVs)**: The robots in the warehouse that communicate with the system for coordinated operations.

### Flow of Communication

1. The WinForm application sends data requests via HTTP to the web server.
2. The web server processes the request, retrieves the required data, and sends a response back to the WinForm application.
3. The application serializes the response data into a JSON format, enabling further communication with the AGVs or other systems.

## Installation

### Prerequisites
- .NET Framework
- Visual Studio for development (or compatible IDE)
- Web server environment for handling HTTP requests

### Steps to Set Up

1. Clone or download the project repository.
2. Open the project in Visual Studio.
3. Build the solution to restore any dependencies.
4. Run the WinForm application from the IDE.
5. Ensure that the web server is set up and running for receiving HTTP requests.
6. Connect AGVs to the system for automated operations.

## Usage

1. Launch the WinForm application.
2. Configure the AGVs and web server details within the application.
3. Use the user interface to send commands to the AGVs, monitor their status, and receive updates from the web server.

## Contributing

Feel free to fork this repository and submit pull requests if you have improvements or bug fixes. 

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Bastian Solutions for the opportunity to work on this project.
- The development team for their collaboration and support.
