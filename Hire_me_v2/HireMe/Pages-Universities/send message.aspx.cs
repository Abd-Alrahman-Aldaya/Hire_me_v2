﻿using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hire_me_v2.HireMe.Pages_Universities
{
    public partial class send_message : System.Web.UI.Page
    {
        Data_Access da;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 string message = Request.QueryString.Get("message").ToString();
                txt_message.Text = message;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            da = new Data_Access();
            //  int? id_university = Convert.ToInt32(Session["id_university"]);
            int? id_university = 1;
            int? id_gradute = Convert.ToInt32(Request.QueryString.Get("id"));
            DateTime dateTime =DateTime.Now;
            
            da.open_connection();
          da.EX_Non_Query_Insert("insert into tb_message (id_univesity,id_graduate,message,message_date,message_read) values(" + id_university+ "," + id_gradute + ",'" + txt_message.Text + "','"+dateTime.Year+"/"+dateTime.Month+"/"+dateTime.Day+"',0)");
            da.close_connection();
            Response.Redirect("~/HireMe/Pages-Universities/check_gradute.aspx");
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
           
        }
        // string e_name = Request.QueryString.Get("Email");
    }

}