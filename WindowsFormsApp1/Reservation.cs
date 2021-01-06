using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Reservation
    {
        public int ReservationID { get; }
        public string ISBN { get; }
        public string Inventar_Number { get; }
        public int UserID { get; }
        public int MANumber { get; }
        public DateTime ReservationDate { get; }
        private Reservation() { }
        public Reservation(int reservationID, string iSBN, string inventar_Number, int userID, int mANumber)
        {
            this.ReservationID = reservationID;
            this.ISBN = iSBN;
            this.Inventar_Number = inventar_Number;
            this.UserID = userID;
            this.MANumber = mANumber;
            this.ReservationDate = DateTime.Now;
        }
    }
}
