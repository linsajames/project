using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace project
{
    public partial class WebForm : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "select * from product where cat_id="+Session["cat_id"]+"";
            DataSet ds = obj.Fn_DataSet(str);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int pro_id= Convert.ToInt32(e.CommandArgument);
            Session["pro_id"] = pro_id;
            Response.Redirect("particularproview.aspx");
        }
    }
}



