# Budget4U – Personal Finance & Budget Tracker

**Budget4U** is a secure, full-featured personal finance tracker built with **.NET Blazor**. Designed for students, young professionals, and anyone who wants to take control of their spending, Budget4U lets you log transactions, manage budget categories, and visualize your financial health at a glance.

---

## 📋 Table of Contents

1. [Features](#features)
2. [Getting Started](#getting-started)
3. [Using the App](#using-the-app)
4. [User Authentication](#user-authentication)
5. [Technology Stack](#technology-stack)
6. [Project Structure](#project-structure)
7. [Deployment](#deployment)
8. [Contributing](#contributing)

---

## ✨ Features

- **Secure User Accounts** – Register and log in with a personal account; all data is private.
- **Transaction Tracking** – Log income and expenses with amount, date, category, and description.
- **Budget Categories** – Create custom categories (Income or Expense) with optional monthly budget limits.
- **Visual Dashboard** – Summary cards for total income, expenses, net balance, and transaction count.
- **Budget Progress Bars** – See at a glance how much of each category's budget has been used.
- **Spending Breakdown** – Color-coded visual bar showing how spending is distributed across categories.
- **Recent Transactions** – Quick view of your latest 5 transactions on the dashboard.
- **Responsive Design** – Works beautifully on desktop, tablet, and mobile.

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) or newer
- A terminal / command prompt

### Running the App Locally

1. **Clone the repository:**
   ```bash
   git clone <your-repo-url>
   cd budget4u
   ```

2. **Apply database migrations:**
   ```bash
   dotnet ef database update
   ```

3. **Run the development server:**
   ```bash
   dotnet run
   ```

4. **Open in your browser:**  
   Navigate to `https://localhost:7XXX` (the exact port is shown in the terminal).

5. **Trust the HTTPS development certificate** (first time only):
   ```bash
   dotnet dev-certs https --trust
   ```

---

## 📖 Using the App

### 1. Register an Account
- Click **Register** in the top-right corner or sidebar.
- Enter your email and a strong password.
- Confirm your email if prompted.

### 2. Create Categories
- Go to **Categories** in the sidebar → click **+ New Category**.
- Enter a name (e.g., *Groceries*, *Salary*), choose **Expense** or **Income**, and set a monthly budget limit.
- Click **Save Category**.

> 💡 **Tip:** You must create at least one category before logging a transaction.

### 3. Log a Transaction
- Go to **Transactions** in the sidebar → click **+ New Transaction**.
- Enter the amount, date, category, and an optional description.
- Click **Save Transaction**.

### 4. View Your Dashboard
- The **Dashboard** (home page when logged in) shows:
  - Your total income, expenses, and net balance for the current month.
  - **Budget progress bars** for each expense category.
  - A **spending breakdown** showing percentage distribution.
  - Your **5 most recent transactions**.

### 5. Manage Transactions & Categories
- From **Transactions** or **Categories**, you can delete any entry.
- Note: A category cannot be deleted if it has linked transactions — delete the transactions first.

---

## 🔐 User Authentication

Budget4U uses **ASP.NET Core Identity** for secure user authentication:
- Passwords are hashed using industry-standard algorithms.
- All application data (transactions and categories) is scoped to the logged-in user — no user can see another's data.
- Sessions are managed securely via cookies.

---

## 🛠 Technology Stack

| Layer          | Technology                          |
|----------------|-------------------------------------|
| Framework      | .NET 10, ASP.NET Core, Blazor Web   |
| Authentication | ASP.NET Core Identity               |
| Database       | SQLite (via Entity Framework Core)  |
| UI Styling     | Bootstrap 5 + Custom CSS (dark glassmorphism) |
| Icons          | Bootstrap Icons                     |
| Fonts          | Google Fonts – Inter, Outfit        |
| ORM            | Entity Framework Core 10            |

---

## 📁 Project Structure

```
budget4u/
├── Components/
│   ├── Account/         # Identity registration, login, manage pages
│   ├── Layout/
│   │   ├── MainLayout.razor    # App shell with sidebar
│   │   └── NavMenu.razor       # Sidebar navigation
│   └── Pages/
│       ├── Home.razor           # Dashboard (landing page)
│       ├── Categories/
│       │   ├── Index.razor      # List all categories
│       │   └── Create.razor     # Create new category
│       └── Transactions/
│           ├── Index.razor      # List all transactions
│           └── Create.razor     # Log a new transaction
├── Data/
│   ├── ApplicationDbContext.cs  # EF Core DB context
│   ├── ApplicationUser.cs       # Identity user model
│   └── Models/
│       ├── Category.cs          # Category model
│       └── Transaction.cs       # Transaction model
├── Migrations/          # EF Core database migrations
├── wwwroot/
│   └── app.css          # Global styles & design system
└── Program.cs           # App configuration & service registration
```

---

## ☁️ Deployment

The app is designed to be deployed to any cloud platform that supports .NET 10:

- **Azure App Service** – Native .NET support; pair with Azure SQL for production.
- **Railway / Render** – Simple container-based deployment.
- **Fly.io** – Dockerfile-based deployment with persistent volume for SQLite.

To publish a production build:
```bash
dotnet publish -c Release -o ./publish
```

---

## 👥 Contributing

This project is a BYU-Idaho CSE 325 Group Project. Team members manage tasks via a Trello board and source code via GitHub.

1. Branch from `main` for features.
2. Submit a pull request for review.
3. Tag cards in Trello as **In Progress → In Review → Done**.
