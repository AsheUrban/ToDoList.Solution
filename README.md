# ToDoList (Identity Branch)

#### By Ashe Urban Grace Kostanich, Liam Campbell, Donovan Weber, and Jonathan Lu

## Branches & Scope

This project includes several branches that build upon each other in complexity — from a simple CRUD MVC app, to database integration, to authentication, and eventually to more advanced relational modeling.

| **Branch** | **What it Demonstrates** | **Notes** |
|-------------|--------------------------|-----------|
| **main** | Base ASP.NET Core MVC app with a one-to-many relationship. | Establishes CRUD and MVC structure; **includes unit testing**. |
| **connectdatabase** | Entity Framework Core connected to MySQL with persistent storage. | Emphasizes EF migrations over manual schema creation; appsettings.json connection config. |
| **identity** | Adds ASP.NET Core Identity for user authentication and authorization. | Builds on `connectdatabase`, extending the EF configuration to include Identity tables, migrations, and secure login flows. |
| **mhm_identity** | Expands upon the `identity` branch with Tags for both Categories and Items, illustrating additional relationships and feature growth. | Demonstrates iterative development beyond Identity integration; includes extended model logic and data relationships. |
| **joinentities_many_to_many** | Prototype branch exploring many-to-many relationships using a join entity. | Conceptual next step after `main`; early prototype not recently updated. |
| **mhm_many_to_many** | Companion branch to `joinentities_many_to_many`. | Parallel experiment reflecting pairing or alternative implementation. |
|

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

_This branch introduces ASP.NET Core Identity to add user registration, login, and authentication._

* _Implements ASP.NET Core Identity authentication and authorization._
* _Adds registration and login functionality._
* _Establishes a foundation for user-based data separation in MVC applications._

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
  *  _Replace `YOUR ID` and `YOUR_PASSWORD` with your MySQL password. You are also welcome to call your database whatever you like, in this case to_do_list is used._
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

Copyright(c) 2023 Ashe Urban, Grace Kostanich, Liam Campbell, Donovan Weber, Jonathan Lu