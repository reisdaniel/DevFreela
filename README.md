# **DevFreela**

**DevFreela** is a complete application for managing freelancers and projects, developed as part of an advanced practical study in **C#** and **ASP.NET Core**. This project incorporates software architecture best practices, design patterns, and modern tools to build scalable and robust APIs.

---

## **📋 Implemented Features**

### **1. RESTful API Development**
- **User and freelancer registration**.
- **Project management**, including functionalities such as:
  - Creating and updating projects.
  - Uploading profile pictures.
- **Global exception handling** using middlewares, providing standardized responses in the `ProblemDetails` format.

---

## **🔨 Technologies and Tools**

| **Technology**        | **Description**                                                               |
|------------------------|-------------------------------------------------------------------------------|
| **C#**                | Primary language used for backend development.                               |
| **ASP.NET Core**      | Framework for building scalable RESTful APIs.                                |
| **Dependency Injection** | Modular and extensible project configuration.                              |
| **Middlewares**        | Global exception handling for consistent responses.                         |

---

## **📈 Current Project Structure**

### **Design and Organization**
The project follows a modular design to ensure scalability and maintainability. Functionalities are organized into well-defined layers with clear responsibilities.

#### **Current Structure:**
```plaintext
DevFreela.API
│
├── Controllers
│   ├── ProjectsController.cs
│   ├── UsersController.cs
│
├── Services
│   ├── IConfigService.cs
│   ├── ConfigService.cs
│
├── Models
│   ├── FreelanceTotalCostConfig.cs
│
├── ExceptionHandler
│   ├── ApiExceptionHandler.cs
│
└── Program.cs
```
## **📚 Next Steps**

The development of **DevFreela** will continue with the implementation of advanced features, focusing on improving scalability, maintainability, and reliability. Here are the key upcoming steps:

### **1. Database Integration**
- Integration with **Entity Framework Core** to manage data persistence efficiently.
- Design and implementation of database schemas to store user, freelancer, and project information.
- Leveraging migrations for version-controlled database updates.

### **2. Clean Architecture**
- Organizing the project into distinct layers:
  - **Domain Layer**: Core business logic and domain entities.
  - **Application Layer**: Handles commands, queries, and application-specific operations.
  - **Infrastructure Layer**: Manages external integrations like database access and third-party services.
- Adopting principles of **Clean Architecture** to ensure separation of concerns.

### **3. Design Patterns**
- Implementation of **CQRS (Command Query Responsibility Segregation)** to optimize the performance of read and write operations, separating them into distinct paths.
- Use of **Repository Pattern** to abstract database interactions and centralize data access logic.

### **4. Validation and Testing**
- Adding robust validation to ensure data integrity in API requests.
- Development of comprehensive **unit tests** to validate individual components.
- Integration tests to verify end-to-end functionality across the system.

---

## **⚙️ How to Run the Project**

### **Requirements**
- **.NET 6** or higher installed.
- A code editor like **Visual Studio** or **Visual Studio Code**.

### **Steps**
1. Clone the repository:
   ```bash
   git clone https://github.com/reisdaniel/DevFreela.git
   cd devfreela
   ```
2. Restore NuGet packages:
    ```bash
    dotnet restore
    ```
3. Configure environment variables or settings for the project.
4. Run the application:
    ```bash
    dotnet run
    ```
5. Access the application:
    - Swagger Documentation: http://localhost:5000/swagger

## **📜 License**

This project is licensed under the **Creative Commons Attribution-NonCommercial 4.0 (CC BY-NC 4.0)**.  
You are free to:
- Share: Copy and redistribute the material in any medium or format.
- Adapt: Remix, transform, and build upon the material.

Under the following terms:
- **Attribution:** You must give appropriate credit to the original creator ([Professor Luis de Oliveira](https://www.linkedin.com/in/luisdeol/)) and provide a link to the source.
- **NonCommercial:** You may not use the material for commercial purposes.
---

## **Acknowledgments**

This project, **DevFreela**, is part of a hands-on learning experience guided by **Professor Luis de Oliveira** through the [Next Wave Education](https://www.linkedin.com/company/next-wave-education/) platform.  
The implementation is being adapted and developed by me, following the course structure and applying the knowledge taught in real-world scenarios.

