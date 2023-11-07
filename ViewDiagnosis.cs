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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagementSystem
{
    public partial class ViewDiagnosis : Form
    {
        private SQLiteConnection sql_conn;
        string username;
        public ViewDiagnosis(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void LoadData()
        {

            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();
            string queryD = "Select * From Staff WHERE StaffID = '" + username + "'";
            SQLiteCommand sql_cmd = new SQLiteCommand(queryD, sql_conn);

       
            string query = "SELECT Diagnosis.DiagnosisID, Diagnosis.StaffID AS 'Staff', Diagnosis.PatientID AS 'Patient', Diagnosis.AppointmentID, Diagnosis.details AS 'Details', Diagnosis.date AS 'Date', Medication.MedicationID, Medication.name AS 'Name', " +
                       "Medication.dosage AS 'Dosage' FROM Diagnosis LEFT JOIN Medication on Diagnosis.StaffID = Medication.StaffID AND Diagnosis.PatientID = Medication.PatientID And Diagnosis.DiagnosisID = Medication.DiagnosisID WHERE Diagnosis.StaffID = '" + username + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(cmd);
            sql_adapter.Fill(dt);

            dgvDiagnosisView.DataSource = dt;
            sql_conn.Close();
            

            //    SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            //    sql_conn.Open();

            //    //string query = "select * From Diagnosis, Medication WHERE Diagnosis.StaffID = 'd0001'";
            //    // make AS
            //    // the query doubles the output
            //    //string query = "select Diagnosis.DiagnosisID, Diagnosis.StaffID, Diagnosis.PatientID, Diagnosis.AppointmentID, Diagnosis.details, Diagnosis.date, Medication.MedicationID, Medication.name, Medication.dosage FROM Diagnosis, Medication WHERE Diagnosis.StaffID = 'd0001'";
            //    string query = "SELECT Diagnosis.DiagnosisID, Diagnosis.StaffID AS 'Staff', Diagnosis.PatientID AS 'Patient', Diagnosis.AppointmentID, Diagnosis.details AS 'Details', Diagnosis.date AS 'Date', Medication.MedicationID, Medication.name AS 'Name', " +
            //        "Medication.dosage AS 'Dosage' FROM Diagnosis LEFT JOIN Medication on Diagnosis.StaffID = Medication.StaffID AND Diagnosis.PatientID = Medication.PatientID WHERE Diagnosis.StaffID = 'd0001'";
            //    // https://www.w3schools.com/sql/sql_join_left.asp and https://learnsql.com/blog/get-rid-of-duplicates-sql-join/#:~:text=Using%20an%20Incomplete%20ON%20Condition,it%20results%20in%20duplicate%20rows.
            //    SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            //    //SQLiteCommand sql_cmd2 = new SQLiteCommand(query2, sql_conn);

            //    DataTable dt = new DataTable();
            //    SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            //    sql_adapter.Fill(dt);

            //    dgvDiagnosisView.DataSource = dt;
            //    sql_conn.Close();
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
            string query = "SELECT Diagnosis.DiagnosisID, Diagnosis.StaffID AS 'Staff', Diagnosis.PatientID AS 'Patient', Diagnosis.AppointmentID, Diagnosis.details AS 'Details', Diagnosis.date AS 'Date', Medication.MedicationID, Medication.name AS 'Name', " +
                       "Medication.dosage AS 'Dosage' FROM Diagnosis LEFT JOIN Medication on Diagnosis.StaffID = Medication.StaffID AND Diagnosis.PatientID = Medication.PatientID AND Diagnosis.PatientID = Medication.PatientID And Diagnosis.DiagnosisID = Medication.DiagnosisID WHERE Diagnosis.PatientID LIKE '%" + txtbxSearch.Text + "%' AND Diagnosis.StaffID = '" + username + "'";
            

            //string query = "select * from Patient WHERE PatientID LIKE '%" + txtbxSearch.Text + "%'" + "or firstName LIKE '%" + txtbxSearch.Text + "%'" + "or lastName LIKE '%" + txtbxSearch.Text + "%'";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvDiagnosisView.DataSource = dt;
            sql_conn.Close();
        }
    }
}
