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
            //Book b = new Book("13", "", "", "", "", "", "");
            //Book nB = new Book("0000000000000013", "1234567890124", "Tobi", "Tobi", "Tobi", "", "");
            //Book uB = new Book("0000000000000013", "1234567890124", "Sandra", "Sandra", "Sandra", "", "");
            //BookHandler bh = new BookHandler();
            //bh.filterBook = b;
            //bh.newBook = nB;
            //bh.deleteBook = uB;
            //List<Book> bs = bh.books;
            //bh.insertNewBook();
            //bh.getBookswithFilter();
            //bs = bh.books;
            //bh.currentBook = bh.books[0];
            //bh.newBook = uB;
            //bh.updateBook();
            //bh.getBookswithFilter();
            //bs = bh.books;
            //bh.deleteOldBook();
            //bh.getBookswithFilter();
            //bs = bh.books;
            //bh.insertNewBook();
            //bh.getBookswithFilter();
            //bs = bh.books;
            //bh.deleteOldBook();
            //bh.getBookswithFilter();
            //bs = bh.books;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Library_Admin());

            var window = new WindowsFormsApp1.View.MainView();
            Application.Run();
        }
    }
}
