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
    public partial class ViewPatient : Form
    {

        private SQLiteConnection sql_conn;
        public ViewPatient()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            string query = "SELECT PatientID AS 'Patient', firstName AS 'First name', lastName 'Last name', address AS 'Address', dob AS 'DOB', gender AS 'Gender', bloodType AS 'Bloody Type', phoneNumber AS 'Phone Number', extraPhoneNumber AS 'Extra Phone Number', email AS 'Email' FROM Patient";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvPatientView.DataSource = dt;
        }

        private void AmendDatabase(string query)
        {
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            sql_cmd.ExecuteNonQuery();
        }

        

        private void Display(object sender, EventArgs e)
        {
            LoadData();
        }


        private void bttnLogOut_Click(object sender, EventArgs e)
        {
            LogOut form = new LogOut();
            form.Show();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            string query = "SELECT PatientID AS 'Patient', firstName AS 'First name', lastName 'Last name', address AS 'Address', dob AS 'DOB', gender AS 'Gender', bloodType AS 'Bloody Type', phoneNumber AS 'Phone Number', extraPhoneNumber AS 'Extra Phone Number', email AS 'Email' FROM Patient WHERE PatientID LIKE '%" + txtbxSearch.Text + "%'" + "or firstName LIKE '%" + txtbxSearch.Text + "%'" + "or lastName LIKE '%" + txtbxSearch.Text + "%'";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvPatientView.DataSource = dt;
            sql_conn.Close();
        }

        private void pcbxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnLogOut_Click_1(object sender, EventArgs e)
        {
            LogOut form = new LogOut();
            form.Show();
        }
    }
}
