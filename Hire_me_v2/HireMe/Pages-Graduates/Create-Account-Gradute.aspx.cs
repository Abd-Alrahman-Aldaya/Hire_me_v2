using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HireMe.Pages_Graduates
{
    public partial class Sign_in_Gradutes : System.Web.UI.Page
    {
        Data_Access das;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void function_Create_Account_Next(object sender, EventArgs e)
        {
            das = new Data_Access();
            string q = "insert into tb_graduate values('" + id_number_gradute.Text+ "','" + first_name_gradute.Text + "','"+last_name_gradute.Text+"','" + fname_gradute.Text + "','" + mname_gradute.Text + "','" + date_gradute.Text + "'," + avg_gradute.Text + ",'" + specialization_gradute.Text + "','" + DDL_country_gradute.SelectedValue + "','0','" + email_gradute_new.Text + "','" + pass_gradute_new.Text + "',0)";
            das.open_connection();
           // das.EX_Non_Query(q);
            das.close_connection();
          // Session["id_N_G"] = id_number_gradute.Text;
         //  Session["brof"] = specialization_gradute.Text;
           Session["brof"] = "هندسة معلوماتية";
            // Session["avg"] = avg_gradute.Text;
            Session["avg"] = 60;
            Response.Redirect("Desires-Gradute.aspx");
        }
    }
}