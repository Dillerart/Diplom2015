using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMan
{
    public partial class _All_Reports : Form
    {
        public _All_Reports()
        {
            InitializeComponent();
        }

        private void _All_Reports_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_card.Text != "")
            {
                ToConnection st = new ToConnection();
                this.DataTable3TableAdapter.Connection.ConnectionString = st.read_conf();
                this.DataTable3TableAdapter.Fill(this.UsersSSQl.DataTable3, Convert.ToInt32(t_card.Text));
                this.reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Введите номер карты");

        }
    }
}
