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

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (checkInputFields()) {
                Controller.save(this.txtAuthor.Text, 
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
            bool txtInventoryNumberIsParsable = Int32.TryParse(this.txtInventoryNumber.Text, out int n);
            bool txtISBNIsParsable = Int32.TryParse(this.txtISBN.Text, out int j);
            if (this.txtInventoryNumber.Text == "" || !txtInventoryNumberIsParsable) this.inventory.ForeColor = Color.Red;
            if (this.txtISBN.Text == "" || !txtISBNIsParsable) this.iSBN.ForeColor = Color.Red;
            return this.inventory.ForeColor == Color.Black && this.iSBN.ForeColor == Color.Black; 
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Controller.close();
        }
    }
}
