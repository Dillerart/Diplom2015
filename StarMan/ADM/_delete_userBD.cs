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
    public partial class _delete_userBD : Form
    {
        public _delete_userBD()
        {
            InitializeComponent();
            User_acc();
        }
        public void _size()
        {
            DatGridUser.Columns[0].HeaderText = "№";
            DatGridUser.Columns[0].Width = 40;
            DatGridUser.Columns[1].HeaderText = "Логин";
            DatGridUser.Columns[1].Width = 140;
            DatGridUser.Columns[2].HeaderText = "ФИО";
            DatGridUser.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatGridUser.Columns[3].HeaderText = "Права доступа";
            DatGridUser.Columns[3].Width = 120;
            DatGridUser.Columns[4].HeaderText = "Дата/Время последнего изменения";
            DatGridUser.Columns[4].Width = 100;
          
        }
        public void User_acc()
        {

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());

            string tab_sql= @"Select me.id_access, me.Login, me.NameInfoUser, me2.Name_R, me.Date_iz
                                                  From Role me2, Access_User me
                                                   Where me.id_Role=me2.id_Role and me._delete = 'True'";
          
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
            string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            int ind_sql = Convert.ToInt32(DatGridUser.CurrentRow.Index.ToString());
            string sim = DatGridUser[0, ind_sql].Value.ToString();
            ToConnection str_add = new ToConnection();
            SqlConnection acc_add = new SqlConnection(str_add.read_conf());
            string s1 = @"BEGIN TRANSACTION; UPDATE Access_user 
                                 SET  Access_user._delete='False', Access_user.Date_iz='" + s +
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
