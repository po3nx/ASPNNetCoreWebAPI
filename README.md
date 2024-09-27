# ASP.NET Core API With Clean Architecture

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-5.0-blue)
![Clean Architecture](https://img.shields.io/badge/Clean%20Architecture-Implemented-brightgreen)
![License](https://img.shields.io/badge/License-MIT-orange)

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Architecture Overview](#architecture-overview)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

This project is an ASP.NET Core API built using Clean Architecture principles. Clean Architecture helps to maintain a separation of concerns, making the codebase more maintainable, testable, and scalable.

## Features

- RESTful API endpoints
- Repository pattern for data access
- Dependency Injection
- Swagger for API documentation

## Technologies Used

- ASP.NET Core 5.0
- Entity Framework Core
- AutoMapper
- Swagger

## Getting Started

### Prerequisites

- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other supported database)

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/po3nx/ASPNetCoreWebAPI.git
    cd ASPNetCoreWebAPI
    ```

2. Set up the database:
   - Update the connection string in `appsettings.json`.
   - Apply migrations:
     ```sh
     dotnet ef database update
     ```

3. Run the application:
    ```sh
    dotnet run
    ```

4. Navigate to `https://localhost:7298/swagger` to view the Swagger UI.

## Architecture Overview

The project follows Clean Architecture, which divides the project into layers:

- **API**: Handles HTTP requests and responses.
- **Application**: Contains business logic, services, DTOs, and mappings.
- **Domain**: Represents core business entities and logic.
- **Infrastructure**: Manages data access and external integrations.

## Project Structure

```
src
├── API
│   ├── API.csproj
│   ├── Controllers
│   └── Program.cs
├── Application
│   ├── Application.csproj
│   ├── Interfaces
│   ├── Services
│   ├── DTOs
│   └── Mappings
├── Domain
│   ├── Domain.csproj
│   ├── Entities
│   ├── Enums
│   ├── Exceptions
│   └── ValueObjects
└── Infrastructure
    ├── Infrastructure.csproj
    ├── Data
    ├── Repositories
    ├── Migrations
    └── Configuration

```

## Usage

### Running the Application

To run the application locally, use the following command:

```sh
dotnet run --project src/API
```



## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -am 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

- **Author**: Purwanto
- **GitHub**: [[po3nx]](https://github.com/po3nx)