# 🧱 Clean Architecture (.NET Core) Practice Project

This is a practice project built using **ASP.NET Core** to demonstrate the **Clean Architecture** pattern in a modular and scalable way. It focuses on best practices like separation of concerns, dependency injection, and domain-driven design principles.

---

## 🗂️ Project Structure

The project is structured into the following layers:

```
CleanArchitecture/
│
├── CleanArchitecture.Domain           # Core business logic and entities
├── CleanArchitecture.Application      # Application logic, interfaces, and services
├── CleanArchitecture.Infrastructure   # Infrastructure implementations (e.g., data access)
├── CleanArchitecture.Presentation     # ASP.NET Core Web API
├── CleanArchitecture.Contracts        # DTOs shared between layers
└── README.md
```

---

## ✨ Features

- Clean Architecture with clearly separated layers
- .NET 9 minimal API setup
- Swagger (OpenAPI) enabled
- In-memory database for data persistence
- Example controller for managing orders (`OrderController`)
- Basic CRUD operations
- Development environment configured
- Ready for extension with real database or external services

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 or later

### Run the Project

1. Clone the repository:

```bash
git clone https://github.com/your-username/CleanArchitecture.git
```

2. Navigate to the project folder:

```bash
cd CleanArchitecture/CleanArchitecture
```

3. Run the application:

```bash
dotnet run --project CleanArchitecture.Presentation
```

4. Open the browser and go to:

```
https://localhost:7061/swagger
```

---

## 🛠 Technologies Used

- ASP.NET Core 9.0
- C#
- Entity Framework Core (InMemory)
- Swagger / OpenAPI
- Visual Studio 2022

---

## 🧠 Clean Architecture Benefits

- **Framework Independent**: Core logic is decoupled from frameworks.
- **Testable**: Each layer can be unit tested independently.
- **Separation of Concerns**: Presentation, Application, and Domain are cleanly split.
- **Maintainable**: Easy to scale and extend.
- **Domain-Centric**: Business rules remain at the core.

---

## 📬 Contact

This project was built as part of learning and practicing Clean Architecture in .NET Core.

For feedback or collaboration, feel free to connect.

---
