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
    public partial class Adm_User : Form
    {
        public Adm_User()
        {
            InitializeComponent();
            User_acc();
        }

        //метод заполнения таблицы
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Логин";
            DatGridUser.Columns[1].Width = 140;
            DatGridUser.Columns[2].HeaderText = "Пароль";
            DatGridUser.Columns[2].Width = 140;
            DatGridUser.Columns[3].HeaderText = "ФИО";
            DatGridUser.Columns[3].Width = 140;
            DatGridUser.Columns[4].HeaderText = "Права доступа";
            DatGridUser.Columns[4].Width = 120;
            DatGridUser.Columns[5].HeaderText = "Дата/Время создания";
            DatGridUser.Columns[5].Width = 100;
            DatGridUser.Columns[6].HeaderText = "Дата/Время последнего изменения";
            DatGridUser.Columns[6].Width = 100;
            DatGridUser.Columns[7].HeaderText = "Доп. инфо";
            DatGridUser.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql = @"Select me.id_access, me.Login, me.Pass, me.NameInfoUser, me2.Name_R, me.Date ,me.Date_iz, me.Info_dop
                                      From Role me2, Access_User me
                                      Where me.id_Role=me2.id_Role and me._delete = 'False'";
            try
            {
                acc.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(tab_sql, acc);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                DatGridUser.DataSource = dt;
                _size();
                l_count.Text = Convert.ToString(DatGridUser.RowCount - 1);
                toolUser.Text = Ustr._user;
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
         
        public void _ADM(string _user)
        {
            toolUser.Text = _user;
            
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            add_userBD add_user = new add_userBD();
            add_user.ShowDialog();
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            try
            {
                
                l_error.Text = "";
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                _UseBDs._id = DatGridUser[0, ind_sql].Value.ToString();
                _UseBDs._login = DatGridUser[1, ind_sql].Value.ToString();
                _UseBDs._Name = DatGridUser[3, ind_sql].Value.ToString();
                _UseBDs._pass = DatGridUser[2, ind_sql].Value.ToString();
                _UseBDs._role = DatGridUser[4, ind_sql].Value.ToString();
                _UseBDs._info = DatGridUser[7, ind_sql].Value.ToString();
                edit_userBD edit_user = new edit_userBD();
                edit_user.ShowDialog();

            }
            catch
            {
                l_error.Text = "Пользователь не выбран.";
            }
            

        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_bt_Click(sender, e);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_bt_Click(sender, e);
        }

        private void Adm_User_Activated(object sender, EventArgs e)
        {
            User_acc();
        }

        private void b_remove_Click(object sender, EventArgs e)
        {
            _delete_userBD strij = new _delete_userBD();
            strij.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
                string sim = DatGridUser[0, ind_sql].Value.ToString();
                ToConnection str_add = new ToConnection();
                SqlConnection acc_add = new SqlConnection(str_add.read_conf());
                string s1 = @"BEGIN TRANSACTION; UPDATE Access_user 
                                 SET  Access_user._delete='True', Access_user.Date_iz='" + s +
                                          "'WHERE Access_user.id_access ='" + sim + "' COMMIT TRANSACTION;";

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
                l_error.Text ="Не выбран пользователь базы данных";
            }
        }
    }
}
