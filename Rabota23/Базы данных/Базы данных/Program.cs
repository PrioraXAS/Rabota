using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Базы_данных
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form9());
        }
    }    
    static class DataBase // строка подключения к БД
    {
            public static string connectionString = @"Data Source=db.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    static class table_mir // описание таблиц из БД
    {
            public static string main = "table_mir";
            public static string ID = "ID";
            public static string Name = "Name";
            public static string Surname = "Surname";
            public static string Surname2 = "Surname2";

    }
    static class table_photos
    {
            public static string main = "table_photo";
            public static string ID = "ID";
            public static string photos = "photos";
    }

}
