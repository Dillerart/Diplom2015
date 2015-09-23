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
    public partial class Level_bns : Form
    {
        public Level_bns()
        {
            InitializeComponent();
            User_acc();
            _select2();
        }
        //комбобокс - бонусы
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
        //размерность таблицы
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Уровнь";
            DatGridUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatGridUser.Columns[2].HeaderText = "Наименование бонуса";
            DatGridUser.Columns[2].Width = 100;
            DatGridUser.Columns[3].HeaderText = "MIN";
            DatGridUser.Columns[3].Width = 100;
            DatGridUser.Columns[3].DefaultCellStyle.Format = "C2";
            DatGridUser.Columns[4].HeaderText = "MAX";
            DatGridUser.Columns[4].Width = 100;
            DatGridUser.Columns[4].DefaultCellStyle.Format = "C2";
            

        }
        //Вставка данных в таблицу
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_level, me.Name, me2.Name, me.level_min, me.level_max
                                      From Level_bns me, Bonus me2
                                      Where me.id_bonus=me2.id_bonus";
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
        //функция  вписания в БД таблица Level_bns
        public void str(string _bonus)
        {
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());


            string s = @"BEGIN TRANSACTION; INSERT INTO Level_bns (id_bonus, Name, level_min, level_max) 
                         VALUES ('" + _bonus + "','" + t_name.Text + "', '" + t_min.Text + "', '" + t_max.Text + "') COMMIT TRANSACTION;";

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
            User_acc();
        }
        //кнопка добавить с условиями
        private void add_bt_Click(object sender, EventArgs e)
        {
            
                //Поиск максимального числа в МАХ для сравнения с предыдущем
                string _sill = "";
                ToConnection str_id_bonus2 = new ToConnection();
                SqlConnection acc_id_bonus2 = new SqlConnection(str_id_bonus2.read_conf());
                string queryString3 = @"Select  Max(me.level_max) as Simm
                                        From Level_bns me";
                try
                {
                    acc_id_bonus2.Open();
                    SqlCommand cmd2 = new SqlCommand(queryString3, acc_id_bonus2);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        if (dr2["Simm"].ToString() != "")
                        {
                            _sill = dr2["Simm"].ToString();
                        }
                        else _sill = "0";
                       
                       
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

                //Проверка если он залезет в диапозон в других уровней
                if (Convert.ToDouble(t_min.Text) > Convert.ToDouble(_sill))
                {
                    //Проверка правильность МАХ и МIN
                    if (Convert.ToInt32(t_min.Text) < Convert.ToInt32(t_max.Text))
                    {
                        //Выбран ли бонус
                        if (c_Bonus.SelectedIndex != -1)
                        {

                            string _bonus = "";
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
                            //Поиск идентичного бонуса
                            bool otv1 = false;
                            int count = 0;
                            ToConnection str_number = new ToConnection();
                            SqlConnection acc_number = new SqlConnection(str_number.read_conf());
                            string tab_sql = @"Select me.id_bonus 
                                              From Level_bns me
                                              Where me.id_bonus='" + _bonus + "';";


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
                                if ((t_min.Text != "") & (t_max.Text != ""))
                                {
                                    str(_bonus);
                                    l_error.Text = "";
                                }
                                else l_error.Text = "Не все поля заполнены.";
                            }
                            else l_error.Text = "Такой бонус в уровне уже существует.";
                        }
                        else l_error.Text = "Не выбран бонус для уровня.";
                    }
                    else l_error.Text = "Min не может быть больше MAX.";
                }
                else l_error.Text = "Такой уровень уже есть.";
            }
            

        
        
        private void t_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void t_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }
        //удаление бонусов
        private void delete_bt_Click(object sender, EventArgs e)
        {
            int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
            string sim = DatGridUser[0, ind_sql].Value.ToString();
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"BEGIN TRANSACTION; DELETE From Level_bns COMMIT TRANSACTION;";
            try
            {
                acc.Open();
                SqlCommand s_User = new SqlCommand(tab_sql, acc);
                s_User.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                acc.Close();
            }
            User_acc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
