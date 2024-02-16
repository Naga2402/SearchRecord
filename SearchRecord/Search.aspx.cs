using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SearchRecord
{
    public partial class Search : System.Web.UI.Page
    {
        SqlConnection s = new SqlConnection("Data Source=VTPL-084;Initial Catalog=SPA;User ID=sa;Password=qipcbsiiu");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            s.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Box where Movie_ID='" + txtid.Text + "'", s);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read()) 
            {
                lblname.Text = dr["Movie_Name"].ToString();
                lbldirector.Text = dr["Movie_Director"].ToString();
                lbldir.Text = dr["Movie_description"].ToString();
            }
            else
            {
                lblMessage.Text = "Record Not Found";
            }
        }
    }
}