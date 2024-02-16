using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SearchRecord
{
    public partial class SearchR : System.Web.UI.Page
    {
        SqlConnection s = new SqlConnection("Data Source=VTPL-084;Initial Catalog=SPA;User ID=sa;Password=qipcbsiiu");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Box", s);
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable(); 
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}