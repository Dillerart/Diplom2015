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
    public partial class edit_userBD : Form
    {
        public edit_userBD()
        {
            InitializeComponent();
            stim();
        }
        private void stim()
        {
            t_login.Text = _UseBDs._login.Trim();
            t_fio.Text = _UseBDs._Name.Trim();
            t_pass.Text = _UseBDs._pass.Trim();
            r_info.Text = _UseBDs._info.Trim();
            c_role.Text = _UseBDs._role.Trim();

        }
        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void up_ts(string _role)
        {

            string s = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            ToConnection str_config = new ToConnection();
            SqlConnection acc = new SqlConnection(str_config.read_conf());
            string s1 = @"BEGIN TRANSACTION;
                            UPDATE Access_User 
                                SET Login='" + t_login.Text + "',Pass='" + t_pass.Text + "',id_role='" + _role + "',NameInfoUser='" + t_fio.Text + "',Info_dop='" + r_info.Text + "', Date_iz='" + s +
                                                "' WHERE id_access='" + _UseBDs._id + "' COMMIT TRANSACTION;";

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
        private void b_edit_Click(object sender, EventArgs e)
        {
            if (c_role.SelectedIndex != -1)
            {
                //Поиск выбранных бонусов
                string _role = "";
                ToConnection str_id_bonus = new ToConnection();
                SqlConnection acc_id_bonus = new SqlConnection(str_id_bonus.read_conf());
                string queryString2 = @"Select me.id_role 
                                    From Role me
                                    where me.Name_R = '" + c_role.SelectedItem.ToString() + "'";
                try
                {
                    acc_id_bonus.Open();
                    SqlCommand cmd2 = new SqlCommand(queryString2, acc_id_bonus);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        _role = dr2["id_role"].ToString();
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


                //поиск схожих логинов
                bool otv1 = false;
                int count = 0;
                ToConnection str_number = new ToConnection();
                SqlConnection acc_number = new SqlConnection(str_number.read_conf());
                string tab_sql = @"Select me.Login 
                                      From Access_user me
                                      Where me.Login='" + t_login.Text + "';";


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
                    if ((t_login.Text != "") & (t_fio.Text != "") & (t_pass.Text != "") & (c_role.SelectedIndex != -1))
                    {
                        l_error.Text = "";

                        up_ts(_role);
                    }
                    else l_error.Text = "Не все поля заполнены.";
                }
                else l_error.Text = "Такой логин существует.";

            }
            else l_error.Text = "Не выбраны права доступа."; 
        }
    }
}
