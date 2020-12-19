using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Book
    {
        public string Inventar_Number { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Desription { get; set; }
        public string Condition { get; set; }
        public string Publisher { get; set; }
        public Book() { }
        public Book(string Inventar_Number, string ISBN, string Title, string Author, string Desription, string Condition, string Publisher)
        {
            this.Inventar_Number = Inventar_Number;
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Desription = Desription;
            this.Condition = Condition;
            this.Publisher = Publisher;
        }
    }
}
