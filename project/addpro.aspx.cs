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
    public partial class addpro : System.Web.UI.Page
    {
        conclass obj = new conclass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridbind();
            }
        }
        public void gridbind()
        {
            string str = "select * from product";

            DataSet ds = obj.Fn_DataSet(str);

            GridView1.DataSource = ds;

            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from product where pro_id=" + id + "";
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
            TextBox txtnm = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtprice = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[9].Controls[0];
            TextBox txtstock = (TextBox)GridView1.Rows[i].Cells[10].Controls[0];
            string update = "update product set pro_name='" + txtnm.Text + "',pro_price=" + txtprice.Text + ",pro_description='" +txtdesc.Text + "',pro_status='"+txtstatus.Text+"',pro_stock='"+txtstock.Text+"' where pro_id=" + id + "";
            int j = obj.Fun_Non_Query(update);
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/category/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into product values(" + TextBox1.Text + ",'"+TextBox2.Text+"','" + p + "'," + TextBox3.Text + ",'" +TextBox4.Text+ "','" + DropDownList1.SelectedItem.Value + "','" + DropDownList2.SelectedItem.Value + "')";
            int i = obj.Fun_Non_Query(ins);
            gridbind();
        }
    }
    }
