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
    public partial class Client_edit : Form
    {
        public Client_edit()
        {
            InitializeComponent();
            _select2();
            _edit();
            limb();
        }
        public void simmm(string sim)
        {
            bool simm = true;
            if (sim == "False")
            {
                simm = false;
            }
            checkedListBox1.SetItemChecked(0, simm);
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

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //метод заполнения текстовых данных
        public void _edit()
        {
            t_num.Text = Edit_cl._card.Trim();
            t_fio.Text = Edit_cl._fio.Trim();
            c_Bonus.Text = Edit_cl._bonus.Trim();
            r_info.Text = Edit_cl._inform2.Trim();
        }
        //метод редактирования клиента
        private void _add_stream(string _bonus, string _level, string _bonus3)
        {
            string steam = Ustr._id;
            string s1 = "";
            string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());
            if (_level == "False")
            {
                s1 = @"BEGIN TRANSACTION;
                                 UPDATE Client 
                                 SET  _level = 'True',Client.Number_card='" + t_num.Text + "' ,Client.Name='" + t_fio.Text + "' ,Client.Inform='" + r_info.Text + "' ,Client.id_bonus ='" + _bonus3 + "' WHERE Client.id_client ='" + Edit_cl._idser + "' COMMIT TRANSACTION;";

            }
            else if (_level == "True")
            {
                s1 = @" BEGIN TRANSACTION;
                                UPDATE Client 
                                 SET  _level='False', Client.Number_card='" + t_num.Text + "' ,Client.Name='" + t_fio.Text + "' ,Client.Inform='" + r_info.Text + "' ,Client.id_bonus ='" + _bonus +
                                            "' WHERE Client.id_client ='" + Edit_cl._idser + "' COMMIT TRANSACTION;";

            }


            try
            {
                StreamPro _use = new StreamPro();
                acc_add.Open();
                SqlCommand comm_insert = new SqlCommand(s1, acc_add);
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
        //кнопка редактирования
        private void b_edit_Click(object sender, EventArgs e)
        {
            string _bonus3 = "";
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
            if (_level == "True")
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
                                      Where me.Number_card='" + t_num.Text + "';";


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
                    if ((t_num.Text != "") & (t_fio.Text != ""))
                    {
                        _add_stream(_bonus, _level, _bonus3);
                        l_error.Text = "";
                    }
                    else l_error.Text = "Не заполнены поля:Номер карты или ФИО";
                }
                else l_error.Text = "Такой номер карты уже существует.";

            }
            else l_error.Text = "Не выбрана скидка.";
        }

        private void t_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
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
        private void limb()
        {
            string _bonus3 = "";
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
                    MessageBox.Show("Для использования уровней бонусной системы необходимо создать Нулевой бонус!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
