using HireMe.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hire_me_v2.HireMe.Pages_Universities
{
    public partial class check_gradute : System.Web.UI.Page
    {
        Data_Access das;
        int id_grad;
        protected void Page_Load(object sender, EventArgs e)
        {
            das = new Data_Access();
           var dt_spec_gra= das.SelectData("select * from tb_graduate where graduate_check=0");


            if (dt_spec_gra.Rows.Count == 0)
            {
                return;
            }
            id_grad =(int) dt_spec_gra.Rows[0][0];
            lab_id_number_grdute.Text = dt_spec_gra.Rows[0][1].ToString();
            lab_name_gradute.Text = dt_spec_gra.Rows[0][2].ToString();
            lab_last_gradute.Text = dt_spec_gra.Rows[0][3].ToString();
            lab_father_name.Text = dt_spec_gra.Rows[0][4].ToString();
            lab_mather_name.Text = dt_spec_gra.Rows[0][5].ToString();
            lab_date_gra.Text= dt_spec_gra.Rows[0][6].ToString();
            lab_avg.Text= dt_spec_gra.Rows[0][7].ToString(); 
            lab_prof.Text= dt_spec_gra.Rows[0][8].ToString();



        }

        protected void btn_yes_Click(object sender, EventArgs e)
        {
            das = new Data_Access();
            das.open_connection();
            das.EX_Non_Query("update tb_graduate set graduate_check=1 where id_graduate="+ id_grad+"");
            das.close_connection();
            var dt_spec_gra = das.SelectData("select * from tb_graduate where graduate_check=0");
           
            if (dt_spec_gra.Rows.Count == 0)
            {
                return;
            }
            id_grad = (int)dt_spec_gra.Rows[0][0];
            lab_id_number_grdute.Text = dt_spec_gra.Rows[0][1].ToString();
            lab_name_gradute.Text = dt_spec_gra.Rows[0][2].ToString();
            lab_last_gradute.Text = dt_spec_gra.Rows[0][3].ToString();
            lab_father_name.Text = dt_spec_gra.Rows[0][4].ToString();
            lab_mather_name.Text = dt_spec_gra.Rows[0][5].ToString();
            lab_date_gra.Text = dt_spec_gra.Rows[0][6].ToString();
            lab_avg.Text = dt_spec_gra.Rows[0][7].ToString();
            lab_prof.Text = dt_spec_gra.Rows[0][8].ToString();

        }

        protected void btn_no_Click(object sender, EventArgs e)
        {

        }
    }
}