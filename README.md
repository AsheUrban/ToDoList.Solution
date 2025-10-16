
# ToDoList (main)

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
* _CSHTML_
* _CSS_
* _Entity Framework Core_
* _MySQL (SQL Database)_
* _dotnet_
* _LINQ_
* _Markdown_

## Description

_ToDoList is an MVC app that groups tasks (Items) under Categories. Each Category can have many Items (one-to-many). Users can add Categories, add Items to a Category, and view details._

* _List all Categories._
* _View Category details and its Items._
* _Add new Categories._
* _Add new Items to a Category._
* _Delete Items; delete Categories (Items are removed via cascade)._

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
  _NOTE: Replace `YOUR ID` and `YOUR_PASSWORD` with your MySQL credentials. Use the exact schema name `to_do_list` (all lowercase) as written, if you copy and paste this into your project, to ensure it matches what you will use to scaffold your database in MySQL Workbench. You can call your database whatever you like, as long as the connection string and the database name in MySQL match._

* _Start your local MySQL server and open MySQL Workbench._

### Build the Database Schema in MySQL Workbench (GUI)

* _Create Schema_
  * _Database ➜ Create Schema… ➜ Name: `to_do_list` ➜ Apply ➜ Apply ➜ Finish._

* _Create `categories` table_
  * _Right-click `to_do_list` ➜ Tables ➜ Create Table… ➜ Name: `categories`_
  * _Columns tab:_
    * _`CategoryId` → INT, check PK, NN, AI_
    * _`Name` → VARCHAR(255), check NN_
  * _Apply ➜ Apply ➜ Finish._

* _Create `items` table_
  * _Right-click `to_do_list` ➜ Tables ➜ Create Table… ➜ Name: `items`_
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
  * _Expand `to_do_list ➜ Tables` and confirm `categories` and `items` exist._

### Optional: SQL Script Alternative (run in a Workbench SQL tab)

```
CREATE DATABASE IF NOT EXISTS to_do_list;
USE to_do_list;

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

## Testing

The test project uses its own configuration file and expects `ConnectionStrings:TestConnection`.


* Create `ToDoList.Tests/appsettings.json` with:

```
    {
      "ConnectionStrings": {
        "TestConnection": "Server=localhost;Port=3306;Database=to_do_list;User Id=[YOUR_ID];Password=[YOUR_PASSWORD];"
      }
    }
```
* Run tests
From the repository root or from the ToDoList.Tests directory:

```
    dotnet test
```
## Known Bugs

* _No known bugs._

## License

* _Educational Use Only — This repository is provided for classroom and personal learning purposes. It is not licensed for public deployment, redistribution, or commercial use. No warranty or support is provided._


## 

Copyright(c) 2023 Ashe Urban, Grace Kostanich, Liam Campbell, Donovan Weber, Jonathan Lu 

