using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Project.NET
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["CompanyDB"].ConnectionString;

        protected void Add_Click(object sender, EventArgs e) {
            try
            {
                using (SqlConnection con1 = new SqlConnection(constr))
                {
                    con1.Open();

                    string InsertQuery = "INSERT INTO Employees (FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address, HireDate, JobTitle, DepartmentID, Salary, ManagerID)VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Address, @HireDate, @JobTitle, @DepartmentID, @Salary, @ManagerID)";

                    using (SqlCommand cmd1 = new SqlCommand(InsertQuery, con1))
                    {
                        cmd1.Parameters.AddWithValue("@FirstName", FnTxt.Text);
                        cmd1.Parameters.AddWithValue("@LastName", LnTxt.Text);
                        cmd1.Parameters.AddWithValue("@DateOfBirth", DobCal.SelectedDate);
                        cmd1.Parameters.AddWithValue("@Email", EmailTxt.Text);
                        cmd1.Parameters.AddWithValue("@PhoneNumber", PhnoTxt.Text);
                        cmd1.Parameters.AddWithValue("@Address", AddTxt.Text);
                        cmd1.Parameters.AddWithValue("@HireDate", HiredCal.SelectedDate);
                        cmd1.Parameters.AddWithValue("@JobTitle", JoinedTxt.Text);
                        cmd1.Parameters.AddWithValue("@DepartmentID", DepTxt.Text);
                        cmd1.Parameters.AddWithValue("@Salary", Convert.ToDecimal(SalaryTxt.Text));
                        cmd1.Parameters.AddWithValue("@ManagerID", ManagerTxt.Text);

                        cmd1.ExecuteNonQuery();
                        Response.Redirect("CompanyDatabase.aspx");
                    }
                }



                FnTxt.Text = "";
                LnTxt.Text = "";
                DobCal.SelectedDate = DateTime.MinValue;
                EmailTxt.Text = "";
                PhnoTxt.Text = "";
                AddTxt.Text = "";
                HiredCal.SelectedDate = DateTime.MinValue;
                JoinedTxt.Text = "";
                DepTxt.Text = "";
                SalaryTxt.Text = "";
                ManagerTxt.Text = "";

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid data format: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null reference encountered: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        

        
        protected void HiredCal_SelectionChanged(object sender, EventArgs e)
        {
    

            DateTime selectedDate = HiredCal.SelectedDate;
            Response.Write(selectedDate.ToString("yyyy-MM-dd"));

        }

        protected void DobCal_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate1 = DobCal.SelectedDate;
            Response.Write(selectedDate1.ToString("yyyy-MM-dd"));
        }

      
    }
}
