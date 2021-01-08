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

                context.SaveChanges();
                context.Reservations.Add(reservation);
                context.SaveChanges();
                MessageBox.Show("Das Buch mit der ISBN " + res.ISBN + " wurde für Mitarbeiter "+Bookadministration.UserID+" reserviert!", "Vormerkung", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void lendBook(Reservation res)
        {
            if (!IsReserved(res, UserModel.selectUserWithManNr(Bookadministration.UserID).UserID ))
            {
                Issues issue = new Issues
                {
                    FK_Inventar_Number = res.Inventar_Number,
                    FK_ISBN = res.ISBN,
                    FK_UserID = res.UserID,
                    IssueState = "aus",
                    StartDate = res.ReservationDate,
                    ReturnDate = res.ReservationDate.AddDays(30),
                    FK_MANumber = res.MANumber,
                };

                context.Issues.Add(issue);
                context.SaveChanges();
                MessageBox.Show("Das Buch mit der ISBN " + res.ISBN + " wurde für Mitarbeiter " + Bookadministration.UserID + " bis zum "+issue.ReturnDate+" ausgeliehen!", "Ausleihe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Das Buch wurde bereits von einem anderen Nutzer vorgemerkt.","Vormerkung vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        internal static void returnBook(Reservation res)
        {
            try
            {
                int man = Bookadministration.UserID;
                if ((context.Issues.Any(u => u.FK_ISBN == res.ISBN && u.FK_Inventar_Number == res.Inventar_Number && u.FK_MANumber == man)))
                {
                    Issues i = context.Issues.Where(u => u.FK_ISBN == res.ISBN && u.FK_Inventar_Number == res.Inventar_Number).First();
                    Issues issue = new Issues
                    {
                        FK_Inventar_Number = res.Inventar_Number,
                        FK_ISBN = res.ISBN,
                        FK_UserID = res.UserID,
                        IssueState = "ret",
                        StartDate = i.StartDate,
                        ReturnDate = res.ReservationDate,
                        FK_MANumber = res.MANumber,
                    };
                    context.Issues.Remove(i);
                    context.SaveChanges();
                    context.Issues.Add(issue);
                    context.SaveChanges();
                    MessageBox.Show("Rückgabe erfolgt!", "Rückgabe erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception e)
            {
                ErrorWindow.ShowCustomErrorWindow("Bitte prüfen Sie, ob das Buch auf diesen Nutzer ausgeliehen wurde.", "Fehler bei der Rückgabe", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
        }

        public static void delete_Book(string ISBN, string inventoryNumber)
        {
            try
            {
                if ((context.Reservations.Any(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber)))
                {
                    List<Reservations> ls = context.Reservations.Where(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber).ToList();
                    foreach (var l in ls) {
                        context.Reservations.Remove(l);
                    }
                }
                if ((context.Issues.Any(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber)))
                {
                    List<Issues> ls = context.Issues.Where(u => u.FK_ISBN == ISBN && u.FK_Inventar_Number == inventoryNumber).ToList();
                    foreach (var l in ls)
                    {
                        context.Issues.Remove(l);
                    }
                }
                context.SaveChanges();
                Books books = context.Books.Where(u => u.ISBN == ISBN && u.Inventar_Number == inventoryNumber).First();
                context.Books.Remove(books);
                context.SaveChanges();
            }catch (Exception e)
            {
                ErrorWindow.ShowCustomErrorWindow(e.Message+e.InnerException,"Fehler", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
        }

        public static bool IsReserved(Reservation res, int id)
        {
            return (context.Reservations.Any(u => u.FK_ISBN == res.ISBN && u.FK_Inventar_Number == res.Inventar_Number && u.FK_UserID != id));
        }
        public static bool IsLend(string isbn, string inventarnumber)
        {
            return (context.Issues.Any(u => u.FK_ISBN == isbn && u.FK_Inventar_Number == inventarnumber && u.IssueState=="aus"));
        }
    }
}
