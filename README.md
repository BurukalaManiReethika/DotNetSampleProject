# 🚀 DotNetSampleProject

A clean, lightweight **ASP.NET Core Web API** built with **.NET 8**, demonstrating modern backend architecture with full CRUD operations, dependency injection, and Swagger documentation — containerized with Docker and deployed live on Render.

🔗 **Live Demo:** [https://dotnetsampleproject-3.onrender.com/swagger](https://dotnetsampleproject-3.onrender.com/swagger)

---

## ✨ Features

- ⚡ RESTful CRUD API for managing **Items**
- 🧱 Clean layered architecture (Controllers → Services → Models)
- 💉 Dependency Injection via built-in .NET DI container
- 📑 Interactive API docs with Swagger/OpenAPI
- 🐳 Dockerized for consistent builds and deployment
- ☁️ Live deployment on Render

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Framework | ASP.NET Core (.NET 8) |
| API Docs | Swagger / Swashbuckle |
| Containerization | Docker |
| Hosting | Render |

---

## 📁 Project Structure

```
DotNetSampleProject/
├── Dockerfile
├── README.md
├── .gitignore
└── src/
    └── DotNetSampleProject/
        ├── Controllers/
        │   └── ItemsController.cs
        ├── Models/
        │   └── Item.cs
        ├── Services/
        │   ├── IItemService.cs
        │   └── ItemService.cs
        ├── Program.cs
        └── DotNetSampleProject.csproj
```

---

## 🚦 API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/items` | Get all items |
| `GET` | `/api/items/{id}` | Get item by ID |
| `POST` | `/api/items` | Create a new item |
| `PUT` | `/api/items/{id}` | Update an existing item |
| `DELETE` | `/api/items/{id}` | Delete an item |

---

## 🧑‍💻 Getting Started Locally

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)

### Run

```bash
git clone https://github.com/BurukalaManiReethika/DotNetSampleProject.git
cd DotNetSampleProject/src/DotNetSampleProject
dotnet restore
dotnet run
```

Then open `https://localhost:5001/swagger` in your browser.

### Run with Docker

```bash
docker build -t dotnetsampleproject .
docker run -p 10000:10000 dotnetsampleproject
```

---

## 📌 Roadmap

- [ ] Add persistent database (SQL Server / PostgreSQL)
- [ ] Add authentication (JWT)
- [ ] Add unit tests (xUnit)
- [ ] Add pagination & filtering

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the [issues page](../../issues).

## 📄 License

This project is licensed under the **MIT License**.

---

### 👤 Author

**Burukala Mani Reethika**
🔗 [GitHub](https://github.com/BurukalaManiReethika)
