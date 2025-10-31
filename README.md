# API Tutorial - Learn APIs with ASP.NET Core

An educational ASP.NET Core MVC website that teaches developers how to use APIs in their code with complete examples and explanations.

## Features

- **Comprehensive API Learning**: Learn what APIs are and how to use them effectively
- **REST API Basics**: Understanding HTTP methods, status codes, and RESTful architecture
- **Authentication Guide**: Learn about API Keys, Bearer Tokens, Basic Auth, and OAuth 2.0
- **Real-world API Examples**:
  - GitHub API - Access repositories, users, and manage GitHub resources
  - OpenWeather API - Get weather data and forecasts
  - JSONPlaceholder API - Practice with a free fake REST API
- **Complete Code Examples**: Full C# code samples with detailed explanations
- **Easy Navigation**: Clean, intuitive interface with Bootstrap styling

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later

### Running the Application

1. Navigate to the project directory:
   ```bash
   cd APITutorial
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. Open your browser and navigate to `http://localhost:5000`

## Project Structure

```
APITutorial/
├── Controllers/
│   ├── HomeController.cs          # Main home page controller
│   └── ApiExamplesController.cs   # API examples pages controller
├── Views/
│   ├── Home/
│   │   └── Index.cshtml           # Home page with API introduction
│   ├── ApiExamples/
│   │   ├── RestBasics.cshtml      # REST API fundamentals
│   │   ├── Authentication.cshtml   # API authentication methods
│   │   ├── GitHub.cshtml          # GitHub API examples
│   │   ├── OpenWeather.cshtml     # OpenWeather API examples
│   │   └── JSONPlaceholder.cshtml # JSONPlaceholder API examples
│   └── Shared/
│       └── _Layout.cshtml         # Main layout with navigation
└── wwwroot/                       # Static files (CSS, JS, images)
```

## Topics Covered

### REST API Basics
- HTTP Methods (GET, POST, PUT, DELETE)
- Making requests with HttpClient
- JSON serialization and deserialization
- HTTP status codes
- Error handling

### Authentication
- API Key Authentication
- Bearer Token Authentication
- Basic Authentication
- OAuth 2.0 overview
- Secure credential storage

### GitHub API
- Get user information
- Get repository details
- List repositories
- Search repositories
- Rate limiting
- Authenticated requests

### OpenWeather API
- Current weather data
- Weather by coordinates
- 5-day forecast
- API key configuration
- Error handling

### JSONPlaceholder API
- CRUD operations (Create, Read, Update, Delete)
- GET, POST, PUT, DELETE examples
- Filtering and nested resources
- Generic CRUD service implementation

## Technologies Used

- ASP.NET Core 9.0 MVC
- C# 13
- Bootstrap 5
- HTML5/CSS3

## License

This project is for educational purposes.
