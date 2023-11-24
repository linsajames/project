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
    public partial class addcat : System.Web.UI.Page
    {
        conclass obj = new conclass();
        public void gridbind()
        {
            string str = "select * from category";

            DataSet ds = obj.Fn_DataSet(str);

            GridView1.DataSource = ds;

            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridbind();
            }
        }
        

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from category where cat_id=" + id + "";
            int g = obj.Fun_Non_Query(del);
           
            gridbind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;

            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtnm = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox txtstatus=(TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            string update = "update category set cat_name='" + txtnm.Text + "',cat_description='" + txtdesc.Text + "',cat_status='"+txtstatus.Text+"' where cat_id=" + id + "";
            int j= obj.Fun_Non_Query(update);
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/category/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into category values('" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','" + DropDownList1.SelectedItem.Value + "')";
            int i = obj.Fun_Non_Query(ins);
            gridbind();
        }
    }
}