﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.View
{
    public partial class BookLendView : Form
    {
        private LendController Controller { get; }
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";
        DataTable table = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };
        public BookLendView(LendController controller)
        {
            this.FormClosing += new FormClosingEventHandler(this.onClose);
            Visible = false;
            InitializeComponent();
            Controller = controller;
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            CreateTable();
            GetData();
        }
        private void CreateTable()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM Users", connectionString);
            dataAdapter.Fill(table);
            addButton("Auswählen");
            table.Columns.Add("_RowString", typeof(string));
            dataGridView1.Columns["EncryptedPW"].Visible = false;
            dataGridView1.Columns["_RowString"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
        }
        public void HideForm()
        {
            Hide();
        }
        public void ShowForm(string iSBN, string inventoryNumber)
        {
            Show();
            this.label2.Text = iSBN;
            this.label4.Text = inventoryNumber;
            GetData();
        }
        private void addButton(string buttonName)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = buttonName;
            button.Text = buttonName;
            if (dataGridView1.Columns[buttonName] == null)
            {
                dataGridView1.Columns.Add(button);
            }
        }
        private int HeaderPosition(string value)
        {
            return dataGridView1.Columns[value].Index;
        }
        private void GetData()
        {
            try
            {
                table.Clear();
                dataAdapter = new SqlDataAdapter("SELECT * FROM Users", connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(table);
                // Add additional column for filtering
                foreach (DataRow dataRow in table.Rows)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < table.Columns.Count - 1; i++)
                    {
                        // Exclude EncryptedPW while String build
                        if (HeaderPosition("EncryptedPW") != i)
                        {
                            sb.Append(dataRow[i].ToString());
                            sb.Append("\t");
                        }
                    }
                    dataRow["_RowString"] = sb.ToString();
                }
                // Resize the DataGridView columns to fit the newly loaded content
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException)
            {
                MessageBox.Show("User wurde nicht gefunden");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int userId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[HeaderPosition("UserID")].Value.ToString());
            int man = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[HeaderPosition("MANumber")].Value.ToString());
            if (e.ColumnIndex == HeaderPosition("Auswählen"))
            {
                Controller.Lend(label2.Text, label4.Text, userId, man);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetData();
            if (textBox1.Text != "Suche") table.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", textBox1.Text);
        }
        private void textBox1_Clicked(object sender, EventArgs e)
        {
            if (textBox1.Text == "Suche") textBox1.Text = "";
        }
        public void RefreshData()
        {
            GetData();
        }
        public void onClose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Controller.HideForm();
        }
    }
}
