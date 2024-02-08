Task 1
# Get started with ASP.NET Core MVC
2024-01-15 (Sunday) (2110)

-> I had installed Visual Studio 2022, including the ASP.NET and web development workload, Azure development
and proceeded to create a web app.I created the new project name security1 and then I generated a new project named MvcMovie by selecting
the ASP.NET Core Web App template. After configuring the project settings, I launched the 
application without debugging using the Ctrl+F5 shortcut. As a result, the Visual Studio app ran,
opening the default browser.
-> I Selected Yes to the SSL certificate.

Task 2
# Add a controller to an ASP.NET Core MVC app
2024-01-15 (2230)

-> In this section, I added a controller to an ASP.NET Core MVC app. 
-> I added a controller by right-clicking on the Controllers folder, 
selecting "Add" > "Controller," and choosing the MVC Controller - Empty option.
The new controller, named Welcometocybersecurity.cs, was created with two action methods:
Index and Welcome.
-> The code for the Welcometocybersecurity Controller is provided, with comments explaining that every
public method in a controller is callable as an HTTP endpoint.
-> By following the instructions I run the app without the debugger, and it demonstrates how to append
/Welcometocybersecurity to the path in the address bar. The result is shown in the browser window.
-> I changed the Welcome method by including the two parameter and used this string
$"Hello {name}, NumTimes is: {numTimes}" and browse with this URL https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4.
dates/times/tasks/problems/solutions...view it like an hourly/daily diary of work).

Task 3
# Add a view to an ASP.NET Core MVC app
2024-01-15 (2330)
Time duration: 60 Minutes

-> Modify HelloWorldController to Use Razor View Files:
Open WelcometocybersecurityController.cs.
Locate the existing Index method.
Replace it with the provided code for the new Index method that calls the controller's View method.
-> Add a View:
Right-click on the Views folder in Solution Explorer and Choose Add > New Folder and name the folder HelloWorld.
Right-click on the new HelloWorld folder and Choose Add > New Item.
In the Add New Item dialog, select Razor View - Empty and Name it Index.cshtml.
Replace the contents of Views/HelloWorld/Index.cshtml with the provided code.
-> Change Views and Layout Pages:
Modify the layout file (_Layout.cshtml) and change titles and links.
-> Passing Data from the Controller to the View:
Open WelcometocybersecurityController.cs.
Modify the existing Welcome method to add Message and NumTimes to the ViewData dictionary.
Create a new view named Welcome.cshtml in the HelloWorld folder.
Replace the contents of Views/Welcometocybersecity/Welcome.cshtml with the provided code.
Navigate to https://localhost:7116/Welcometocybersecurity/Welcome?name=Parvinder&numTimes=10
Observe the "Hello Parvinder" message displayed Ten times.

Problem during Step 3 (Changing Views and Layout Pages):
When I did changes in the layout file (_Layout.cshtml) don't reflect across pages.
Solution:
Clear the browser cache or force a refresh to see the immediate impact of layout changes on all pages.

Task 4
add a model to an ASP.NET Core MVC app
2024-01-24 (2130)
Time duration: 60 Minutes
=> Add a Data Model Class
In Visual Studio, right-click the Models folder.
I Choose Add > Class and name the file Movie.cs.
=>Add NuGet Packages
=>Scaffold Movie Pages
In the dialog, I choose MVC Controller with views, using Entity Framework.
Set Model class to Movie (MvcMovie.Models), then add a Data Context class, and select SQL Server as the database provider.
=>Initial Migration
I Opened the Package Manager Console (PMC) from Tools > NuGet Package Manager > Package Manager Console.
Run the app.
Navigate to the Movie App link.
I Opened Controllers/MoviesController.cs and observe how dependency injection injects the database context into the controller.
https://localhost:PORT/movies/details?id=1 takes us to the details of particular which is selected by id.
I wasnot encounter any error during scaffolding, when adding a new controller with views. 

Task 5
# Work with a database in an ASP.NET Core MVC app
2024-01-25 (0130)
Time duration: 30 Minutes
=> This section of the MVC Movie App tutorial focuses on integrating a database into your ASP.NET Core MVC application.
It covers essential steps like configuring the database context, seeding initial data, and examining the database
through SQL Server Object Explorer.
=> The `MvcMovieContext` object is responsible for connecting to the database and mapping Movie objects to database records.
- Connection string setup is crucial for database communication. For local development, the connection string is retrieved 
from the `appsettings.json` file.

Task 6
# controller methods and views in ASP.NET Core
2024-01-26 (0230)
=>This section of the MVC Movie App tutorial focuses on enhancing the presentation of the application by improving the movie details
display and implementing controller methods for editing movie information.
=>The `Movie` model is updated to include DataAnnotations for better presentation.
=> The Movies controller is examined, focusing on the Edit action methods responsible for handling HTTP GET and POST requests.
=>Instructions are provided to run the application, navigate to the Movies URL, and test the Edit functionality.

Task 7
# Add search to an ASP.NET Core MVC app
2024-01-26 (0330)
=> This section of the tutorial enhances the MVC Movie App by adding search capabilities to the Index action method.
 Users can now search for movies by genre or name, providing a more interactive and user-friendly experience.
=>The `Index` method in `Controllers/MoviesController.cs` is modified to include a search functionality.
A LINQ query is used to select movies, and the query is modified based on the presence of a search string.
=>This part of the tutorial enhances the MVC Movie App by incorporating search functionality, providing users 
with a powerful and intuitive way to explore the movie database.

Task 8
# Add a new field to an ASP.NET Core MVC app
2024-01-26 (0430)
=> In this section, it focuses on enhancing the MVC Movie App by incorporating a new field,
'Rating', using Entity Framework Code First Migrations. This process involves adding the field to the model,
updating the database schema, and ensuring synchronization between the model and the database.

Task 9
# Add validation to an ASP.NET Core MVC app
2024-01-26 (0530)
=> It demonstrates the seamless integration of validation rules into the UI. 
Both client-side and server-side validation are automatically enforced. 
The user receives immediate feedback through error messages when attempting to submit invalid data.

GitHub
2024-02-01 (1300)
-> I create the account on GitHub respository and I updated it.





 