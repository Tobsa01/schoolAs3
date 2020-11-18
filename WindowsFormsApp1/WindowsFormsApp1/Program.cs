﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsersModel.insert_User("Tro", "ttt", "t@t", 1567, "adm", "test");
            UsersModel.insert_User("den", "san", "s@s", 1345, "usr", "tset");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Library_Admin());

            var window = new WindowsFormsApp1.View.MainView();
            Application.Run();
        }
    }
}
