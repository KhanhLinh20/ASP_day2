using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day22
{
    public partial class Product : System.Web.UI.Page
    {
        string connectionString = "SERVER=.,1500; Database=ASP;User=sa;Password=1";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT * FROM demoASP1";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds, "demoASP1");
            //gvProduct.DataSource = ds.Tables["demoASP1"].DefaultView;
            //gvProduct.DataBind();

            // SỬ DỤNG SQL COMMAND
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            // MỞ KẾT NỐI
            SqlDataReader reader = cmd.ExecuteReader();
            // TẠO ĐỐI TƯỢNG
            DataTable tbl = new DataTable();

            // ĐỌC DỮ LIỆU TỪ SQLDATAREADER
            tbl.Load(reader);
            gvProduct.DataSource = tbl;
            con.Close();
            gvProduct.DataBind();
        }
    }
}