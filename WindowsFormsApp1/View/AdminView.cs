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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Library_Admin : Form
    {
        private AdminController Controller { get; }
        private WindowsFormsApp1.Model.AdminModel Model { get; }
       
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable table1 = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };
        DataTable table2 = new DataTable { Locale = System.Globalization.CultureInfo.InvariantCulture };

        private bool first_load = true;


        public Library_Admin(AdminController controller)
        {
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
            RefreshData();
            Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Buecher();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller.User();
        }

        private void GetData(string selectCommand, DataGridView dgv, BindingSource bs, DataTable table)
        {
            try
            {
                table.Clear();

                String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Librators.mdf;Integrated Security=True";
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                if (first_load)
                {
                    DataColumn dcRowString = table.Columns.Add("_RowString", typeof(string));
                    foreach (DataRow dataRow in table.Rows)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < table.Columns.Count - 1; i++)
                        {
                            sb.Append(dataRow[i].ToString());
                            sb.Append("\t");
                        }
                        dataRow[dcRowString] = sb.ToString();
                    }
                    //first_load = false;
                }
                first_load = false;
                // Hide filter string column

                dataAdapter.Fill(table);

                bs.DataSource = table;
                
                if (dgv == dataGridView1)
                {
                    dgv.Columns["IssueID"].Visible = false;
                    dgv.Columns["_RowString"].Visible = false;

                }
                else
                {
                    dgv.Columns["ReservationsID"].Visible = false;
                }
                
                dgv.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException)
            {
                MessageBox.Show("Aktuell sind keine Bücher ausgeliehen.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          /* dataGridView1.DataSource = bindingSource1;
           GetData("select * from Issues;", dataGridView1, bindingSource1, table1);
            dataGridView2.DataSource = bindingSource2;
            GetData("select * from Reservations;", dataGridView2, bindingSource2, table2);*/

        }

        private void Search_txb_TextChanged(object sender, EventArgs e)
        {
            //hier
            if (Search_txb.Text != "Suche" || Search_txb.Text != "") table1.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", Search_txb.Text);

        }
        private void RefreshData()
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Issues;", dataGridView1, bindingSource1, table1);

            dataGridView2.DataSource = bindingSource2;
            GetData("select * from Reservations;", dataGridView2, bindingSource2, table2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideForm();
            var loginController = ControllerManager.Get<LoginController>();
            loginController.ClearForm();
            loginController.ShowForm();
        }
        private void AdminView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.CloseProgram();
        }
    }
}
