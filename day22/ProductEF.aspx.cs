using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace day22
{
    public partial class ProductEF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPEntities1 ctx = new ASPEntities1();
            List<Product> products = new List<Product>();   
            GridView1.DataSource = ctx.demoASP1.ToList();
            GridView1.DataBind();
        }
    }

    internal class DemoEntities
    {
        public DemoEntities()
        {
        }
    }
}