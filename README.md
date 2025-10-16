# ToDoList (identity)

#### By Ashe Urban Grace Kostanich, Liam Campbell, Donovan Weber, and Jonathan Lu

## Branches & Scope

This project includes several branches that build upon each other in complexity — from a simple CRUD MVC app, to database integration, to authentication, and eventually to more advanced relational modeling.

| **Branch** | **What it Demonstrates** | **Notes** |
|-------------|--------------------------|-----------|
| **main** | Base ASP.NET Core MVC app with a one-to-many relationship. | Establishes CRUD and MVC structure; includes unit testing. |
| **connectdatabase** | Entity Framework Core connected to MySQL with persistent storage. | Emphasizes EF migrations over manual schema creation; appsettings.json connection config. |
| **identity** | Adds ASP.NET Core Identity for user authentication and authorization. | Builds on `connectdatabase`, extending the EF configuration to include Identity tables, migrations, and secure login flows. |
| **mhm_identity** | Expands upon the `identity` branch with Tags for both Categories and Items, illustrating additional relationships and feature growth. | Demonstrates iterative development beyond Identity integration; includes extended model logic and data relationships. |
| **joinentities_many_to_many** | Demonstrates a many-to-many relationship using an explicit join entity between core models. | Serves as a prototype exploring relational mapping without Identity integration; focuses on linking and unlinking records through the join table. |
| **mhm_many_to_many** | Expands upon the many-to-many relationship with an alternative implementation. | Provides a refined or parallel approach to the join-entity pattern; does not include Identity features. |
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

_This branch expands on the many-to-many version of ToDoList by introducing a Tag entity and related updates. Tags add another layer of organization to the existing data model. The branch also includes small adjustments to routing, views, and data handling to support the new entity and improve project consistency._

* _Connects Tags with Items and Categories in a multi-entity relationship._
* _Updates context and migrations to support expanded Tag relationships._
* _Refines UI elements to display and manage Tags alongside other entities._
* _Demonstrates advanced relational modeling and data interaction in EF Core._
* _Represents the most feature-complete version of ToDoList._

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
      "DefaultConnection": "Server=localhost;Port=3306;Database=to_do_list;User Id=YOUR_ID;Password=YOUR_PASSWORD;"
    }
  }
  ```
_Notes:_
*  _Replace `YOUR_ID` and `YOUR_PASSWORD` with your MySQL credentials. You are also welcome to call your database whatever you like, in this case to_do_list is used._

* _Ensure your MySQL user has permissions to let EF create the database and all foreign keys._

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
  _Navigate to the shown localhost URL, register a new account, and/or create Categories, Items, and Tags. Actions are not currently limited to registered users._

## Project Notes (Identity)

* _This version uses ASP.NET Core Identity. The following tables are created automatically: `AspNetUsers`, `AspNetRoles`, `AspNetUserClaims`, `AspNetUserRoles`, `AspNetUserLogins`, `AspNetUserTokens`, `AspNetRoleClaims`._

* _Identity requires `REFERENCES` privileges for foreign keys. If you see “REFERENCES command denied”, ensure your MySQL user has `REFERENCES` (see example SQL on main branch)._

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

