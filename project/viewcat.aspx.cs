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
    public partial class viewcat : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string str = "select * from category";
                DataSet ds = obj.Fn_DataSet(str);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
            
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int cat_id = Convert.ToInt32(e.CommandArgument);
            Session["cat_id"] = cat_id;
            Response.Redirect("viewpro.aspx");

        }
    }
}