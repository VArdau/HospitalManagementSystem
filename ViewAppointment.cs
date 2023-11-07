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
    public partial class ViewAppointment : Form
    {
        private SQLiteConnection sql_conn;
        string username = "";
        public ViewAppointment(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadData();
        }


        private void LoadData()
        {
            SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            //string date = DateTime.Now.ToString();

            string query = "SELECT AppointmentID, StaffID AS 'Staff', PatientID AS 'Patient', date AS 'Date', timeSlots As 'Time' from Appointment WHERE StaffID = '" + username + "' ORDER BY date DESC ";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvViewAppointment.DataSource = dt;
            sql_conn.Close();
        }

        private void Display(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pcbxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string query = "SELECT AppointmentID, StaffID AS 'Staff', PatientID AS 'Patient', date AS 'Date', timeSlots As 'Time' from Appointment WHERE PatientID LIKE '%" + txtbxSearch.Text + "%' AND StaffID = '" + username + "' ORDER BY date DESC ";


            
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvViewAppointment.DataSource = dt;
            sql_conn.Close();
        }
    }
}
