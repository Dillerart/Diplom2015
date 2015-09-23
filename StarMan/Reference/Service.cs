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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
            User_acc();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void add_bt_Click(object sender, EventArgs e)
        {
            if (t_name.Text != "")
            {
                l_error.Text = "";
                string into = @" BEGIN TRANSACTION; INSERT INTO Service (Service.Name, Service.Price, Service._delete)
                                            VALUES ('" + t_name.Text + "', '" + t_money.Text.Replace(",", ".") + "', 'False') COMMIT TRANSACTION;";
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
            if (t_name.Text != "")
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @" BEGIN TRANSACTION; UPDATE Service 
                                 SET  Service.Name='" + t_name.Text + "' ,Service.Price='" + t_money.Text.Replace(",", ".") +
                                                          "'WHERE Service.id_service ='" + sim + "' COMMIT TRANSACTION;";

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
            else l_error.Text = "Не все поля заполнены.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @" BEGIN TRANSACTION; UPDATE Service 
                                 SET  Service._delete='True' 
                                      WHERE Service.id_service ='" + sim + "' COMMIT TRANSACTION;";

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
                l_error.Text = "Не выбрана услуга.";
            }
            
        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            _deleteService stim = new _deleteService();
            stim.ShowDialog();
        }

        private void Service_Activated(object sender, EventArgs e)
        {
            User_acc();
        }

        private void t_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if (t_money.Text.IndexOf(',') != -1)
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

        private void t_money_TextChanged(object sender, EventArgs e)
        {
          
        }

       

    }
}
