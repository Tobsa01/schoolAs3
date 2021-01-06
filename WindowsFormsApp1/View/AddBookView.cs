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
        private bool editMode = false;
        private AddBookController Controller;

        public AddBookView(AddBookController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
        }
        public void HideForm()
        {
            Hide();
        }

        public void ShowForm()
        {
            this.editMode = false;
            Show();
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

        private void AddBookView_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (checkInputFields() && !this.editMode) {
                Controller.save(this.txtAuthor.Text, 
                                this.txtCondition.Text, 
                                this.txtDescription.Text, 
                                this.txtInventoryNumber.Text, 
                                this.txtISBN.Text, 
                                this.txtPublisher.Text, 
                                this.txtTitle.Text);
            } else {
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
            return this.inventory.ForeColor == Color.Black && this.iSBN.ForeColor == Color.Black; 
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Controller.close();
        }

        public void updateBook(Books b)
        {
            this.editMode = true;
            this.txtAuthor.Text = b.Author;
            this.txtCondition.Text = b.Condition;
            this.txtDescription.Text = b.Desription;
            this.txtInventoryNumber.Text = b.Inventar_Number;
            this.txtISBN.Text = b.ISBN;
            this.txtPublisher.Text = b.Publisher;
            this.txtTitle.Text = b.Title;
            Show();
        }
    }
}
