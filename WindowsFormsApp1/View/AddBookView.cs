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

namespace WindowsFormsApp1.View
{
    public partial class AddBookView : Form
    {
        private static bool editMode;
        private AddBookController Controller;

        public AddBookView(AddBookController controller)
        {
            editMode = false;
            Visible = false;
            InitializeComponent();
            Controller = controller;
            this.FormClosing += new FormClosingEventHandler(Form_Closing);
        }
        public void HideForm()
        {
            this.txtISBN.ReadOnly = false;
            this.txtInventoryNumber.ReadOnly = false;
            this.txtISBN.BackColor = Color.White;
            this.txtInventoryNumber.BackColor = Color.White;
            this.inventory.ForeColor = Color.Black;
            this.iSBN.ForeColor = Color.Black;
            Hide();
        }

        public void ShowForm()
        {
            this.txtAuthor.Text = "";
            this.txtCondition.Text = "";
            this.txtDescription.Text = "";
            this.txtInventoryNumber.Text = "";
            this.txtISBN.Text = "";
            this.txtPublisher.Text = "";
            this.txtTitle.Text = "";
            editMode = false;
            Show();
        }
        private void Form_Closing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            HideForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (checkInputFields() && editMode == false) {
                Controller.save(this.txtAuthor.Text, 
                                this.txtCondition.Text, 
                                this.txtDescription.Text, 
                                this.txtInventoryNumber.Text, 
                                this.txtISBN.Text, 
                                this.txtPublisher.Text, 
                                this.txtTitle.Text);
            } else if(editMode) {
                Controller.update(this.txtAuthor.Text,
                               this.txtCondition.Text,
                               this.txtDescription.Text,
                               this.txtInventoryNumber.Text,
                               this.txtISBN.Text,
                               this.txtPublisher.Text,
                               this.txtTitle.Text);
            }
        }
        private bool checkInputFields()
        {
            this.inventory.ForeColor = Color.Black;
            this.iSBN.ForeColor = Color.Black;
            if (this.txtInventoryNumber.Text == "" ) this.inventory.ForeColor = Color.Red;
            if (this.txtISBN.Text == "") this.iSBN.ForeColor = Color.Red;
            return this.txtISBN.Text != "" && this.txtInventoryNumber.Text != ""; 
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Controller.close();
        }

        public void updateBook(Books b)
        {
            editMode = true;
            this.txtAuthor.Text = b.Author;
            this.txtCondition.Text = b.Condition;
            this.txtDescription.Text = b.Desription;
            this.txtInventoryNumber.Text = b.Inventar_Number;
            this.txtISBN.Text = b.ISBN;
            this.txtPublisher.Text = b.Publisher;
            this.txtTitle.Text = b.Title;
            this.txtISBN.ReadOnly = true;
            this.txtInventoryNumber.ReadOnly = true;
            this.txtISBN.BackColor = Color.Gray;
            this.txtInventoryNumber.BackColor = Color.Gray;
            Show();
        }
    }
}
