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
    public partial class _deleteService : Form
    {
        public _deleteService()
        {
            InitializeComponent();
            User_acc();
        }
        //каркас таблицы
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Наименование услуги";
            DatGridUser.Columns[2].HeaderText = "Цена";
            DatGridUser.Columns[2].Width = 100;
            DatGridUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        //Вставка данных в таблицу
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_service, me.Name, me.Price
                                      From Service me
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
        //восстановить данные по кнопке - добавление в нынешнею таблицу
        private void button2_Click(object sender, EventArgs e)
        {
             try
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @" BEGIN TRANSACTION; UPDATE Service 
                                 SET  Service._delete='False' 
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
                 MessageBox.Show("Услуга не выбрана.","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Information);
             }
           
                
            
        }
        //закрыть
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Проверка по данному удалению - если услуга используеться то ее нельзя удалить
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str = new ToConnection();
                string ac_commandText = @"select me.id_service
                                      from Expenses me 
                                      where me.id_service = '" + sim + "'";
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
                    else MessageBox.Show("Данная услуга использовалась в транзакциях. Удаление услуги невозможно.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Услуга не выбрана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
           
        }
        private void _delete(string sim)
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"BEGIN TRANSACTION; DELETE From Service
                                      Where Service.id_service='" + sim + "'; COMMIT TRANSACTION;";
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
        }

    }
}
