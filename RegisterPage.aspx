<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project.NET.RegisterPage" %>
  <!--  
  1. Label: Creates a label for the textbox, instructing the user on what to enter.  
  2. TextBox: A field where users input values.  
  3. CssClass: Applies CSS styles to the label and textbox.  
  4. RequiredFieldValidator: Ensures the field is not left empty.  
  5. ErrorMessage: Displays an error message when the user enters invalid or missing data.  
  6. Calendar: Displays a date picker for selecting a date.  
  7. RegularExpressionValidator: Enforces a specific pattern, allowing only valid inputs.  
  8. Button: Triggers an event when clicked (OnClick event handler).  
-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link  rel="stylesheet" href="StyleSheet.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           

            <asp:Label ID="FnLbl" runat="server" CssClass="form-label" Text="FirstName:"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvFn" runat="server" ControlToValidate="FnTxt" ErrorMessage="Please provide a First Name" ForeColor="red"></asp:RequiredFieldValidator>
            <asp:TextBox ID="FnTxt" runat="server" CssClass="form-input" PlaceHolder="Eg:Ranjini" ></asp:TextBox><br />

            <asp:Label ID="LnLbl" runat="server" CssClass="form-label" Text="LastName:"></asp:Label>
            <asp:TextBox ID="LnTxt" runat="server" CssClass="form-input" PlaceHolder="Eg:Gopal"></asp:TextBox><br />

            <asp:Label ID="DobLbl" runat="server"  CssClass="form-label calendar-custom" Text="DOB:"></asp:Label>
            <asp:Calendar ID="DobCal" runat="server" CssClass="form-input" Font-Size="Small" Width="5px" Height="5px"  OnSelectionChanged="DobCal_SelectionChanged"></asp:Calendar><br />

            <asp:Label ID="EmailLbl" runat="server" CssClass="form-label" Text="Email:"></asp:Label>
            <asp:TextBox ID="EmailTxt" runat="server" CssClass="form-inputl" PlaceHolder="123@gmail.com"></asp:TextBox><br />
            <asp:RegularExpressionValidator ID="rgevEmail" runat="server" ControlToValidate="EmailTxt" ValidationExpression="^[A-Za-z]\S*$" ErrorMessage="Invalid Eamil Format" ForeColor="red"></asp:RegularExpressionValidator>

            <asp:Label ID="PhnoLbl" runat="server"  CssClass="form-label" Text="PhoneNumber:"></asp:Label>
            <asp:TextBox ID="PhnoTxt" runat="server" CssClass="form-input" PlaceHolder="1234567890"></asp:TextBox><br />

            <asp:Label ID="AddLbl" runat="server" CssClass="form-label" Text="Address"></asp:Label>
            <asp:TextBox ID="AddTxt" runat="server" CssClass="form-input" PlaceHolder="Eg:42/c,AnnaColony,Hosur"></asp:TextBox><br />

            <asp:Label ID="HiredLbl" runat="server" CssClass="form-label calendar-custom"  Text="HireDate:"></asp:Label>
            <asp:Calendar ID="HiredCal" runat="server" CssClass="form-input" Font-Size="Small" Width="5px" Height="5px" OnSelectionChanged="HiredCal_SelectionChanged"></asp:Calendar><br />

           <asp:Label ID="JobLbl" runat="server" CssClass="form-label" Text="JobTitle:"></asp:Label>
           <asp:TextBox ID="JoinedTxt" runat="server" CssClass="form-input" PlaceHolder="Eg:ProductEngineer"></asp:TextBox><br />

           <asp:Label ID="DepLbl" runat="server" CssClass="form-label" Text="DepartmentID:"></asp:Label>
           <asp:TextBox ID="DepTxt" runat="server"  CssClass="form-input" PlaceHolder="Eg:1"></asp:TextBox><br />

           <asp:Label ID="SalaryLbl" runat="server"   CssClass="form-label" Text="Salary:"></asp:Label>
           <asp:TextBox ID="SalaryTxt" runat="server"  CssClass="form-input" PlaceHolder="Eg:20000"></asp:TextBox><br />
           
           <asp:Label ID="ManagerLbl" runat="server" CssClass="form-label" Text="ManagerID:"></asp:Label>
           <asp:TextBox ID="ManagerTxt" runat="server" CssClass="form-input" PlaceHolder="Eg:1"></asp:TextBox><br />

           <asp:Button  ID="AddBtn" runat="server" PlaceHolder="ADD" OnClick="Add_Click" Text="ADD"/>
            
        </div>
    </form>
</body>
</html>
