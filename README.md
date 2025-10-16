# ToDoList (mhm_many_to_many)

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

_This branch refines the project’s many-to-many relationship design between Items, Categories, and Tags. It improves upon previous implementations by introducing clearer relational structure, enhanced controller logic, and simplified data handling for complex associations._

* _Refines many-to-many relationships between Items, Categories, and Tags._
* _Streamlines join entity management through improved EF Core mappings._
* _Enhances controller logic for creating and managing relationships._
* _Updates views for more intuitive association handling._
* _Demonstrates a clean, maintainable approach to many-to-many modeling._

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
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=YOUR_ID;pwd=YOUR_PASSWORD;"
    }
  }
  ```
_Notes:_
*  _Replace `YOUR_ID` and `YOUR_PASSWORD` with your MySQL credentials. You are also welcome to call your database whatever you like, in this case to_do_list is used._

* _Ensure your MySQL user has permissions to let EF create the database and all foreign keys._

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

## Troubleshooting

* _List contexts and drop database (dev reset):_

  ```
  dotnet ef dbcontext list
  dotnet ef database drop -f --context ToDoListContext
  dotnet ef database update --context ToDoListContext
  ```

## Known Bugs

* _No known bugs._

## License

* _Educational Use Only — This repository is provided for classroom and personal learning purposes. It is not licensed for public deployment, redistribution, or commercial use. No warranty or support is provided._

## 

Copyright(c) 2023 Ashe Urban, Grace Kostanich, Liam Campbell, Donovan Weber, Jonathan Lu


