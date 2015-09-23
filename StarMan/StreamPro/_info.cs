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
    public partial class _info : Form
    {
        public _info()
        {
            InitializeComponent();
        }
        //передача данных об удалении+закрытие формы
        private void button1_Click(object sender, EventArgs e)
        {
            Delete_cl._inf = r_inf.Text;
            this.Close();
        }
    }
}
