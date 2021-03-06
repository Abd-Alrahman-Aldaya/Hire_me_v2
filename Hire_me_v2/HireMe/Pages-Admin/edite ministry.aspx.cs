using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HireMe.Class;
using System.Data;

namespace HireMe.Pages_ministry
{
    public partial class ادارة_الوزارة : System.Web.UI.Page
    {
        Data_Access ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string q = "select ministry_name from tb_ministry";
            if (!IsPostBack)
            {
                ds = new Data_Access();
                var ministry_n = ds.SelectData(q);
                DropDown_ministry.DataSource= ministry_n;
                DropDown_ministry.DataValueField = "ministry_name";
                DropDown_ministry.DataTextField = "ministry_name";
                DropDown_ministry.DataBind();
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            ds = new Data_Access();
            ds.open_connection();
            string update = "update tb_ministry set ministry_name='" + new_name_ministrty.Text + "' where ministry_name='"+ DropDown_ministry.SelectedValue+"'";
            ds.EX_Non_Query(update);
            ds.close_connection();
        }

        protected void btn_remove_Click(object sender, EventArgs e)
        {
            ds = new Data_Access();
            ds.open_connection();
            string remove = "delete from tb_ministry where ministry_name='"+ DropDown_ministry.SelectedValue+"'";
            ds.EX_Non_Query(remove);
            ds.close_connection();
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("page-admin.aspx");
        }


    }
}