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
    public partial class GetUserIdView : Form
    {
        private GetUserIdController Controller;
        public GetUserIdView(GetUserIdController controller)
        {
            Visible = false;
            InitializeComponent();
            Controller = controller;
            this.FormClosing += new FormClosingEventHandler(Form_Closing);
        }

        private void Form_Closing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            HideForm();
        }
        public void HideForm()
        {
            textBox1.Text = "";
            Hide();
        }

        public void ShowForm()
        {
           
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            bool isParsable = Int32.TryParse(textBox1.Text, out number);

            if (isParsable)
            {
                Bookadministration.UserID = number;
            }
            else
            {
                ErrorWindow.ShowCustomErrorWindow("Es wurde ein Zahlenwert erwartet.", "Eingabe inkorrekt", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
            Close();
        }
    }
}
