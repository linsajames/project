using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class adminreg : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string sel = "select max(reg_id) from login";
            string regid = obj.Fn_scalar(sel);
            int re = 0;
            if (regid == "")
            {
                re = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                re = newregid + 1;
            }
            string ins = "insert into ad_reg values(" + re+ ",'" + TextBox1.Text + "','" + TextBox2.Text + "', "+ TextBox3.Text+")";
            int i = obj.Fun_Non_Query(ins);
            if (i != 0)
            {
                string inslog = "insert into login values(" + re + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','admin','active')";
                int j = obj.Fun_Non_Query(inslog);
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}