using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model
{
    public class BookAdminModel
    {

        private static LibratorsEntities context = new LibratorsEntities();

        public static Books select_Book(string inventoryNumber, string isbn)
        {
            var query = from book in context.Books
                        where book.Inventar_Number == inventoryNumber && book.ISBN == isbn
                        select book;

            return query.ToList()[0];
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

        public static void update_Book(Books oldBook, Books newBook)
        {
            Books books = context.Books.Where(u => 
                oldBook.Inventar_Number == u.Inventar_Number &&
                oldBook.ISBN == u.ISBN).First();
            books.Author = newBook.Author;
            books.Condition = newBook.Condition;
            books.Desription = newBook.Desription;
            books.Publisher = newBook.Publisher;
            books.Title = newBook.Title;
            context.SaveChanges();
        }
        public static void reserveBook(Reservation res)
        {
            Reservations reservation = new Reservations
            {
                FK_Inventar_Number = res.Inventar_Number,
                FK_ISBN = res.ISBN,
                FK_UserID = res.UserID,
                ReservationDate = res.ReservationDate,
                FK_MANumber = res.MANumber,
            };
            context.Reservations.Add(reservation);
            context.SaveChanges();
        }

        public static int maxReservationId()
        {
            var query = from reservation in context.Reservations select reservation.ReservationsID;
            List<int> ints = query.ToList();
            if (ints.Count < 0)
            {
                return ints.Max();
            }
            return 0;
        }

        public static void delete_Book(string ISBN, string inventoryNumber)
        {
            try
            {
                Books books = context.Books.Where(u => u.ISBN == ISBN && u.Inventar_Number == inventoryNumber).First();
                if ((context.Reservations.Any(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber)))
                {
                    context.Reservations.Remove(context.Reservations.Where(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber).First());
                }
                if ((context.Issues.Any(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber)))
                {
                    context.Issues.Remove(context.Issues.Where(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber).First());
                }
                context.Books.Remove(books);
                context.SaveChanges();
            }catch (Exception e)
            {
                ErrorWindow.ShowCustomErrorWindow(e.Message+e.InnerException,"Fehler", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
        }
    }
}
