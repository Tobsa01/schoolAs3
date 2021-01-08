using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Model;


namespace WindowsFormsApp1.Controller
{
    public class LendController : IController
    {
        private BookLendView View { get; }
        public WindowsFormsApp1.Model.BookAdminModel Model { get; }

        public LendController()
        {
            View = new BookLendView(this);
        }

        public void ShowForm(string iSBN, string inventoryNumber)
        {
            View.ShowForm(iSBN, inventoryNumber);
        }
        public void HideForm()
        {
            View.HideForm();
        }
        public void Lend(string iSBN, string inventoryNumber, int userID, int mANumber)
        {
            int id = BookAdminModel.maxReservationId();
            Reservation res = new Reservation(id, iSBN, inventoryNumber, userID, mANumber);
            BookAdminModel.lendBook(res);
            View.HideForm();
        }
    }
}
