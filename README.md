# ToDoList (Identity Edition)

#### A website that lets users organize to-do Items inside Categories, with authentication via ASP.NET Core Identity.

#### By Ashe Urban

## Technologies Used

* _C#_
* _.NET 5 (ASP.NET Core MVC)_
* _ASP.NET Core Identity (Authentication/Authorization)_
* _CSHTML_
* _CSS_
* _Entity Framework Core_
* _MySQL (SQL Database)_
* _dotnet CLI_
* _LINQ_
* _Markdown_

## Description

_ToDoList (Identity Edition) is an MVC app that groups tasks (Items) under Categories (one-to-many). This version includes user authentication powered by ASP.NET Core Identity. On first run, EF Core migrations create both the application tables (`categories`, `items`) and the Identity tables (`AspNetUsers`, `AspNetRoles`, etc.). No manual table creation in MySQL Workbench is required; only ensure your MySQL user has the necessary privileges so migrations can create the database and foreign keys._

* _Register, Login, Logout (Identity)._
* _List all Categories._
* _View Category details (with Items)._
* _Add new Categories._
* _Add new Items to a Category._
* _Delete Items; delete Categories (Items removed via cascade)._

## Setup/Installation Requirements

* _Clone or download the repository to your local machine._
* _Open a terminal and `cd` into the `ToDoList` project directory, then restore:_
  ```
  dotnet restore
  ```
* _Create `appsettings.json` in the `ToDoList` project folder with a connection string for MySQL (you may also use User Secrets):_
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;Database=to_do_list;User Id=home;Password=YOUR_PASSWORD;"
    }
  }
  ```
  _Notes:_
  * _`Database=to_do_list` is created automatically by EF migrations on first run._
  * _Replace `YOUR_PASSWORD` with your local MySQL user’s password._

* _Ensure your MySQL user has permissions to let EF create the database and all foreign keys. 

* _Create the database and tables automatically via migrations:_
  ```
  dotnet ef migrations add Initial
  ```
  ```
  dotnet ef database update
  ```
  _These two commands apply the `Initial` migration and scaffolds Identity tables plus app tables into `to_do_list`._

* _Run the web application:_
  ```
  dotnet run
  ```
  _or_
  ```
  dotnet watch run
  ```
  _Navigate to the shown localhost URL, register a new account, then create Categories and Items._

## Project Notes (Identity)

* _This version uses ASP.NET Core Identity. The following tables are created automatically: `AspNetUsers`, `AspNetRoles`, `AspNetUserClaims`, `AspNetUserRoles`, `AspNetUserLogins`, `AspNetUserTokens`, `AspNetRoleClaims`._
* _Identity requires `REFERENCES` privileges for foreign keys. If you see “REFERENCES command denied”, ensure your MySQL user has `REFERENCES` (see example SQL above)._
* _Design-time (migrations) and runtime both read `ConnectionStrings:DefaultConnection`, so keep that value consistent across `appsettings.json`, `appsettings.Development.json`, or User Secrets._

## Troubleshooting

* _List contexts and drop database (dev reset):_
  ```
  dotnet ef dbcontext list
  dotnet ef database drop -f --context ToDoListContext
  dotnet ef database update --context ToDoListContext
  ```

## Known Bugs

* _Options for editing and deleting categories have been obscured until views have been created for them._

## License

* _Educational Use Only — This repository is provided for classroom and personal learning purposes. It is not licensed for public deployment, redistribution, or commercial use. No warranty or support is provided._

##

Copyright(c) 2025 Ashe Urban

