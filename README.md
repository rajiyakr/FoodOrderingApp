# FoodOrderingApp
A dynamic and interactive food ordering system built with ASP.NET Core MVC, integrated with the Forkify API for real-time food data. This project allows users to browse, select, and order food items with live cart updates and seamless UI interactions using AJAX.

✨ Features
🔐 User Authentication (Login/Signup with session handling)

🍕 Dynamic Food Listing from Forkify API

🛒 Real-Time Cart Updates (Add/Remove items)

🧾 Order Summary before checkout

⚡ AJAX used for smoother user experience (no full page reloads)

📄 Razor Views with layout and partial views

💽 SQL Server for storing user data and orders

🛠️ Tech Stack
Back-End: ASP.NET Core MVC, Entity Framework

Front-End: HTML, CSS, Bootstrap, AJAX

Database: SQL Server (.mdf)

API Integration: Forkify API

Tools: Visual Studio 2022, SQL Server Management Studio (SSMS)

Project Structure
├── Controllers
│   └── FoodController.cs
├── Models
│   └── FoodItem.cs, Order.cs, User.cs
├── Views
│   └── Food (Index.cshtml, Cart.cshtml)
│   └── Shared (Layout.cshtml)
├── wwwroot
│   └── css, js, images
├── appsettings.json
└── Program.cs 
