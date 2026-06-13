# ToDo List Application (ASP.NET Core MVC + Azure Cosmos DB)

## Overview

This project is a ToDo List application built using ASP.NET Core MVC as part of my journey learning .NET development.

The application allows users to create, view, update, and delete ToDo items while demonstrating key ASP.NET Core concepts such as:

* MVC Architecture
* Dependency Injection
* Repository Pattern
* Razor Views
* CRUD Operations
* Azure Cloud Integration
* Azure Cosmos DB

---

## Project Evolution

This project was developed in multiple stages to understand different data storage approaches.

### Phase 1: In-Memory Repository

Initially, the application used an in-memory repository to understand:

* Repository Pattern
* Dependency Injection
* CRUD Operations
* MVC Architecture

Data was stored only while the application was running.

### Phase 2: SQL Server + Entity Framework Core

The application was then upgraded to use SQL Server with Entity Framework Core.

Concepts learned:

* DbContext
* Entity Framework Core
* Code-First Migrations
* SQL Server Integration
* Persistent Data Storage

### Phase 3: Azure Cosmos DB (Current Version)

The application was migrated to Azure Cosmos DB for cloud-based NoSQL storage.

Concepts learned:

* Azure Cosmos DB
* NoSQL Databases
* Cloud Data Storage
* Azure Resource Management
* Cosmos SDK Integration
* Partition Keys
* Document-Based Data Models

All ToDo items are now stored in Azure Cosmos DB.

---

## Features

* Create ToDo Items
* View All ToDo Items
* Edit Existing ToDo Items
* Delete ToDo Items
* Mark Tasks as Completed
* Cloud-Based Data Storage with Azure Cosmos DB

---

## Technologies Used

### Backend

* ASP.NET Core MVC (.NET 9)
* C#

### Cloud & Database

* Azure Cosmos DB
* Microsoft.Azure.Cosmos SDK

### Frontend

* Razor Views
* HTML
* Bootstrap

### Development Tools

* Visual Studio 2022
* GitHub

---

## Architecture

```text
Controller
    ↓
ITodoRepository
    ↓
CosmosTodoRepository
    ↓
Azure Cosmos DB
```

The application follows the Repository Pattern, allowing data storage implementations to be swapped without affecting controllers or views.

---

## Azure Cosmos DB Configuration

The application uses:

* Database: `todo`
* Container: `todo`
* Partition Key: `/id`

---

## Security

Sensitive configuration values such as Cosmos DB keys should not be committed to source control.

For local development, use:

```bash
dotnet user-secrets init

dotnet user-secrets set "CosmosDb:Key" "<your-key>"
```

---

## Learning Outcomes

Through this project I gained hands-on experience with:

* ASP.NET Core MVC
* Dependency Injection
* Repository Pattern
* CRUD Operations
* Entity Framework Core
* SQL Server
* Azure Cosmos DB
* Cloud Application Development
* GitHub

---

## Future Improvements

* User Authentication & Authorization
* Due Dates
* Azure App Service Deployment
* REST API Version
* Blazor Frontend


