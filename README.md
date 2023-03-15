# ToDoList.Solution | identity

#### By Ashe Urban & Co.

## Technologies Used on identity branch

* _C#_
* _CSHTML_
* _CSS_
* _EF Core_
* _mysql Database_
* _dotnet_
* _Markdown_

## Description

ToDoList.Solution refractored to use ef core to set up a many to many relationship between databases and using MVC and not the new minimal hosting model. To run this project using mhm please checkout the mhm_many_to_many branch.

_In this lesson, we'll add Identity to our To Do List application. This will involve creating a new class to manage user accounts with Identity, updating our Program.cs to include Identity in our project, and configuring Identity to work with Entity Framework Core. You can follow this same process to add Identity to any of your projects._


_Link to assignment:_ https://www.learnhowtoprogram.com/c-and-net/authentication-with-identity/identity-setup-and-configuration

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
