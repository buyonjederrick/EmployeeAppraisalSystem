***Employee Appraisal System***

The Employee Appraisal System is a web application built using C#, DotNet Core, and following the Model-View-Controller (MVC) architectural pattern. This application is designed to streamline the employee appraisal process within an organization. This comprehensive README provides detailed instructions for setting up and using the application.

***Technologies Utilized***

**C#:** The programming language used to develop the application.
**DotNet Core:** A versatile and cross-platform framework for building applications.
**MVC (Model-View-Controller):** A software architectural pattern that separates the application into three interconnected components - Model, View, and Controller.

***Prerequisites***

Before you embark on setting up the Employee Appraisal System, make sure you have the following prerequisites in place on your development machine:

***.NET Core SDK:** Download and install the .NET Core SDK (recommended version: 5.0 or higher).
***Development Environment:*** You can use Visual Studio.
***SQL Server:*** To use the Microsoft.EntityFrameworkCore.SqlServer package, ensure you have SQL Server installed.

***NuGet Packages**

The project relies on several NuGet packages to provide essential functionalities. These packages include:

***Microsoft.EntityFrameworkCore:*** This package is the core of Entity Framework Core, providing a powerful object-relational mapping (ORM) framework.
***Microsoft.EntityFrameworkCore.SqlServer:*** A database provider for Entity Framework Core, specifically tailored for SQL Server databases.
***Microsoft.EntityFrameworkCore.Tools:*** This package offers indispensable tools for Entity Framework Core, including database migrations and updates.

***Initial Setup***

Follow these steps to set up the Employee Appraisal System:

**Clone the Repository:** Begin by cloning the project repository to your local machine. Navigate to your project directory in the command line and use the following commands:

git clone https://github.com/your-username/employee-appraisal-system.git
cd employee-appraisal-system

***Edit the Connection String:*** In the **appsettings.json file**, update the connection string to point to your SQL Server instance. This is where the application's data will be stored. Modify the "DefaultConnection" string as follows:

"ConnectionStrings": {
    "DefaultConnection": "Server=YourServer;Database=AppraisalManagement;Trusted_Connection=True;TrustServerCertificate=True"
}

***Database Migration:*** Utilize the NuGet Package Manager Console to apply the database migrations and create the necessary database tables. Execute the following command:

update-database

***Build the Project:** Once your database is set up, it's time to build the project.

**Launch the Application:** With the project built, you're ready to run the application.