# ToDo List Application (ASP.NET Core MVC)

## Overview

This project is a simple ToDo List application built using **ASP.NET Core MVC** as part of my learning journey into ASP.NET Core development.

The application allows users to create, view, update, and delete ToDo items while demonstrating core ASP.NET MVC concepts such as Controllers, Views, Models, Dependency Injection, Routing, and CRUD operations.

---

## Features

* Create new ToDo items
* View all ToDo items
* Edit existing ToDo items
* Delete ToDo items
* Success message notifications
* In-memory data storage using Repository Pattern

---

## Technologies Used

* ASP.NET Core MVC
* C#
* Razor Views
* Dependency Injection

---

## Project Structure

```text
ToDoList
│
├── Controllers
│   └── TodoController.cs
│
├── Models
│   └── ToDoItem.cs
│
├── Repositories
│   ├── ITodoRepository.cs
│   └── InMemoryToDoRepository.cs
│
├── Views
│   ├── Todo
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   │
│   └── Shared
│       └── _Layout.cshtml
│
├── wwwroot
│   ├── css
│   └── js
│
└── Program.cs
```

---

## Concepts Learned

### MVC Architecture

* Model: Represents application data.
* View: Responsible for displaying UI.
* Controller: Handles user requests and business logic.

### Dependency Injection

The repository is registered using:

```csharp
builder.Services.AddSingleton<ITodoRepository, InMemoryToDoRepository>();
```

This allows ASP.NET Core to inject dependencies automatically into controllers.

## Learning Outcome

Through this project, I learned:

* ASP.NET Core MVC fundamentals
* Routing and Controllers
* Razor Views
* Model Binding
* Dependency Injection
* Repository Pattern
* CRUD Operations

This project is my first practical ASP.NET Core MVC application.
