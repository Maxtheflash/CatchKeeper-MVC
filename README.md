## Catch Keeper – Angler’s Log (ASP.NET MVC)

Catch Keeper is an ASP.NET MVC application that allows anglers to record, track, and analyze their fishing catches.
It includes detailed logging, weather notes, water conditions, species tracking, and photo support — all wrapped in a clean, scalable MVC architecture.

## Features:
Catch Logging
Store detailed catch information:
- Species
- Length & Weight
- Bait / Technique
- Water Conditions
- Date & Time
- Notes
- Photos
- Location-type selection (future GPS integration)

Clean MVC Architecture
- Controllers handle CRUD logic
- Models represent real-world catch data
- Razor Views provide a clean UI
- ViewModels facilitate structured data binding

SQL Database Integration
- Entity Framework
- Migrations
- EF-backed models

Secure & Scalable Structure
- Future-ready for:
- Authentication
- User roles
- Cloud deployment

## Tech Stack
Language: C#
Framework: ASP.NET MVC
Database: SQL Server / LocalDB
Frontend: Razor, Bootstrap, HTML5
Tools: Visual Studio, GitHub
Architecture: MVC Pattern

## Project Structure

```
CatchKeeperMVC/
│
├── App_Data/
├── App_Start/
├── Content/
├── Controllers/
├── Migrations/
├── Models/
├── Properties/
├── Scripts/
├── Views/
│ ├── Catch/
│ ├── Shared/
│ └── Home/
│
├── favicon.ico
├── Global.asax
├── Web.config
├── CatchKeeperMVC.csproj
└── CatchKeeperMVC.sln
```

## Screenshots (Coming Soon)
- Homepage
- Add Catch form
- Catch List screen
- Edit screen
- Data table view

## Future Enhancements
- Weather API integration
- GPS map tagging
- Mobile-friendly layout
- ML.NET prediction engine
- User login system

## Author
Branden Maxwell
Software Developer (.NET | SQL | MVC)
GitHub: https://github.com/Maxtheflash
