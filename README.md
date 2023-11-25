TEST TASK TO COMPLETE

Share a link to a new GitHub repository with recruiting@logicimtech.com. 
The GitHub repository name is: platform_demo_012. 
The GitHub repository will contain a single .NET solution and a readme.md file. 
NET Solution: The solution name is PlatformDemo. It will contain 2 projects: a NET 6 Class library and an ASP.NET Core 6 web app.
NET 6 Class library

One Entity Framework DbContext using a SQL Server provider, including a set of Customers and a set of Orders 
Customer class (Customer Id, Name, Phone number) 
Order class (Order Id, Order Number, Amount) 
ASP.NET Core 6 web app

Reference the class library and build a page that shows the list of customers along with their phone number and the total amount of their orders. There must be a single line for each customer, even if the customer has no orders
Provide sample data (10-15 customers, 0-5 orders per customer)

Notes:
To setup the database:
steps
#1: In the solution go to Data Access project and set it as the start up project for setting the ef core db context 
#2: Open the Nuget Package manager console and run the command "Update-Database" 
#3: In the solution go to PlatformDemo project and set it as the start up project.

And now you can run the Solution and test it
