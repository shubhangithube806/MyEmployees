using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MyEmployees
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string con = "Data Source=SHUBVIN\\SQLEXPRESS;Initial Catalog=EmployeDB;User Id=shubh;Password=shubh@123";

            SqlConnection db = new SqlConnection(con);

            string insert = "insert into Employe (FirstName,LastName,Contact,EmailId) values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtContact.Text + "','" + txtEmail.Text + "')";
            
            SqlCommand cmd = new SqlCommand(insert, db);

            db.Open();

            int m = cmd.ExecuteNonQuery();

            db.Close();


        }
    }
}