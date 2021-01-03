﻿using System;
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

namespace WindowsFormsApp1
{
    public partial class Library_Admin : Form
    {


        private AdminController Controller { get; }
        private WindowsFormsApp1.Model.AdminModel Model { get; }

        public Library_Admin(AdminController controller)
        {
            InitializeComponent();
            Visible = false;
            InitializeComponent();
            Controller = controller;
            Model = Controller.Model;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Controller.Buecher();
        }

        public void HideForm()
        {
            Hide();
        }

        public void ShowForm()
        {
            Show();
        }

        private void AdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.CloseProgram();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Buecher();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller.User();
        }
    }
}
