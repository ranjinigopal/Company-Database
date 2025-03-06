using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Project.NET
{
    public partial class CompanyDatabase : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["CompanyDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            con.Open();
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            GridView1.DataBind();
                        }
                    }
                }
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
        protected void BtnRegisterPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

       
    }
}
