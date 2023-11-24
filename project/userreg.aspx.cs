using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class userreg : System.Web.UI.Page
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
                re= 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                re= newregid + 1;
            }
            string ins = "insert into us_reg values(" + re + ",'" + TextBox1.Text + "','" + TextBox2.Text + "',"+TextBox3.Text+",'"+TextBox4.Text+"')";
            int i = obj.Fun_Non_Query(ins);
            string inslog = "insert into login values(" + re + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','user','active')";
            int j = obj.Fun_Non_Query(inslog);
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    