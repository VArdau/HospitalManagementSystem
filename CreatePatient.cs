using System;
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
    public partial class CreatePatient : Form
    {
        private SQLiteConnection sql_conn;
        public CreatePatient()
        {
            InitializeComponent();
        }


        private void AmendDatabase(string query)
        {
            SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();

            txtbxFirstName.Text = "";
            txtbxLastName.Text = "";
            txtbxAddress.Text = "";
            txtbxDOB.Text = "";
            txtbxGender.Text = "";
            txtbxBloodType.Text = "";
            txtbxNumber.Text = "";
            txtbxExtraNumber.Text = "";
            txtbxEmail.Text = "";
        }

        private void bttnCreate_Click(object sender, EventArgs e)
        {
            string query = "Insert into Patient (firstName, lastName, address, dob, gender,  bloodType, phoneNumber, extraPhoneNumber, email) values ( '"
            + txtbxFirstName.Text + "', '" + txtbxLastName.Text + "', '" + txtbxAddress.Text + "', '" + txtbxDOB.Text + "', '" + txtbxGender.Text + "'" +
            ",'" + txtbxBloodType.Text + "', '" + txtbxNumber.Text + "', '" + txtbxExtraNumber.Text + "', '" + txtbxEmail.Text +"');";

            //lblCreated.Text = "Created";
            AmendDatabase(query);
            MessageBox.Show("A patient has been created.");
        }

        //private void pcbxReturn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void bttnLogOut_Click(object sender, EventArgs e)
        //{
        //    LogOut form = new LogOut();
        //    form.Show();
        //}
    }
}
