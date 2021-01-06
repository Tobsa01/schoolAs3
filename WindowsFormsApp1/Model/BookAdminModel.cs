using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class BookAdminModel
    {

        private static LibratorsEntities context = new LibratorsEntities();

        public List<Books> select_Book(string author, string isbn)
        {
            var query = from book in context.Books
                        where book.Author == author && book.ISBN == isbn
                        select book;

            return query.ToList();
        }

        public static void insert_Book(string author, string condition, string description, string inventarnr, string isbn, string publisher, string title)
        {
            Books book = new Books
            {
                Author=author,
                Condition=condition,
                Desription=description,
                Inventar_Number=inventarnr,
                ISBN=isbn,
                Publisher=publisher,
                Title=title
            };
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void update_Books(string author, string condition, string description, string inventarnr, string isbn, string publisher, string x)
        {
            Books books = context.Books.Where(u => u.ISBN == isbn).First();
            books.Author = author;
            books.Condition = condition;
            books.Desription = description;
            books.Inventar_Number = inventarnr;
            books.ISBN = isbn;
            books.Publisher = publisher;
            books.Title = x;
            context.SaveChanges();
        }

        public void delete_Book(string ISBN)
        {
            Books books = context.Books.Where(u => u.ISBN == ISBN).First();
            context.Books.Remove(books);
            context.SaveChanges();
        }
    }
}
