using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hire_me_v2.HireMe.Class;

namespace Hire_me_v2.HireMe.Pages_Universities
{
    public partial class send_message : System.Web.UI.Page
    {
        Data_Access da;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // string i = HttpUtility.UrlDecode(Ceaser.Decipher(Request.QueryString.Get("message").ToString(),5));
                 string message = Request.QueryString.Get("message").ToString();
                string a = HttpUtility.UrlDecode(Ceaser.Decipher(message,5));
                 txt_message.Text = a;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
           
        }

        protected void btn_send_message(object sender, EventArgs e)
        {
            da = new Data_Access();
            //  int? id_university = Convert.ToInt32(Session["id_university"]);
            int? id_university = 1;
            int? id_gradute = Convert.ToInt32(Request.QueryString.Get("id"));
            DateTime dateTime = DateTime.Now;

            da.open_connection();
          //  da.EX_Non_Query_Insert("insert into tb_message (id_univesity,id_graduate,message,message_date,message_read) values(" + id_university + "," + id_gradute + ",'" + txt_messagee.Text + "','" + dateTime.Year + "/" + dateTime.Month + "/" + dateTime.Day + "',0)");
            da.close_connection();
            Response.Redirect("~/HireMe/Pages-Universities/check_gradute.aspx");
        }
        // string e_name = Request.QueryString.Get("Email");
    }

}