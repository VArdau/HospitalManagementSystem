﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Manager : Form
    {
        private SQLiteConnection sql_conn;
        public Manager(String username)
        {
            InitializeComponent();
            lblName.Text = username;
        }

        private void bttnLogOut_Click(object sender, EventArgs e)
        {
            LogOut form = new LogOut();
            form.Show();
        }

        private void bttnViewEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee form = new ViewEmployee(lblName.Text);
            form.Show();
        }

        private void bttnUpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee form = new UpdateEmployee(lblName.Text);
            form.Show();
        }

        private void pcbxMenu_Click(object sender, EventArgs e)
        {
            //panOptions.Visible = true;

            if (panOptions.Visible == true)
            {
                panOptions.Visible = false;
                panPassword.Visible = false;
            }
            else
            {
                panOptions.Visible = true;
            }
        }

        private void bttnUpdatePassword_Click(object sender, EventArgs e)
        {
            //panPassword.Visible = true;

            if (panPassword.Visible == true)
            {
                panPassword.Visible = false;
            }
            else
            {
                panPassword.Visible = true;
            }
        }

        private void AmendDatabase(string query)
        {
            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            sql_cmd.ExecuteNonQuery();

            sql_conn.Close();

            txtbxID.Text = "";
            txtbxPassword.Text = "";
            txtbxRepeat.Text = "";
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbxID.Text == lblName.Text && txtbxPassword.Text == txtbxRepeat.Text)
            {
                string query = "Update Account " + "set Password = '" + txtbxPassword.Text + "' where StaffID = '" + txtbxID.Text + "'";
                AmendDatabase(query);

                MessageBox.Show("Updated password");
            }

            else if (txtbxID.Text == lblName.Text && txtbxPassword.Text != txtbxRepeat.Text)
            {
                MessageBox.Show("The passwords dont match");
                txtbxRepeat.Text = "";
            }

            else
            {
                MessageBox.Show("Your username is incorrect.");
                txtbxPassword.Text = "";
                txtbxID.Text = "";
                txtbxRepeat.Text = "";
            }
        }
    }
}