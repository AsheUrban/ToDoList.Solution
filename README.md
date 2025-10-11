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
      "DefaultConnection": "Server=localhost;Port=3306;database=todolist;uid=[YOUR ID];pwd=[YOUR_PASSWORD];"
    }
  }
  ```
  _NOTE: Replace `YOUR ID` and `YOUR_PASSWORD` with your MySQL password. Use the exact schema name `todolist` (all lowercase)._

* _Start your local MySQL server and open MySQL Workbench._

### Build the Database Schema in MySQL Workbench (GUI)

* _Create Schema_
  * _Database ➜ Create Schema… ➜ Name: `todolist` ➜ Apply ➜ Apply ➜ Finish._

* _Create `categories` table_
  * _Right-click `todolist` ➜ Tables ➜ Create Table… ➜ Name: `categories`_
  * _Columns tab:_
    * _`CategoryId` → INT, check PK, NN, AI_
    * _`Name` → VARCHAR(255), check NN_
  * _Apply ➜ Apply ➜ Finish._

* _Create `items` table_
  * _Right-click `todolist` ➜ Tables ➜ Create Table… ➜ Name: `items`_
  * _Columns tab:_
    * _`ItemId` → INT, check PK, NN, AI_
    * _`Description` → VARCHAR(255), check NN_
    * _`CategoryId` → INT (leave NULL if Items may exist without a Category; check NN if every Item must belong to one)_
  * _Foreign Keys tab:_
    * _Add Foreign Key ➜ Name: `fk_items_categories`_
    * _Referenced Table: `categories`_
    * _Column Mapping: `CategoryId` (child) → `CategoryId` (parent)_
    * _On Delete: CASCADE; On Update: NO ACTION_
  * _Apply ➜ Apply ➜ Finish._

* _Verify_
  * _Expand `todolist ➜ Tables` and confirm `categories` and `items` exist._

### Optional: SQL Script Alternative (run in a Workbench SQL tab)

```
CREATE DATABASE IF NOT EXISTS todolist;
USE todolist;

CREATE TABLE IF NOT EXISTS categories (
  CategoryId INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS items (
  ItemId INT AUTO_INCREMENT PRIMARY KEY,
  Description VARCHAR(255) NOT NULL,
  CategoryId INT NULL,
  INDEX idx_items_category (CategoryId),
  CONSTRAINT fk_items_categories
    FOREIGN KEY (CategoryId)
    REFERENCES categories (CategoryId)
    ON DELETE CASCADE
    ON UPDATE NO ACTION
);
```

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

Copyright(c) 2023 Ashe Urban
