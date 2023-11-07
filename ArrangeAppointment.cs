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
    public partial class ArrangeAppointment : Form
    {
        public ArrangeAppointment()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            string query = "SELECT AppointmentID, StaffID AS 'Staff', PatientID AS 'Patient', date AS 'Date', timeSlots As 'Time' from Appointment";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvCreateAppointment.DataSource = dt;
            sql_conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AmendDatabase(string query)
        {
            SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();

            txtbxStaff.Text = "";
            txtbxPatient.Text = "";
            txtbxDate.Text = "";
            cbxTime.Text = "";
        }

        private void bttnCreate_Click(object sender, EventArgs e)
        {
            string query = "Insert into Appointment (StaffID, PatientID, date, timeSlots) values ('" + txtbxStaff.Text + "', '" + txtbxPatient.Text + "', '" + txtbxDate.Text + "', '" + cbxTime.Text + "');";

            AmendDatabase(query);
            LoadData();
            MessageBox.Show("An appointment has been made.");
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
    }
}
