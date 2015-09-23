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
    public partial class _Expenses : Form
    {
        public _Expenses()
        {
            InitializeComponent();
            _use_stream();
            User_acc();
        }
        private string sim_summm;
        private void _use_stream()
        {

           
            treeView1.Nodes[0].Nodes[0].Text = Ustr._num.Trim();
            treeView1.Nodes[1].Nodes[0].Text = Convert.ToString(Math.Round(Convert.ToDouble(Ustr._sum.Trim()), 2));
            textBox3.Text = Ustr._name.Trim();
            treeView1.Nodes[0].Expand();
            treeView1.Nodes[1].Expand();
            
            //Ustr._id_clients;
        }
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Наименование услуги";
            DatGridUser.Columns[2].HeaderText = "Цена";
            DatGridUser.Columns[2].Width = 100;
            DatGridUser.Columns[2].DefaultCellStyle.Format = "C2";
            DatGridUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        //Вставка данных в таблицу
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_service, me.Name, me.Price
                                      From Service me
                                      Where me._delete='False'";
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                l_error.Text = "";
                _summ_txt();
            }
            catch
            {
                l_error.Text = "Кол-во услуг не должно быть пустым.";
            }
            
            
        }
        private void _summ_txt()
        {
            int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
            string star_del = DatGridUser[2, ind_sql].Value.ToString();
            double summ_all = Convert.ToDouble(star_del) * Convert.ToDouble(textBox2.Text);
            _summ.Text = Convert.ToString(Math.Round(Convert.ToDouble(summ_all), 2));
        }

        private void DatGridUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                l_error.Text = "";
                _summ_txt();
            }
            catch
            {
                l_error.Text = "Не выбранна услуга.";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text !="") &(textBox2.Text !="0"))
            {
                limb2();
                double s1 = Math.Round(Convert.ToDouble(treeView1.Nodes[1].Nodes[0].Text), 2);
                double s2 = Math.Round(Convert.ToDouble(_summ.Text), 2);
                try
                {
                    if (s1 >= s2)
                    {
                        l_error.Text = "";
                        _add_stream();
                        _add_money();
                        limb();
                    }
                    else if (s1 < s2)
                    {
                        l_error.Text = "У вас недостаточно средств на карте.";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                _lvl_bonus_start();
            }
            else l_error.Text = "Кол-во услуг не должно быть нулевым.";
            

        }

        private void _add_money()
        {
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());
            string s1 = @"BEGIN TRANSACTION;
                        UPDATE Client
                        SET Sum_Expenses +='" + Convert.ToString(_summ.Text) +
                        "' WHERE Client.Number_card = '" + textBox3.Text + "'; COMMIT TRANSACTION;";
            try
            {
                StreamPro _use = new StreamPro();
                acc_add.Open();
                SqlCommand comm_update = new SqlCommand(s1, acc_add);
                comm_update.ExecuteNonQuery();
               

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

            string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());
            int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
            string star_del = DatGridUser[0, ind_sql].Value.ToString();
            string s2 = @"BEGIN TRANSACTION;
                         INSERT INTO Expenses (id_access, id_client, id_service, Count, Date, Sum) 
                         VALUES ('" + Ustr._id + "','" + Ustr._id_clients + "', '" + star_del + "', '" + textBox2.Text + "', '" + s + "', '" + _summ.Text + "'); COMMIT TRANSACTION;";
            try
            {
                StreamPro _use = new StreamPro();
                acc_add.Open();
                SqlCommand comm_insert = new SqlCommand(s2, acc_add);
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
        private void limb2()
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.Sum_money
                                      From Client me
                                      Where me.id_client ='" + Ustr._id_clients + "'";
            try
            {
                acc.Open();
                SqlCommand cmd2 = new SqlCommand(tab_sql, acc);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    sim_summm = dr2["Sum_money"].ToString().Trim();
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
        private void limb()
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.Sum_money
                                      From Client me
                                      Where me.id_client ='" + Ustr._id_clients + "'";
            try
            {
                acc.Open();
                SqlCommand cmd2 = new SqlCommand(tab_sql, acc);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    treeView1.Nodes[1].Nodes[0].Text = Convert.ToString(Math.Round(Convert.ToDouble(dr2["Sum_money"].ToString().Trim()), 2));
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
        private void _lvl_bonus_start()
        {
            //Поиск максимального числа в МАХ
            string _sill = "";
            string _mill = "";
            ToConnection str_id_bonus2 = new ToConnection();
            SqlConnection acc_id_bonus2 = new SqlConnection(str_id_bonus2.read_conf());
            string queryString3 = @"Select top 1 me.Sum_Expenses, me2.level_max,me2.level_min, me2.id_bonus, me._level 
                                    FROM Client me, Level_bns me2
                                    WHERE me.Sum_Expenses <= me2.level_max and me.Sum_Expenses >= me2.level_min and me.Number_card='" + textBox3.Text +
                                    "' GROUP BY me2.level_max, me.Sum_Expenses,me._level, me2.id_bonus, me2.level_min;";
            try
            {
                acc_id_bonus2.Open();
                SqlCommand cmd2 = new SqlCommand(queryString3, acc_id_bonus2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    if (dr2["id_bonus"].ToString() != "")
                    {
                        _sill = dr2["id_bonus"].ToString();
                        _mill = dr2["_level"].ToString();

                    }
                    else 
                            {
                                 _sill = "0";
                                 _mill = "0";
                            }

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
            if (_mill == "True")
            {
                if (_sill != "0")
                {
                    ToConnection str_add = new ToConnection();
                    SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                    string s1 = @" BEGIN TRANSACTION; UPDATE Client 
                                 SET  Client.id_bonus='" + _sill +
                                                              "'WHERE Client.Number_card ='" + textBox3.Text + "' COMMIT TRANSACTION;";

                    try
                    {
                        acc_add.Open();
                        SqlCommand comm_insert = new SqlCommand(s1, acc_add);
                        comm_insert.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex), "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        acc_add.Close();

                    }
                }
            
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
