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
    public partial class Bonus : Form
    {
        public Bonus()
        {
            InitializeComponent();
            User_acc();
        }
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Наименование бонуса";
            DatGridUser.Columns[2].HeaderText = "Бонус, %";
            DatGridUser.Columns[2].Width = 100;
            DatGridUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        //Вставка данных в таблицу
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_bonus, me.Name, me.bonus
                                      From Bonus me";
            try
            {
                acc.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(tab_sql, acc);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                DatGridUser.DataSource = dt;
                _size();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void add_bt_Click(object sender, EventArgs e)
        {
            if ((t_Name.Text != "") & (textBox2.Text !=""))
            {
                l_error.Text = "";
                string into = @" BEGIN TRANSACTION; INSERT INTO Bonus (Bonus.Name, Bonus.bonus)
                                            VALUES ('" + t_Name.Text + "', '" + textBox2.Text + "') COMMIT TRANSACTION;";
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                try
                {
                    StreamPro _use = new StreamPro();
                    acc_add.Open();
                    SqlCommand comm_insert = new SqlCommand(into, acc_add);
                    comm_insert.ExecuteNonQuery();
                    User_acc();
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
            else l_error.Text = "Не все поля заполнены.";
              
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            if ((t_Name.Text != "") & (textBox2.Text != ""))
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @"BEGIN TRANSACTION; UPDATE Bonus 
                                 SET  Bonus.Name='" + t_Name.Text + "' ,Bonus.bonus='" + textBox2.Text +
                                                          "'WHERE Bonus.id_bonus ='" + sim + "' COMMIT TRANSACTION;";

                try
                {
                    StreamPro _use = new StreamPro();
                    acc_add.Open();
                    SqlCommand comm_insert = new SqlCommand(s1, acc_add);
                    comm_insert.ExecuteNonQuery();
                    User_acc();
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
            else l_error.Text = "Заполните все поля справочника услуги.";
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            try
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str = new ToConnection();
                string ac_commandText = @"select me.id_bonus
                                      from Client me 
                                      where me.id_bonus = '" + sim + "'";
                SqlConnection connection = new SqlConnection(str.read_conf());
                try
                {
                    l_error.Text = "";
                    connection.Open();
                    SqlCommand accessUser = new SqlCommand(ac_commandText, connection);
                    SqlDataReader read_sql = accessUser.ExecuteReader();
                    int count = 0;
                    while (read_sql.Read())
                    {
                        count += 1;
                    }
                    if (count == 0)
                    {
                        _delete(sim);
                    }
                    else if (count >= 1)
                    {
                        l_error.Text = "Данный бонус уже используеться. Удалить нельзя.";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                finally
                {
                    connection.Close();
                }
            }
            catch
            {
                l_error.Text = "Не выбран бонус.";
            }
            
        }
        private void _delete(string sim)
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"BEGIN TRANSACTION; DELETE From Bonus
                                      Where Bonus.id_bonus='" + sim + "' COMMIT TRANSACTION;";
            try
            {
                acc.Open();
                SqlCommand s_User = new SqlCommand(tab_sql, acc);
                s_User.ExecuteNonQuery();
                User_acc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;


            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
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

               
        
    }
}
