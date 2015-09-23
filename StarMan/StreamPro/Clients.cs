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

namespace StarMan
{
    public partial class Clients : Form
    {
       
        
        
        public Clients()
        {
            InitializeComponent();
            _select2();
            toolStripStatusLabel2.Text = Ustr._user;
            c_Bonus.Enabled = true;
            limb();
        }
        public string acc_usercl;

        //закрытие
        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        //Заполняем имена бонусов в c_bonus автоматически
        public void _select2()
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());
            string queryString1 = @"Select me.id_bonus, me.Name
                                    From Bonus me";

            try
            {
                acc.Open();
                SqlCommand cmd1 = new SqlCommand(queryString1, acc);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    c_Bonus.Items.Add(dr["Name"]);
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
        //запись данных в БД
        private void _add_stream(string _bonus, string _level, string _bonus3)
        {
            string s="";
            string steam = Ustr._id;
            string s1 = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());
            if (_level == "False")
            {
                s = @"BEGIN TRANSACTION;
                        INSERT INTO Client (id_access, id_bonus, Number_card, Name, Inform, Date_reg, _delete, Block, Sum_Expenses, Sum_Flow, _level) 
                         VALUES ('" + steam + "', '" + _bonus3 + "','" + t_number.Text + "', '" + t_FIO.Text + "', '" + r_info.Text + "','" + s1 + "','False','False','0','0', 'True') COMMIT TRANSACTION;";
           
            }
            else if (_level == "True")
            {
                s = @"BEGIN TRANSACTION;
                        INSERT INTO Client (id_access, id_bonus, Number_card, Name, Inform, Date_reg, _delete, Block, Sum_Expenses, Sum_Flow, _level) 
                         VALUES ('" + steam + "','" + _bonus + "', '" + t_number.Text + "', '" + t_FIO.Text + "', '" + r_info.Text + "','" + s1 + "','False','False','0','0', 'False') COMMIT TRANSACTION;";
        
            }
         
            try
            {
                StreamPro _use = new StreamPro();
                acc_add.Open();
                SqlCommand comm_insert = new SqlCommand(s, acc_add);
                comm_insert.ExecuteNonQuery();


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
        //Выполнение кнопки с проверкой условия
        private void button1_Click(object sender, EventArgs e)
        {
            string _bonus3="";
            ToConnection str_id_bonus2 = new ToConnection();
            SqlConnection acc_id_bonus2 = new SqlConnection(str_id_bonus2.read_conf());
            string queryString3 = @"Select me.id_bonus 
                                        From Bonus me
                                        where me.bonus = '0'";
            try
            {
                acc_id_bonus2.Open();
                SqlCommand cmd2 = new SqlCommand(queryString3, acc_id_bonus2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    _bonus3 = dr2["id_bonus"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc_id_bonus2.Close();

            }
            bool mil = false;
            string _level = c_Bonus.Enabled.ToString();
            bool sim = false;
            if (_level == "True" )
            {
                if (c_Bonus.SelectedIndex != -1)
                {
                    sim = true;
                    mil = true; 
                }
                else sim = false;

            }
            else sim = true;


            if (sim == true)
            {
                string _bonus = "";
                if (mil == true)
                 {
                    //Поиск выбранных бонусов
                    ToConnection str_id_bonus = new ToConnection();
                    SqlConnection acc_id_bonus = new SqlConnection(str_id_bonus.read_conf());
                    string queryString2 = @"Select me.id_bonus 
                                        From Bonus me
                                        where me.Name = '" + c_Bonus.SelectedItem.ToString() + "'";
                    try
                    {
                        acc_id_bonus.Open();
                        SqlCommand cmd2 = new SqlCommand(queryString2, acc_id_bonus);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            _bonus = dr2["id_bonus"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        acc_id_bonus.Close();

                    }
               }
             //поиск схожих номеров
               
                bool otv1 = false;
                int count = 0;
                ToConnection str_number = new ToConnection();
                SqlConnection acc_number = new SqlConnection(str_number.read_conf());
                string tab_sql = @"Select me.Number_card 
                                      From Client me
                                      Where me.Number_card='" + t_number.Text + "';";


                try
                {
                    acc_number.Open();
                    SqlCommand s_User = new SqlCommand(tab_sql, acc_number);
                    SqlDataReader read_sql = s_User.ExecuteReader();

                    while (read_sql.Read())
                    {
                        count += 1;

                    }
                    if (count == 1)
                    {
                        otv1 = false;
                    }
                    else if (count == 0)
                    {
                        otv1 = true;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    acc_number.Close();
                }
                if (otv1 == true)
                {
                    l_error.Text = "";
                    if ((t_number.Text != "") & (t_FIO.Text != ""))
                    {
                        _add_stream(_bonus, _level, _bonus3);
                        l_error.Text = "";
                    }
                    else l_error.Text = "Не заполнены поля:Номер карты или ФИО.";
                }
                else l_error.Text = "Такой номер карты уже существует.";
            }
            else l_error.Text = "Не выбрана скидка.";
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
               if (checkedListBox1.GetItemChecked(0) == true)
            {
                
                c_Bonus.Enabled = true;
            }
            else if (checkedListBox1.GetItemChecked(0) == false)
            {
                c_Bonus.Enabled = false;
               
            }
        }

        private void t_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void limb()
        {
            string _bonus3="";
            ToConnection str_id_bonus2 = new ToConnection();
            SqlConnection acc_id_bonus2 = new SqlConnection(str_id_bonus2.read_conf());
            string queryString3 = @"Select me.id_bonus 
                                        From Bonus me
                                        where me.bonus = '0'";
            try
            {
                acc_id_bonus2.Open();
                SqlCommand cmd2 = new SqlCommand(queryString3, acc_id_bonus2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    _bonus3 = dr2["id_bonus"].ToString();

                }
                if (_bonus3 != "")
                {
                    checkedListBox1.Enabled = true;
                }
                else
                {
                    checkedListBox1.Enabled = false;
                    MessageBox.Show("Для использования уровней бонусной системы необходимо создать Нулевой бонус!","Предупреждение!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc_id_bonus2.Close();

            }
        }
       
    }
}
