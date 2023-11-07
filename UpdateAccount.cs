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

namespace HospitalManagementSystem
{
    public partial class UpdateAccount : Form
    {
        private SQLiteConnection sql_conn;
        public UpdateAccount()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' from Staff";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvAccountUpdate.DataSource = dt;
            sql_conn.Close();
        }

        private void Display(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AmendDatabase(string query)
        {
            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();



            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();

            txtbxID.Text = "";
            txtbxDepartment.Text = "";
            txtbxFirstName.Text = "";
            txtbxLastName.Text = "";
            txtbxRole.Text = "";
            txtbxAddress.Text = "";
            txtbxDOB.Text = "";
            txtbxGender.Text = "";
            txtbxNumber.Text = "";
            txtbxEmail.Text = "";
            txtbxQualification.Text = "";
            txtbxSalary.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAccountUpdate.SelectedRows) 
            {
                txtbxID.Text = row.Cells[0].Value.ToString();
                txtbxDepartment.Text = row.Cells[1].Value.ToString();
                txtbxFirstName.Text = row.Cells[2].Value.ToString();
                txtbxLastName.Text = row.Cells[3].Value.ToString();
                txtbxRole.Text = row.Cells[4].Value.ToString();
                txtbxAddress.Text = row.Cells[5].Value.ToString();
                txtbxDOB.Text = row.Cells[6].Value.ToString();
                txtbxGender.Text = row.Cells[7].Value.ToString();
                txtbxNumber.Text = row.Cells[8].Value.ToString();
                txtbxEmail.Text = row.Cells[9].Value.ToString();
                txtbxQualification.Text = row.Cells[10].Value.ToString();
                txtbxSalary.Text = row.Cells[11].Value.ToString();
            }

            //txtbxID.Text = dgvAccountUpdate.SelectedRows[0].Cells[0].Value.ToString();
            //txtbxDepartment.Text = dgvAccountUpdate.SelectedRows[0].Cells[1].Value.ToString();
            //txtbxFirstName.Text = dgvAccountUpdate.SelectedRows[0].Cells[2].Value.ToString();
            //txtbxLastName.Text = dgvAccountUpdate.SelectedRows[0].Cells[3].Value.ToString();
            //txtbxRole.Text = dgvAccountUpdate.SelectedRows[0].Cells[4].Value.ToString();
            //txtbxAddress.Text = dgvAccountUpdate.SelectedRows[0].Cells[5].Value.ToString();
            //txtbxDOB.Text = dgvAccountUpdate.SelectedRows[0].Cells[6].Value.ToString();
            //txtbxGender.Text = dgvAccountUpdate.SelectedRows[0].Cells[7].Value.ToString();
            //txtbxNumber.Text = dgvAccountUpdate.SelectedRows[0].Cells[8].Value.ToString();
            //txtbxEmail.Text = dgvAccountUpdate.SelectedRows[0].Cells[9].Value.ToString();
            //txtbxQualification.Text = dgvAccountUpdate.SelectedRows[0].Cells[10].Value.ToString();
            //txtbxSalary.Text = dgvAccountUpdate.SelectedRows[0].Cells[11].Value.ToString();
        }


        private void bttnLogOut_Click(object sender, EventArgs e)
        {
            LogOut form = new LogOut();
            form.Show();
        }

        private void pcbxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Staff " + "set DepartmentID = '" + txtbxDepartment.Text + "', firstName = '" + txtbxFirstName.Text + "', lastName = '" + txtbxLastName.Text + "', role = '" + txtbxRole.Text
                + "', address = '" + txtbxAddress.Text + "', dob = '" + txtbxDOB.Text + "', gender = '" + txtbxGender.Text + "', phoneNumber = '" + txtbxNumber.Text + "', email = '" + txtbxEmail.Text +
                "', qualification = '" + txtbxQualification.Text + "', salary = '" + txtbxSalary.Text + "' where StaffID = '" + txtbxID.Text + "'";

            AmendDatabase(query);
            LoadData();
        }

        private void bttnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword form = new UpdatePassword();
            form.Show();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' from Staff WHERE StaffID LIKE '%" + txtbxSearch.Text + "%'" + "or firstName LIKE '%" + txtbxSearch.Text + "%'" + "or lastName LIKE '%" + txtbxSearch.Text + "%'";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvAccountUpdate.DataSource = dt;
            sql_conn.Close();
        }

        private void bttnUpdatePw_Click(object sender, EventArgs e)
        {
            UpdatePassword form = new UpdatePassword();
            form.Show();
        }
    }
}
