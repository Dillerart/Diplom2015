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
    public partial class add_userBD : Form
    {
        public add_userBD()
        {
            InitializeComponent();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            int role = cBox_role.SelectedIndex + 1;
            bool otv1 = false;
            string us_login = txt_login.Text;
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());
            string tab_sql = @"Select me.Login 
                                      From Access_User me
                                      Where me.Login='" + us_login + "';";
            int count = 0;

            try
            {
                acc.Open();
                SqlCommand s_User = new SqlCommand(tab_sql, acc);
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
                acc.Close();
            }
            if (otv1 == true)
            {

                if ((txt_login.Text != "") & (txt_FIO.Text != "") & (txt_pass.Text != "") & (role != 0))
                {

                    string login = txt_login.Text;
                    string FIO = txt_FIO.Text;
                    string password = txt_pass.Text;
                    string _inform = t_info.Text;
                    bt_add_sql(FIO, login, password, role, _inform);

                }
                else MessageBox.Show("Не все поля заполнены.");

            }
            else MessageBox.Show("Такой пользователь уже сущестует.");
        }
        private void bt_add_sql(string FIO, string login, string password, int role, string _inform)
        {
            string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());
            string s1 = @"BEGIN TRANSACTION;
                            INSERT INTO Access_User (Login, Pass, id_Role, NameInfoUser, Info_dop, Date, Date_iz, _delete) 
                         VALUES ('" + login + "', '" + password + "','" + role + "', '" + FIO + "', '" + _inform + "', '" + s + "','" + s + "','False') COMMIT TRANSACTION;";
  
            try
            {
                acc.Open();
                
                SqlCommand comm_insert = new SqlCommand(s1, acc);
                comm_insert.ExecuteNonQuery();

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
    }
}
