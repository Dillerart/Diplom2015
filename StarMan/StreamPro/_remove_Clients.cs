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
    public partial class _remove_Clients : Form
    {
        public _remove_Clients()
        {
            InitializeComponent();
            User_acc();
            MessageBox.Show("Удаление из корзины приведет к удалению всех транзакций по данному клиенту.","Внимание!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //создание костяка таблицы
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Номер карты";
            DatGridUser.Columns[1].Width = 100;
            DatGridUser.Columns[2].HeaderText = "ФИО";
            DatGridUser.Columns[2].Width = 210;
            DatGridUser.Columns[3].HeaderText = "Дата регистрации";
            DatGridUser.Columns[3].Width = 120;
            DatGridUser.Columns[4].HeaderText = "Доступные средства";
            DatGridUser.Columns[4].Width = 110;
            DatGridUser.Columns[5].HeaderText = "Создан";
            DatGridUser.Columns[5].Width = 160;
            DatGridUser.Columns[6].HeaderText = "Причина удаления";
            DatGridUser.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        //Вставка данных в таблицу
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_client, me.Number_card, me.Name, me.Date_reg, me.Sum_money, me3.NameInfoUser, me._inform_delete
                                      From Client me, Access_user me3
                                      Where me.id_access = me3.id_access and me._delete='True'";
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
        //снятие пометки на удаление
        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
            int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
            string star_del = DatGridUser[0, ind_sql].Value.ToString();
            _remove(star_del);
            User_acc();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Клиент базы данных не выбрана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //метод снятия
        private void _remove(string star_del)
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @" BEGIN TRANSACTION;
                                        UPDATE Client
                                      SET Client._delete = 'False'
                                      Where Client.id_client='" + star_del + "' COMMIT TRANSACTION;";

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
        //закрытие формы
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //удаление -> каскадное
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string star_del = DatGridUser[0, ind_sql].Value.ToString();
                _delete(star_del);
                User_acc();
            }
            catch 
            {
                MessageBox.Show("Клиент базы данных не выбрана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
        //метод удаления
        private void _delete(string star_del)
        {
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"BEGIN TRANSACTION;
                                        DELETE From Client
                                      Where Client.id_client='" + star_del + "' COMMIT TRANSACTION;";
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
