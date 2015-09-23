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
    public partial class Сurrency : Form
    {
        public Сurrency()
        {
            InitializeComponent();
            User_acc();
        }

          public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Вид оплаты";
            DatGridUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        //Вставка данных в таблицу
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_currency, me.Name
                                      From Currency me
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
        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            if (t_Name.Text !="")
            {
                l_error.Text = "";
                string into = @"BEGIN TRANSACTION; INSERT INTO Currency (Currency.Name, Currency._delete)
                                            VALUES ('" + t_Name.Text + "', 'False') COMMIT TRANSACTION;";
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
            else l_error.Text = "Заполните вид оплаты.";
              
        
            
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            if (t_Name.Text != "")
            {
                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @"BEGIN TRANSACTION; UPDATE Currency 
                                 SET  Currency.Name='" + t_Name.Text +
                                                          "'WHERE Currency.id_currency ='" + sim + "' COMMIT TRANSACTION;";

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
            else l_error.Text = "Заполните вид оплаты.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @"BEGIN TRANSACTION; UPDATE Currency 
                                 SET  Currency._delete='True' 
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
                l_error.Text = "Не выбран вид оплаты.";
            }
       
        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            _deleteCurrency stim = new _deleteCurrency();
            stim.ShowDialog();
        }

        private void Сurrency_Activated(object sender, EventArgs e)
        {
            User_acc();
        }
    }
}
