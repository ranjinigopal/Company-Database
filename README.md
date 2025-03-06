
**Company Database & Employee Registration Application**

-This project is a basic ASP.NET web application built using C# that manages employee data for a company.
-It consists of two main pages:

**Company Database Page**: Displays a list of employees from a SQL Server database using a GridView.
**Registration Page**: Provides a form to register new employees, inserting their information into the database.

  **Features**

**Display Employee Records**  
  -The Company Database page connects to a SQL Server database (using the connection string named `CompanyDB`), retrieves all employee records, and displays them in a GridView control.
  -It also offers a button that redirects users to the registration page.

**Employee Registration**  
  The Registration page lets users add a new employee by filling out a form with fields such as:
  - First Name
  - Last Name
  - Date of Birth
  - Email
  - Phone Number
  - Address
  - Hire Date
  - Job Title
  - Department ID
  - Salary
  - Manager ID

  Once the form is submitted, the application inserts the provided data into the `Employees` table and then redirects the user back to the Company Database page.

**Error Handling**  
  Both pages include error handling to catch common issues such as SQL errors, invalid data formats, or null references. Errors are logged to the console.

 **Project Files**

**CompanyDatabase.aspx.cs**  
  Contains the code-behind for the Company Database page. 
  It retrieves employee data from the database and binds it to a GridView control. 
  It also handles navigation to the registration page.  


**CompanyDatabase.aspx.designer.cs**  
  An auto-generated file that defines the server controls (like the form, GridView, SqlDataSource, and button) used on the Company Database page.  

**RegisterPage.aspx.cs**  
  Contains the code-behind for the Registration page. This file handles form submissions, inserting new employee records into the database, and includes event handlers for calendar date selections.  

**RegisterPage.aspx.designer.cs**  
  An auto-generated file that defines the server controls used in the registration page (such as text boxes, labels, calendars, and the submit button).  
 

**Setup & Configuration**

1. **Development Environment**:  
   -Microsoft Visual Studio (or a similar IDE for ASP.NET development).
   -ASP.NET Framework.
   -SQL Server (local or remote).

2. **Database Configuration**:  
   - Define the connection string named `CompanyDB` in your Web.config file to point to your SQL Server database.
   - Ensure your database contains an `Employees` table with columns corresponding to the following fields:
     - `FirstName`
     - `LastName`
     - `DateOfBirth`
     - `Email`
     - `PhoneNumber`
     - `Address`
     - `HireDate`
     - `JobTitle`
     - `DepartmentID`
     - `Salary`
     - `ManagerID`

3. **Running the Application**:  
   - Build and run the project in Visual Studio.
   - Navigate to `CompanyDatabase.aspx` to view employee records.
   - Use the "Register" button on the Company Database page to go to the Registration page (`RegisterPage.aspx`), where you can add new employee data.

   **Error Handling**

The application includes robust error handling to manage:
- **SQL Exceptions**: Issues with the database connection or SQL query execution.
- **Format Exceptions**: Errors due to invalid data formats.
- **Null Reference Exceptions**: Occur when expected objects are not initialized.
- **General Exceptions**: Catch-all for any other unexpected errors.

Error messages are output to the console, making debugging easier during development.

