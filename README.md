# ToDoList: Categories & Items

#### By Ashe Urban & Co.

_This project contains several branches, each with their own README.md and set up instructions:_
* main
* connectdatabase
* Identity
* joinentities_many_to_many
* mhm_many_to_many


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

### Optional: Create/Grant MySQL User (fix “Access denied”)

```
CREATE USER IF NOT EXISTS 'home'@'localhost' IDENTIFIED BY 'YOUR_PASSWORD';
CREATE USER IF NOT EXISTS 'home'@'127.0.0.1' IDENTIFIED BY 'YOUR_PASSWORD';
CREATE USER IF NOT EXISTS 'home'@'::1' IDENTIFIED BY 'YOUR_PASSWORD';

GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, ALTER, INDEX
ON `todolist`.*
TO 'home'@'localhost', 'home'@'127.0.0.1', 'home'@'::1';

FLUSH PRIVILEGES;
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

* _No known bugs._

## License

* _Educational Use Only — This repository is provided for classroom and personal learning purposes. It is not licensed for public deployment, redistribution, or commercial use. No warranty or support is provided._


## 

Copyright(c) 2023 Ashe Urban
