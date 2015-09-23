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
    public partial class _Buh_Reports : Form
    {
        public _Buh_Reports()
        {
            InitializeComponent();
        }

        private void _Buh_Reports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "UsersSSQl.DataTable5". При необходимости она может быть перемещена или удалена.
            //this.DataTable5TableAdapter.Fill(this.UsersSSQl.DataTable5);
            //this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (date_1.Value <= date_2.Value)
            {
                
                DateTime date1 = new DateTime(date_1.Value.Year, date_1.Value.Month, date_1.Value.Day, 00, 00, 00);
                DateTime date2 = new DateTime(date_2.Value.Year, date_2.Value.Month, date_2.Value.Day, 23, 59, 00);
                ToConnection st = new ToConnection();
                this.DataTable5TableAdapter.Connection.ConnectionString = st.read_conf();
                this.DataTable5TableAdapter.Fill(this.UsersSSQl.DataTable5, date1, date2);
                this.reportViewer1.RefreshReport();
               

            }
            else MessageBox.Show("Начальная дата не может быть больше даты окончания.");
        }
    }
}
