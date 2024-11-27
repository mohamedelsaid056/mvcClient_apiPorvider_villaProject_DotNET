

# MagicVilla API & Web Application
Hi Friends,

MagicVilla is a full-stack application consisting of a RESTful API (MagicVilla_VillaAPI) and a web client (MagicVilla_Web) for managing villa properties and bookings.

Demo Link:- https://magicvilla-dnm.azurewebsites.net/

Git Link:- https://github.com/mohamedelsaid056/mvcClient_apiPorvider_villaProject_DotNET

## Features

- 🏠 Villa Management (CRUD operations)
- 🔢 Villa Number Management
- 🔐 JWT Authentication & Authorization
- 🍪 Cookie-based Authentication (Web Client)
- 📱 API Versioning
- 📚 Swagger Documentation
- 🖼️ Static File Handling for Images
- ⚡ Caching Support
- 🔄 Automatic Database Migrations

## Technology Stack

- **Backend:**
  - ASP.NET API 7.0+
  - Entity Framework Core
  - SQL Server
  - AutoMapper
  - JWT Bearer Authentication
  
- **Frontend:**
  - ASP.NET  MVC
  - Bootstrap 5
  - JavaScript

## Prerequisites

- .NET 7.0 SDK or later
- SQL Server
- Visual Studio 2022 or VS Code

## Getting Started

1. **Clone the repository**
   ```bash
   git clone [https://github.com/mohamedelsaid056/mvcClient_apiPorvider_villaProject_DotNET
   ```

2. **Update Connection String**
   - Navigate to `appsettings.json` in both API and Web projects
   - Update the `DefaultSQLConnection` to your SQL Server instance

3. **Apply Database Migrations**
   - The application will automatically apply pending migrations on startup
   - Alternatively, you can run manually:
     ```bash
     dotnet ef database update
     ```

4. **Run the Applications**
   - Start the API project first
   - Then start the Web project
   - API Swagger documentation will be available at: `https://localhost:[port]/`

## How Project is structured 

- **MagicVilla_VillaAPI/**
  - RESTful API implementation
  - JWT Authentication
  - Repository Pattern
  - Custom Exception Handling
  - API Versioning
  
- **MagicVilla_Web/**
  - MVC Web Application
  - Service Pattern for API Consumption
  - Cookie Authentication
  - Exception Handling

 Below, I have Pasted the high level glimpse project structure.
 
 ![14th](https://github.com/user-attachments/assets/76253e1f-4860-4ced-8dc9-11338610ff10)

 APIs Structure goes like

 ![16th](https://github.com/user-attachments/assets/28a393f9-f798-4aa8-8ae3-9ee0a52ccdc1)

 Here, you will get Custom middleware implementation, extension methods, DTOs, Custom Error Handling and few Helper methods as well.

 MVC asp .NET Project as consumer for API  looks like 

 ![16th](https://github.com/user-attachments/assets/adc05230-30d7-484b-9eb8-f79f90954114)

 
  

## API Endpoints

The API supports two versions (v1 and v2) with the following main endpoints:

- `/api/v{version}/VillaAPI` - Villa management
- `/api/v{version}/VillaNumberAPI` - Villa number management
- `/api/v{version}/UsersAuth` - Authentication endpoints



 ## NuGet Paackage In Backend 
####  ORM
install-package Microsoft.EntityFrameworkCore.Sqlite  
install-package Microsoft.EntityFrameworkCore  
install-package Microsoft.EntityFrameworkCore.Design  

#### Identity 
install-package microsoft.aspnetcore.identity.EntityFrameworkCore  
install-package microsoft.aspnetcore.identity  
install-package microsoft.identitymodel.tokens  
install-package System.IdentityModel.Tokens.Jwt 

## Store Data   
using **SQLite** for **Development** enviroment and **Production** also 





## Authentication

- **API:** Uses JWT Bearer token authentication
- **Web:** Uses Cookie authentication with a 30-minute session timeout

## Configuration

Key configuration options are available in `appsettings.json`:

- Database connection string
- JWT settings
- API URLs
- Authentication settings

## Error Handling

- Custom exception middleware
- Global error handling
- Logging support
- Custom error pages


## Glimpse of the working solution

Demo Link:- https://magicvilla-dnm.azurewebsites.net/

![1st](https://github.com/user-attachments/assets/ae643a10-0091-4d07-a8b7-8676b8fc30f8)

![2st](https://github.com/user-attachments/assets/ad3a1ec5-2bd2-4186-915c-f36730d6acbd)

![3st](https://github.com/user-attachments/assets/aca66f74-91c4-4f2d-a123-d9cc237fd910)

![4st](https://github.com/user-attachments/assets/8417cb5a-8361-4564-bf53-eaea4916fe04)

![5st](https://github.com/user-attachments/assets/3d8ce636-05ae-4a50-8ea1-696ed2f9c8c3)

![6st](https://github.com/user-attachments/assets/7873ec03-de40-46d8-aa1a-5546fc3aa0c8)

## Running the project

## Running the Project

### Prerequisites Setup

1. **Database Configuration**
   - Open `appsettings.json` in `MagicVilla_VillaAPI` project
   - Update the `DefaultSQLConnection` string to your SQL Server instance:
     ```json
     "ConnectionStrings": {
       "DefaultSQLConnection": "Server=YOUR_SERVER;Database=MagicVilla;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
     ```

2. **JWT Configuration**
   - In `MagicVilla_VillaAPI/appsettings.json`, ensure the JWT secret key is set:
     ```json
     "ApiSettings": {
       "Secret": "YOUR_SECRET_KEY"
     }
     ```

### Starting the Projects

1. **Start the API Project First**
   ```bash
   cd MagicVilla_VillaAPI
   dotnet run
   ```
   The API will:
   - Automatically apply any pending migrations
   - Start the Swagger UI at `https://localhost:4200/`
   - Set up static file handling for images in the `/images` directory
   - Enable JWT authentication

2. **Start the Web Project**
   ```bash
   cd MagicVilla_Web
   dotnet run
   ```
   The Web application will:
   - Start with cookie-based authentication
   - Session timeout set to 30 minutes
   - Redirect to `/Auth/Login` for unauthorized access

### Available Features

- **API Documentation:** Access Swagger UI at the root URL
  - Version 1: `/swagger/v1/swagger.json`
  - Version 2: `/swagger/v2/swagger.json`

- **Authentication:**
  - API uses JWT Bearer tokens
  - Web client uses cookie authentication
  - Login path: `/Auth/Login`
  - Access denied path: `/Auth/AccessDenied`

- **Static Files:**
  - Images are served from the `/images` directory in the API project
  - Access images via: `https://localhost:4200/images/[filename]`

### Development vs Production

- **Development Environment:**
  - Detailed error messages
  - Swagger UI available at `/swagger`
  - Exception handling with detailed information

- **Production Environment:**
  - Swagger UI available at root URL
  - HSTS enabled
  - Custom error handling middleware
  - Secure static file serving



