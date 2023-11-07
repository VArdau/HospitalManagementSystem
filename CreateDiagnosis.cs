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
    public partial class CreateDiagnosis : Form
    {
        string username;
        public CreateDiagnosis(string username)
        {
            InitializeComponent();
            this.username = username;
            txtbxSID.Text = username;
        }

        private void AmendDatabase(string queryOne, string queryTwo)
        {
            
            string query = queryOne + queryTwo; 
            SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            sql_cmd.ExecuteNonQuery();
            txtbxSID.Text = username;
            txtbxPID.Text = "";
            txtbxAID.Text = "";
            txtbxDetails.Text = "";
            txtbxDate.Text = "";
            txtbxName.Text = "";
            txtbxDosage.Text = "";
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

        private void bttnCreateDiagnosis_Click(object sender, EventArgs e)
        {
            string queryDiagnosis = "Insert into Diagnosis (StaffID, PatientID, AppointmentID, details, date) values ('" + username + "', '" + txtbxPID.Text + "', '" + txtbxAID.Text + "', '" + txtbxDetails.Text + "', '" + txtbxDate.Text + "' );";

            string queryMedication = "Insert into Medication (StaffID, PatientID, name, dosage, date) values ('" + username + "', '" + txtbxPID.Text + "', '" + txtbxName.Text + "', '" + txtbxDosage.Text + "', '" + txtbxDate.Text + "');";

            AmendDatabase(queryDiagnosis, queryMedication);
            MessageBox.Show("A diagnosis entry has been made.");
        }
    }
}
