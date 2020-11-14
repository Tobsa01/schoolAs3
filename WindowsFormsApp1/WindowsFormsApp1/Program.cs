using System;
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
            Book b = new Book("1", "", "", "", "", "", "");
            Book nB = new Book("0000000000000013", "1234567890124", "Tobi", "Tobi", "Tobi", "", "");
            BookHandler bh = new BookHandler();
            bh.filterBook = b;
            bh.newBook = nB;
            bh.getBookswithFilter();
            bh.insertNewBook();
            List<Book> bs = bh.books;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Library_Admin());
        }
    }
}
