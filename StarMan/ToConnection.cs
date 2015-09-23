using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.IO;


namespace StarMan
{
    class ToConnection
    {
        //запись строки подключения в файл
        public void add_conf(string conStr)
        {
            using (StreamWriter add_configurationsettings = new StreamWriter(@".\stAccess.ini"))
            {
                add_configurationsettings.WriteLine(conStr);
            }

        }
        //Чтение строки подключения из файл конфигуратора

        public string read_conf()
        {
            string line_read = "";

            using (StreamReader read_configurationsettings = new StreamReader(@".\stAccess.ini"))
            {
                return line_read = read_configurationsettings.ReadLine();
            }

        }

   
        
    }
}
