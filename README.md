# ToDoList.Solution | mhm_many_to_many

#### By Ashe Urban

## Technologies Used on mhm_many_to_many branch

* _C#_
* _CSHTML_
* _CSS_
* _EF Core_
* _mysql Database_
* _dotnet_
* _Markdown_

## Description

ToDoList.Solution refractored to use ef core to set up a many to many relationship between databases and a  minimal hosting model.

_So far, we've manually created and updated our database using MySQL Workbench. However, this approach isn't very effective for a large production application where many developers are collaborating together. Let's say we have many different teams that are working on different features in an application and we're working on a team that makes changes to the database. How can we convey the changes to other teams working on the application? We'd need to give everyone exact instructions on the changes we made, which could get tedious fast, especially if we're making a lot of changes._

_It's very common for a database to change over time. In fact, in large projects, there may be hundreds or even thousands of changes to a database over the course of a project. It would be very tedious to make all those changes in MySQL Workbench or another database tool._

_Fortunately, EF Core provides a solution for this. We can use migrations to create a new database or update an existing database based on our code. Migrations are a common feature of many frameworks, including Rails, which uses Active Record. So in this lesson, we're going to learn about database migrations, how to create them, and install the tools necessary for the job. The instructions in this lesson can be applied to any other project you create._


_Link to assignment:_ https://www.learnhowtoprogram.com/c-and-net/many-to-many-relationships/code-first-development-and-migrations

## Setup/Installation Requirements

_Because this branch uses migrations, you do not need to prebuild a database. Simply configure appsettings to use your own naming conventions._

* _Clone or download responsitory to your local._
* _Cd into top level project directory and run dotnet restore, dotnet build to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[schema-name];uid=root;pwd=[password];"
  }
}
* _Use dotnet watch run to run web application continuously while editing and dotnet run to launch the current itteration without the ability to make live changes._

* _dotnet ef migrations add DatabaseUpdateName to scaffold database and each time classes or properties are modified._
* _dotnet ef database update to push changes to database after each migration._

_NOTE:_ [password] and [schema-name] should be replaced by your information. Do not include square brackets in final configuration.

## Known Bugs -- IMPORTANT --

* _No known bugs._

## License

* MIT

## Contact Information

_Please contact me with any questions or contribuitions, ashe@goldentongue.com_

Copyright(c) _2022, updated February 2023, Ashe Urban_
