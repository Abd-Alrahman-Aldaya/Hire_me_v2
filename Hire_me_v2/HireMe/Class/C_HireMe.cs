using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HireMe.Class;
using System.Data;

namespace HireMe.Class
{
    public class C_HireMe
    {
        DataTable order;

        public DataTable Order { get => order; set => order = value; }

        public void AVG_Sort()
        {
            string q = "select * from tb_graduate order by graduate_avg desc";
            Data_Access ds = new Data_Access();
            Order= ds.SelectData(q);  
        }
        public DataTable check_vacancy(int avg ,string prof)
        {
            string q = "select ministry_name, vacancy_type from tb_ministry,tb_vacancy where tb_vacancy.id_ministry=tb_ministry.id_ministry and tb_vacancy.vacancy_avg>='" + avg+"'and tb_vacancy.vacancy_name='"+prof+"';";
            Data_Access ds = new Data_Access();
            DataTable dt = ds.SelectData(q);
            return dt ;
        }

        public void choice()
        {
            Data_Access ds = new Data_Access();
            DataTable dt = new DataTable();
            for (int i = 0; i < Order.Rows.Count; i++)
            {
                int x = (int)order.Rows[i][0];
                for (int j = 1; j < 6; j++)
                {
                string q = "select id_vacancy from tb_desire where id_graduate='" + x + "' and des_order='" + j + "'";
                var x1 =  ds.SelectData(q);
                 var s = ds.SelectData("select vacancy_count from tb_vacancy where id_vacancy='"+x1.Rows[0][0]+"'");
                    var x2 = ds.SelectData("select * from tb_result where id_ministry='" + x1 + "'");
                    if (x2.Rows.Count <(int) s.Rows[0][0])
                    {
                        
                    }
                }

            }

        }

        public DataTable Insert_To_Desire(string minstryname,int id_grudat,int desorder)
        {
            string q = "select id_ministry from tb_ministry where ministry_name='" + minstryname + "'";
            Data_Access ds = new Data_Access();
            DataTable dt = ds.SelectData(q);
            int id_minstry =(int) dt.Rows[0][0];
            ds.open_connection();
            ds.EX_Non_Query("insert into tb_desire (id_graduate,id_vacancy,des_order) values('"+id_grudat+"','"+id_minstry+"','"+desorder+"')");
            ds.close_connection();
                return dt;
        }
        public void insert_To_Result( )
        {
            
            int id_gradute = 0;
            Data_Access ds = new Data_Access();
            //gradute prof
            //vac count 
            AVG_Sort();
            for (int i = 0; i < order.Rows.Count; i++)
            {
                id_gradute = (int)order.Rows[i][0];
                  string prof = "select graduate_profession from tb_graduate where id_graduate ='" + id_gradute + "';";
                    var pro = ds.SelectData(prof);
                for (int j = 0; j < 1; j++)
                { 
                    var id_minstry_desire = ds.SelectData("select id_vacancy from tb_desire where id_graduate='" + id_gradute + "'and des_order='" + 1 + "'");
                    string count = "select vacancy_count from tb_vacancy where id_ministry ='" + id_minstry_desire.Rows[0][0] + "' and vacancy_name ='" + pro.Rows[0][0] + "'";
                    var vaccount = ds.SelectData(count);

                    if ((int)vaccount.Rows[0][0] > 0)
                    {
                        // توقفنا عندما فرش البرنامج عند الطالب رقم 2 و سنكمل بعد انتهاء من صفحة الطالب
                        string insert_to_result = "insert into tb_result values('" + id_minstry_desire.Rows[0][0] + "','" + id_gradute + "';";
                        ds.open_connection();
                     //   ds.EX_Non_Query(insert_to_result);
                        ds.close_connection();
                        break;
                    }
                

                }
            }
        }
    }
}