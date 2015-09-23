using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StarMan
{
    public partial class ConnectTo_BD : Form
    {
        public ConnectTo_BD()
        {
            InitializeComponent();
        }
        
        private void свойствоПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Property_connect protect = new Property_connect();
            protect.ShowDialog();
        }

        private void b_ConnetTo_BD_Click(object sender, EventArgs e)
        {
           
            ToConnection str=new ToConnection();
            string _user = b_login.Text;
            int s = 0;
            string _use = "";
            string _name=""; 
            string ac_commandText = @"select *
                                      from Access_User 
                                      where LTRIM(RTRIM(Access_User.Login)) collate Cyrillic_General_CS_AS like '" + b_login .Text +
                                    "'and LTRIM(RTRIM(Access_User.Pass)) collate Cyrillic_General_CS_AS like '" + b_pass.Text + "'";

            SqlConnection connection = new SqlConnection(str.read_conf());
            try
            {
                connection.Open();
                string steamkread="";
                SqlCommand accessUser = new SqlCommand(ac_commandText, connection);
                SqlDataReader read_sql = accessUser.ExecuteReader();
                int count = 0;
                /*Цикл с условием: Пока читаю строки - счетчик +1(если счетчик 1 значит есть такая запись+открытие формы)
                 * иначе необходимо проверить логин и пароль
                 * */
                while (read_sql.Read())
                {   
                    _use = read_sql["id_access"].ToString();
                    s = Convert.ToInt16(read_sql["id_role"].ToString());
                    _name = read_sql["NameInfoUser"].ToString();;
                    count += 1;
                    Ustr._id = _use;
                    Ustr._user = _name;
                    steamkread = read_sql["_delete"].ToString();
                    
                   
                }
                if (steamkread != "True")
                {
                    if (count == 1)
                    {
                        if (s == 1)
                        {
                            StreamPro connect_SreamPro = new StreamPro();
                            connect_SreamPro.Text = "Касса";
                            connect_SreamPro._load();
                            connect_SreamPro.ShowDialog();
                            



                        }
                        if (s == 2)
                        {
                            StreamPro connect_SreamPro = new StreamPro();
                            connect_SreamPro.Text = "Бухгалтерия";
                            connect_SreamPro._load();
                            connect_SreamPro.ShowDialog();
                            

                        }
                        if (s == 3)
                        {
                            Adm_User connect_SreamPro = new Adm_User();
                            connect_SreamPro.ShowDialog();
                            
                        }
                    }
                    else if (count == 0)
                    {
                        MessageBox.Show("Вы неправильно ввели логин или пароль", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

                else MessageBox.Show("Данный пользователь удален администратором", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
              
            }
                catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
              
            }
            finally
            {
                connection.Close();
            }
                
            }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      


    }
}
