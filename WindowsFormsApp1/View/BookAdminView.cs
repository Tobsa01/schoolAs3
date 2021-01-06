using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class BookAdminView : Form
    {
        private WindowsFormsApp1.Controller.BookAdminController Controller { get; }
        private WindowsFormsApp1.Model.BookAdminModel Model { get; }
        public BookAdminView(WindowsFormsApp1.Controller.BookAdminController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            Model = Controller.Model;
        }

       
        public void HideForm()   
        {
            Hide();
           
        }

        public void ShowForm()
        {
            Show();
        }

        private void BookAdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.CloseProgram();
        }
    }
}


