# ToDoList.Solution | connectdatabase 

#### By Ashe Urban

## Technologies Used on connectdatabase branch

* _C#_
* _CSHTML_
* _CSS_
* _EF Core_
* _mysql Database_
* _dotnet_
* _Markdown_

## Description

ToDoList.Solution refractored to use mysql database configuration and minimal hosting model.

_For this walkthrough, we'll use our To Do List app as an example, and we'll start where we left off with our To Do List app: using MySqlConnector to communicate with a MySQL database. That means this walkthrough will include instructions on how to remove MySqlConnector and how to update the custom methods we created over the weekend homework to communicate with our MySQL database. As always, you are welcome to code a long with these lessons, or just read through them. We'll provide links to an example repo as needed and at the very end of the walkthrough._


_Link to assignment:_ https://www.learnhowtoprogram.com/c-and-net/database-basics/configuration-for-entity-framework-core

## Setup/Installation Requirements

* _Clone or download responsitory to your local._
* _Cd into Factory and run dotnet restore, dotnet build to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[schema-name];uid=root;pwd=[password];"
  }
}
* _Then use dotnet watch run to run web application._

_NOTE:_ [password] and [schema-name] should be replaced by your information. Do not include square brackets in final configuration.

## Known Bugs -- IMPORTANT --

* _No known bugs._

## License

* MIT

## Contact Information

_Please contact me with any questions or contribuitions, ashe@goldentongue.com_

Copyright(c) _2022, updated February 2023, Ashe Urban_
