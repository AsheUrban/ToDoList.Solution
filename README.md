# ToDoList: Categories & Items

#### By Ashe Urban Grace Kostanich, Liam Campbell, Donovan Weber, and Jonathan Lu

## Branches & Scope

This project includes several branches that build upon each other in complexity — from a simple CRUD MVC app, to database integration, to authentication, and eventually to more advanced relational modeling.

| **Branch** | **What it Demonstrates** | **Notes** |
|-------------|--------------------------|-----------|
| **main** | Basic ASP.NET Core MVC app in C# with a one-to-many relationship between Categories and Items using EF Core and MySQL. | Establishes foundational CRUD functionality and MVC structure. |
| **connectdatabase** | Integration of Entity Framework Core with MySQL, configuring database connectivity and schema management. | *Emphasizes EF migrations over manual schema creation.* Demonstrates database setup, schema generation, and CRUD integration testing. |
| **identity** | Adds ASP.NET Core **Identity** for user authentication and authorization. | Builds on `connectdatabase`, extending the EF configuration to include Identity tables, migrations, and secure login flows. |
| **mhm_identity** | Expands upon the Identity branch with **Tags** for both Categories and Items, illustrating additional relationships and feature growth. | Demonstrates iterative development beyond Identity integration; includes extended model logic and data relationships. |
| **joinentities_many_to_many** | Prototype branch exploring **many-to-many** relationships using a join entity. | Conceptual next step after `main`; early prototype not recently updated. |
| **mhm_many_to_many** | Companion branch to `joinentities_many_to_many`. | Parallel experiment reflecting pairing or alternative implementation. |

## Technologies Used

* _C#_
* _.NET 5 (ASP.NET Core MVC)_
* _CSHTML_
* _CSS_
* _Entity Framework Core_
* _MySQL (SQL Database)_
* _dotnet_
* _LINQ_
* _Markdown_

## Description

_This branch extends the base ToDoList project by connecting it to a MySQL database using Entity Framework Core. 
It replaces in-memory data with persistent storage and introduces migrations for managing the database schema._

* _Implements ToDoListContext for EF Core integration._
* _Configures connection strings in appsettings.json._
* _Enables schema creation through EF migrations or provided .sql files._
* _Stores Categories and Items persistently in MySQL._
* _Demonstrates how to build and run a connected .NET MVC app._

## Setup/Installation Requirements

* _Clone or download the repository to your local machine._
* _Open a terminal and `cd` into the `ToDoList` project directory, then run:_
  ```
  dotnet restore
  ```
* _Create `appsettings.json` in the `ToDoList` project folder with the following configuration:_
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=[YOUR ID];pwd=[YOUR_PASSWORD];"
    }
  }
  ```
  _NOTE: Replace `YOUR ID` and `YOUR_PASSWORD` with your MySQL password. You are also welcome to call your database whatever you like, in this case to_do_list is used._

* _Start your local MySQL server and open MySQL Workbench._


### Run the Web Application

```
dotnet run
```
_or_
```
dotnet watch run
```

_Navigate to the localhost URL shown in the console and explore the project._

## Known Bugs

* _Categories cannot be edited at this time as there is no view created._

## License

* _Educational Use Only — This repository is provided for classroom and personal learning purposes. It is not licensed for public deployment, redistribution, or commercial use. No warranty or support is provided._


## 

Copyright(c) 2023 Ashe Urban, Grace Kostanich, Liam Campbell, Donovan Weber, Jonathan Lu 
