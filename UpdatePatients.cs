using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HospitalManagementSystem
{
    public partial class UpdatePatients : Form
    {
        private SQLiteConnection sql_conn;
        public UpdatePatients()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            string query = "SELECT PatientID AS 'Patient', firstName AS 'First name', lastName 'Last name', address AS 'Address', dob AS 'DOB', gender AS 'Gender', bloodType AS 'Bloody Type', phoneNumber AS 'Phone Number', extraPhoneNumber AS 'Extra Phone Number', email AS 'Email' FROM Patient";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvPatientUpdate.DataSource = dt;
        }

        private void Display(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AmendDatabase(string query)
        {
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            sql_cmd.ExecuteNonQuery();
            txtbxID.Text = "";
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //////if (dgvPatientUpdate.SelectedRows.Count == 0) //so you dont crash when you click things
            //////    return;

            //if (dgvPatientUpdate.SelectedRows[1].SetValues(ToString()))
            //{
            //    return;
            //}

            foreach (DataGridViewRow row in dgvPatientUpdate.SelectedRows) // https://stackoverflow.com/a/11293450 now it wouldnt crash if selected a different row. However the top center still crashes if clicked
            {
                txtbxID.Text = row.Cells[0].Value.ToString();
                txtbxFirstName.Text = row.Cells[1].Value.ToString();
                txtbxLastName.Text = row.Cells[2].Value.ToString();
                txtbxAddress.Text = row.Cells[3].Value.ToString();
                txtbxDOB.Text = row.Cells[4].Value.ToString();
                txtbxGender.Text = row.Cells[5].Value.ToString();
                txtbxBloodType.Text = row.Cells[6].Value.ToString();
                txtbxNumber.Text = row.Cells[7].Value.ToString();
                txtbxExtraNumber.Text = row.Cells[8].Value.ToString();
                txtbxEmail.Text = row.Cells[9].Value.ToString();

                //string y = row.Cells[null].ToString();

                ////string y = row.Cells[-1].Value.ToString();

                //if (row.Equals(y))
                //{
                //    break;
                //}

                //else
                //{
                //    break;
                //}
            }

            //txtbxID.Text = dgvPatientUpdate.SelectedRows[0].Cells[0].Value.ToString();
            //txtbxFirstName.Text = dgvPatientUpdate.SelectedRows[0].Cells[1].Value.ToString();
            //txtbxLastName.Text = dgvPatientUpdate.SelectedRows[0].Cells[2].Value.ToString();
            //txtbxAddress.Text = dgvPatientUpdate.SelectedRows[0].Cells[3].Value.ToString();
            //txtbxDOB.Text = dgvPatientUpdate.SelectedRows[0].Cells[4].Value.ToString();
            //txtbxGender.Text = dgvPatientUpdate.SelectedRows[0].Cells[5].Value.ToString();
            //txtbxBloodType.Text = dgvPatientUpdate.SelectedRows[0].Cells[6].Value.ToString();
            //txtbxNumber.Text = dgvPatientUpdate.SelectedRows[0].Cells[7].Value.ToString();
            //txtbxExtraNumber.Text = dgvPatientUpdate.SelectedRows[0].Cells[8].Value.ToString();
            //txtbxEmail.Text = dgvPatientUpdate.SelectedRows[0].Cells[9].Value.ToString();


            //if (dgvPatientUpdate.CurrentCell == null || e.RowIndex == -1)
            //{
            //    return;
            //}
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            // (PatientID, firstName, lastName, address, dob, gender, religion, bloodType, phoneNumber, extraPhoneNumber, email) 

            string query = "Update Patient " + "set firstName = '" + txtbxFirstName.Text + "', lastName = '" + txtbxLastName.Text + "', address = '" + txtbxAddress.Text + "', dob = '" + txtbxDOB.Text
                + "', gender = '" + txtbxGender.Text + "', bloodType = '" + txtbxBloodType.Text + "', phoneNumber = '" + txtbxNumber.Text + "', extraPhoneNumber = '"
                + txtbxExtraNumber.Text + "', email = '" + txtbxEmail.Text + "' where PatientID = '" + txtbxID.Text + "'";

            AmendDatabase(query);
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
            //string query = "select * from Patient WHERE PatientID LIKE '%" + txtbxSearch.Text + "%'"; // want to have multiple 
            string query = "SELECT PatientID AS 'Patient', firstName AS 'First name', lastName 'Last name', address AS 'Address', dob AS 'DOB', gender AS 'Gender', bloodType AS 'Bloody Type', phoneNumber AS 'Phone Number', extraPhoneNumber AS 'Extra Phone Number', email AS 'Email' FROM Patient WHERE PatientID LIKE '%" + txtbxSearch.Text + "%'" + "or firstName LIKE '%" + txtbxSearch.Text + "%'" + "or lastName LIKE '%" + txtbxSearch.Text + "%'";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvPatientUpdate.DataSource = dt;
            sql_conn.Close();
        }
    }
}
