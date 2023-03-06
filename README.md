# ToDoList.Solution

#### By Ashe Urban

## Technologies Used

* _C#_
* _CSHTML_
* _CSS_
* _mysql Database_
* _dotnet_
* _Markdown_

## Description

ToDoList.Solution refractored to use mysql database configuration and minimal hosting model.

_The rest of the weekend homework will focus on building methods to access and update our database from scratch. This process is labor-intensive and involves a lot of tedious boilerplate code. Later in this section, we'll learn to use a framework called Entity Framework Core that manages our database connection and provides easy-to-use methods to access and update our database. The goal of building database methods from scratch now is to to get an understanding of what is really going on under the hood before we start using Entity Framework Core._


_Link to assignment:_ https://www.learnhowtoprogram.com/c-and-net/database-basics/connecting-a-database-to-an-asp-net-core-app-with-mysqlconnector

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
