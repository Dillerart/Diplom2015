using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMan
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectTo_BD());
        }

    }
    //Передаю имя и id пользователя БД
    static class Ustr
    {
        public static string _user { get; set; }
        public static string _id { get; set; }
        public static string _id_clients { get; set; }
        public static string _sim { get; set; }
        public static string _name { get; set; }
        public static string _num { get; set; }
        public static string _sum { get; set; }
    }
    //Передаю данные о клиенте для редактирования
    static class Edit_cl
    {
        public static string _card { get; set; }
        public static string _fio { get; set; }
        public static string _disc { get; set; }
        public static string _bonus { get; set; }
        public static string _inform2 { get; set; }
        public static string _idser { get; set; }

    }
    //перетаскиваю данные для обновления на другую форму
        static class _UseBDs
        {
            public static string _id { get; set; }
            public static string _login { get; set; }
            public static string _pass { get; set; }
            public static string _Name { get; set; }
            public static string _info { get; set; }
            public static string _role { get; set; }


        }
    //передача данных для удаления
        static class Delete_cl
        {
            public static string _inf { get; set; }
            public static bool _gf { get; set; }
        }
        static class _printer
        {
            public static string _name { get; set; }
            public static string _id { get; set; }
            public static string _sd { get; set; }
        }
    }

