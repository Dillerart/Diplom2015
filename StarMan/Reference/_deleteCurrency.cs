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
    public partial class _deleteCurrency : Form
    {
        public _deleteCurrency()
        {
            InitializeComponent();
            User_acc();
        }
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Наименование оплаты";
            DatGridUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        //Вставка данных в таблицу
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_currency, me.Name
                                      From Currency me
                                      Where me._delete='True'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @"BEGIN TRANSACTION;
                            UPDATE Currency 
                                 SET  Currency._delete='False' 
                                      WHERE Currency.id_currency ='" + sim + "' COMMIT TRANSACTION;";

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
           
            catch
            {
                 MessageBox.Show("Не выбран вид валюты.", "Внимание!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str = new ToConnection();
                string ac_commandText = @"select me.id_currency
                                      from Flow me 
                                      where me.id_currency = '" + sim + "'";
                SqlConnection connection = new SqlConnection(str.read_conf());
                try
                {
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
                        MessageBox.Show("Данный метод оплаты не может быть удален по скольку использовался ранее в пополнении денежных средст на счет.", "Внимание!", MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                 MessageBox.Show("Не выбран вид валюты.", "Внимание!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
            }
           
        }
        private void _delete(string sim)
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @" BEGIN TRANSACTION; DELETE From Currency
                                      Where Currency.id_currency='" + sim + "' COMMIT TRANSACTION;";
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
