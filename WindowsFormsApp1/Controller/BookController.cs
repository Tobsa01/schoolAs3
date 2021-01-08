﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class BookController : IController
    {
        private Bookadministration View { get; }
        public WindowsFormsApp1.Model.BookAdminModel Model { get; }

        public BookController()
        {
            Model = new BookAdminModel();
            View = new Bookadministration(this);
        }

        public void ShowForm()
        {
            View.ShowForm();
        }

        public void CloseProgram()
        {
            Application.Exit();
        }

        public void HideForm()
        {
            View.HideForm();
        }

        public void Back()
        {
            HideForm();
            var admin = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.AdminController>();
            admin.ShowForm();
        }

        public void RefreshData()
        {
            View.RefreshData();
        }
        public void Delete(string iSBN, string inventoryNumber)
        {
            BookAdminModel.delete_Book(iSBN, inventoryNumber);
            RefreshData();
        }
        public void Add()
        {
            var addBook = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.AddBookController>();
            addBook.ShowForm();
        }
        public void ReserveBook(string iSBN, string inventory_Number)
        {
            int id = BookAdminModel.maxReservationId();
            Reservation res = new Reservation(id, iSBN, inventory_Number, CurrentUser.getUserId(), CurrentUser.getMANumber());
            BookAdminModel.reserveBook(res);
        }
        public void ShowBookInformation(string iSBN, string inventory_Number)
        {
            Books b = BookAdminModel.select_Book(inventory_Number, iSBN);
            var bcontroller = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.AddBookController>();
            bcontroller.updateBook(b);
        }

        public void LendBook(string iSBN, string inventoryNumber)
        {
            var lcontroller = WindowsFormsApp1.Controller.ControllerManager.Get<WindowsFormsApp1.Controller.LendController>();
            lcontroller.ShowForm(iSBN, inventoryNumber);
        }

        internal void ReturnBook(string iSBN, string inventoryNumber)
        {
            Reservation res = new Reservation(0, iSBN, inventoryNumber, CurrentUser.getUserId(), CurrentUser.getMANumber());
            BookAdminModel.returnBook(res);
        }
    }
}
