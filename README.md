# DotNetSampleProject

A small ASP.NET Core Web API sample with a basic CRUD-style controller for "Items".

## Tech Stack
- .NET 8
- ASP.NET Core Web API
- C#

## Project Structure
```
DotNetSampleProject/
├── src/
│   └── DotNetSampleProject/
│       ├── Controllers/
│       │   └── ItemsController.cs
│       ├── Models/
│       │   └── Item.cs
│       ├── Services/
│       │   └── IItemService.cs
│       │   └── ItemService.cs
│       ├── Program.cs
│       └── DotNetSampleProject.csproj
├── .gitignore
└── README.md
```

## Getting Started

### Prerequisites
- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

### Run
```bash
cd src/DotNetSampleProject
dotnet restore
dotnet run
```

API will be available at `https://localhost:5001/api/items`

## License
MIT
