# Blazor & Grpc

BlazorGrpc is a project demonstrating the integration of Blazor and gRPC for building a real-time, highly responsive web application using modern web technologies. This project aims to showcase how Blazor WebAssembly and gRPC can be used together to create efficient and scalable web applications. It also includes a custom implementation of the MediatR pattern to manage application logic and messaging.

## Features

- **Blazor WebAssembly**: Client-side web UI framework using C# and .NET.
- **QuickGrid Integration**: Includes QuickGrid, a powerful and lightweight grid component tailored for Blazor applications, offering high performance, customization, and the ability to efficiently handle large datasets.https://aspnet.github.io/quickgridsamples/
- **MudBlazor**: Includes MudBlazor Components https://mudblazor.com/
- **gRPC**: High-performance, open-source RPC framework that can run in any environment.
- **Real-time Communication**: Utilize gRPC to establish real-time communication between the client and server.
- **Scalable Architecture**: Designed to handle high loads and scale efficiently.
- **Custom MediatR Implementation**: A custom implementation of the MediatR pattern to facilitate in-process messaging and command handling , inspired by the MediatR library 
https://github.com/jbogard/MediatR
- **Repository Pattern & Unit of Work**: Implements the Repository pattern and Unit of Work to manage data persistence, providing a clean separation of concerns.
- **Entity Framework Core & SQLite**: Utilizes EF Core and SQLite for data storage, enabling a lightweight and efficient database solution. https://learn.microsoft.com/en-us/ef/core/
- **Simple Fluent Validation Library**:  This repository contains a Simple Fluent Validation Library, a lightweight validation framework inspired by the FluentValidation library

## Getting Started

### Prerequisites

Ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (or later) with ASP.NET and Blazor web development workload

### Installation

1. **Clone the repository**:

    ```sh
    git clone https://github.com/stevsharp/BlazorGrpc.git
    cd BlazorGrpc
    ```

2. **Restore dependencies**:

    ```sh
    dotnet restore
    ```

3. **Build the project**:

    ```sh
    dotnet build
    ```

### Running the Application

1. **Start the gRPC server**:

    ```sh
    dotnet run --project Server/BlazorGrpc.Server.csproj
    ```
2. Open your browser and navigate to `https://localhost:5001` to see the application in action.

## Project Structure

- **Server**: Contains the gRPC server implementation using ASP.NET Core.
- **Client**: Blazor WebAssembly project acting as the frontend.
- **Shared**: Shared project containing common code and proto files used by both the server and client.
- **CustomMediatR**: A custom implementation of the MediatR pattern for managing in-process messaging and command handling.

## Usage

The BlazorGrpc project demonstrates basic CRUD operations using gRPC and includes a custom MediatR implementation to manage application logic. It serves as a starting point for building more complex applications using Blazor and gRPC.

### Custom MediatR Implementation

The custom implementation provides an example of how to use in-process messaging to decouple components within an application. To use it:

1. **Define Request and Response Types**: Create request and response classes for your commands and queries.
2. **Implement Handlers**: Create handler classes that implement the logic for processing each request.
3. **Register Handlers**: Use dependency injection to register your handlers in the service container.
4. **Send Requests**: Use the mediator to send requests and handle responses.

### Adding a New Feature

1. Define your gRPC service in a `.proto` file in the `Shared` project.
2. Generate the gRPC client and server code using `dotnet-grpc` tools.
3. Implement the service in the `Server` project.
4. Inject and use the generated client in the `Client` project.
5. Define and implement new requests and handlers for your custom MediatR setup as needed.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes. Ensure your code follows the project's coding standards and includes appropriate tests.

### Steps to Contribute

1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Make your changes and commit them.
4. Push your changes to your fork.
5. Create a pull request to the main repository.

## Acknowledgements

- The .NET Foundation for providing a robust platform.
- The gRPC contributors for creating a powerful RPC framework.
- The Blazor community for continuous support and contributions.
- The MediatR community for inspiring the custom implementation pattern.

## Connect with Me

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue)](https://www.linkedin.com/in/spyros-ponaris-913a6937/)
