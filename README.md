

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

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

[Your chosen license]

## Acknowledgments

- Built following best practices and design patterns
- Implements secure authentication and authorization
- Includes comprehensive API documentation
