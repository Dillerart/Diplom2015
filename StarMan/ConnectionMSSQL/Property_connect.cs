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
    public partial class Property_connect : Form
    {

        public Property_connect()
        {
            InitializeComponent();
        }

        private void b_Access_Click(object sender, EventArgs e)
        {
            string gream = @"Data Source=" + txtBoxSRV.Text +
                     ";Initial Catalog=" + txtBoxBD.Text +
                     ";Integrated Security=False;User ID=" + t_Login.Text +
                     ";Password=" + t_Pass.Text + ";Pooling = true;";
            SqlConnection _test = new SqlConnection(gream);
            try 
            {
                _test.Open();
                MessageBox.Show("Подключение к базе данных->" + txtBoxBD.Text + " прошло успешно, сохраните настройки.");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally 
            {
                _test.Close();
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=" + txtBoxSRV.Text + 
                            ";Initial Catalog=" + txtBoxBD.Text + 
                            ";Integrated Security=False;User ID=" + t_Login.Text + 
                            ";Password=" + t_Pass.Text + ";Pooling = true;";
            ToConnection ToConnection = new ToConnection();
            ToConnection.add_conf(conStr);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
