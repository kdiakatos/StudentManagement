## A. What the application does 

This application allows its users to perform the following: 

 1. Create/Edit/Details/View All Students
 2. Create/Edit/Details/View All Semesters
 3. Create/Edit/Details/View All Discipline
 


## B. Architecture Solution 

The architectural design for the api follows the 3-Layer architecture. A short description about the three layers follows: 

  ### 1. Data Access Layer
	  It is a class library project that implements this layer, which is responsible for storing and 
      retrieving data to a persistent database.  
  ### 2. Business Layer
      It is a class library project that implements this layer, which operates as the “middleman” 
     between the data access layer and the presentation layer. 
     It also contains all the business logic of the application (e.g. mappings, calculations etc.).
  ### 3. Web api  
      It is the project that contains all the endpoints of the web service 

   Moreover, there is a client, which is an MVC web application that manages the data from the API.

## C. Technologies/Frameworks used 

The solution is built using the following technologies/frameworks: 

C# .NET (Core) 5 API / Web Application MVC

SQL Server

EF Core

Automapper

HTML/CSS/JQuery/Razor Views

## D. Project Setup 

To set up the database, you should do the following: 

In the file appsettings.json (StudentManagement.Api project), fill in your connection string to the SQL Server instance of your desire 

Set as start-up project the StudentManagement.Web 

In Visual Studio 2019, go Tools -> NuGet Package Manager -> Package Manager 

Set Default Project, SalesManagement.DataLayer and type the following command:  

**update-database**

Furthermore, in order to run the application, you should set as starting project the api and the client 
(right click solution -> properties -> multiple startup projects select the above mentioned projects)
