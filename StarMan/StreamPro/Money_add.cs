using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace StarMan
{
    
    public partial class Money_add : Form
    {

        private string id_currency = "";
        private string id_client = "";
        public double s = 0;
        private  string sum_m;
        private string t_time_m;
        private string sum_bns_m;
        
        public Money_add()
        {
            InitializeComponent();
            _select2();
            
            
        }
        public void mig(string mi)
        {
            t_moneys.Text = mi;
        }
        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void _select2()
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());
            string queryString1 = @"Select me.Name, me.id_currency
                                    From Currency me
                                    Where me._delete = 'False'";
            
            try
            {
                acc.Open();
                SqlCommand cmd1 = new SqlCommand(queryString1, acc);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    c_money.Items.Add(dr1["Name"]);
                    c_money.SelectedIndex = 0;
                    id_currency = dr1["id_currency"].ToString();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();

            }
          
        }
        
        private void _add_money()
        {
            double sum = Convert.ToDouble(tex_money.Text) +((Convert.ToDouble(tex_money.Text)*Convert.ToDouble(Ustr._sim))*0.01);
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());
            string s1 = @"BEGIN TRANSACTION;
                        UPDATE Client
                        SET Sum_Flow +='" + Convert.ToString(sum).Replace(",",".") +
                        "' WHERE Client.Number_card = '" + t_moneys.Text + "'; COMMIT TRANSACTION;";
            try
            {
                StreamPro _use = new StreamPro();
                acc_add.Open();
                SqlCommand comm_update = new SqlCommand(s1, acc_add);
                comm_update.ExecuteNonQuery();
                sum_m = Convert.ToString(sum);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc_add.Close();
            }
        }
        private void _add_stream()
        {
           double dim = (Convert.ToDouble(tex_money.Text)*Convert.ToDouble(Ustr._sim))*0.01;
            string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());
           
            string s2 = @"BEGIN TRANSACTION;
                         INSERT INTO Flow (id_access, id_currency, id_client, Date, Sum, Sum_bonus) 
                         VALUES ('" + Ustr._id + "','" + id_currency + "', '" + Ustr._id_clients + "', '" + s + "', '" + tex_money.Text.Replace(",", ".") + "', '" + Convert.ToString(dim).Replace(",", ".") + "'); COMMIT TRANSACTION;";
            try
            {
                StreamPro _use = new StreamPro();
                acc_add.Open();
                SqlCommand comm_insert = new SqlCommand(s2, acc_add);
                comm_insert.ExecuteNonQuery();
                t_time_m = s;
                sum_bns_m = Convert.ToString(dim);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc_add.Close();
            }
           
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            if (c_money.SelectedIndex != -1)
            {
                _add_stream();
                _add_money();
                _check();
                check_add();
                
            }
            else l_error.Text = "Не выбран вид оплаты.";
            
                        
        }

        private void check_add()
        {
            
            string time_s = "t" + DateTime.Now.ToLongTimeString();
            string text = time_s.Replace(":", "_");
            string s = "d" + DateTime.Now.ToShortDateString() + " " + text;
            
            try
            {
                StreamWriter st = new StreamWriter(@".\All_Check\money_" +  s + ".txt");
                string rsim = "№ Карты:             " + _printer._id + "\r\n";
                rsim += "Клиент:              " + _printer._name + "\r\n";
                rsim += "--------------------------------------------------------\r\n";
                rsim += "Дата:                " + t_time_m + "\r\n";
                rsim += "Сумма внесенных денег:     " + Math.Round(Convert.ToDouble(tex_money.Text), 2) + " руб.\r\n";
                rsim += "Сумма Бонусов:            " + Math.Round(Convert.ToDouble(sum_bns_m), 2) + " руб.\r\n";
                rsim += "--------------------------------------------------------\r\n";
                rsim += "Итого:                     " + Math.Round(Convert.ToDouble(sum_m), 2) + " руб.\r\n";
                st.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        
        }
        private void tex_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (tex_money.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            
          e.Handled = true;
        }
      
        
        private void _check()
        {
            string rsim = "№ Карты:             " + _printer._id + "\r\n";
            rsim += "Клиент:              " + _printer._name + "\r\n";
            rsim += "--------------------------------------------------------\r\n";
            rsim += "Дата:                " + t_time_m + "\r\n";
            rsim += "Сумма внесенных денег:     " + Math.Round(Convert.ToDouble(tex_money.Text), 2) + " руб.\r\n";
            rsim += "Сумма Бонусов:            " + Math.Round(Convert.ToDouble(sum_bns_m), 2) + " руб.\r\n";
            rsim += "--------------------------------------------------------\r\n";
            rsim += "Итого:                     " + Math.Round(Convert.ToDouble(sum_m), 2) + " руб.\r\n";
            r_print.Text = rsim;
            
            
        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            Random rand = new Random();
//            for (int i = 1; i <= 200; i++)
//            {
//                int sim = rand.Next(100, 1000);
//                int lim = rand.Next(1, 5);
//                double dim = (Convert.ToDouble(sim) * Convert.ToDouble(Ustr._sim)) * 0.01;
//                string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
//                ToConnection str_add = new ToConnection();
//                SqlConnection acc_add = new SqlConnection(str_add.read_conf());

//                string s2 = @"BEGIN TRANSACTION;
//                         INSERT INTO Flow (id_access, id_currency, id_client, Date, Sum, Sum_bonus) 
//                         VALUES ('" + Ustr._id + "','" + id_currency + "', '" + Ustr._id_clients + "', '" + s + "', '" + Convert.ToString(sim) + "', '" + Convert.ToString(dim).Replace(",", ".") + "'); COMMIT TRANSACTION;";
//                try
//                {
//                    StreamPro _use = new StreamPro();
//                    acc_add.Open();
//                    SqlCommand comm_insert = new SqlCommand(s2, acc_add);
//                    comm_insert.ExecuteNonQuery();
//                    t_time_m = s;
//                    sum_bns_m = Convert.ToString(dim);


//                }
//                catch (SqlException ex)
//                {
//                    MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                }
//                finally
//                {
//                    acc_add.Close();
//                }





//                double sum = Convert.ToDouble(sim) + ((Convert.ToDouble(sim) * Convert.ToDouble(Ustr._sim)) * 0.01);
//                ToConnection str_add2 = new ToConnection();
//                SqlConnection acc_add2 = new SqlConnection(str_add2.read_conf());
//                string s1 = @"BEGIN TRANSACTION;
//                        UPDATE Client
//                        SET Sum_Flow +='" + Convert.ToString(sum).Replace(",", ".") +
//                            "' WHERE Client.id_client = '" + Ustr._id_clients + "'; COMMIT TRANSACTION;";
//                try
//                {
//                    StreamPro _use = new StreamPro();
//                    acc_add2.Open();
//                    SqlCommand comm_update2 = new SqlCommand(s1, acc_add2);
//                    comm_update2.ExecuteNonQuery();
                   

//                }
//                catch (SqlException ex)
//                {
//                    MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                }
//                finally
//                {
//                    acc_add2.Close();
//                }
//            }
//        }


    }
}
