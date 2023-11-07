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
    public partial class DeleteAccount : Form
    {
        private SQLiteConnection sql_conn;
        public DeleteAccount()
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

            dgvAccountDelete.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AmendDatabase(string query)
        {
           

            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            sql_cmd.ExecuteNonQuery();
            txtbxID.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtbxID.Text = dgvAccountDelete.SelectedRows[0].Cells[0].Value.ToString();
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

        private void bttnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("You are about to delete an account, are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                string id = txtbxID.Text;
                string deleteStaff = "Delete from Staff where StaffID = '" + id + "'";
                AmendDatabase(deleteStaff);

                string deleteAccount = "Delete from Account where StaffID = '" + id + "'";
                AmendDatabase(deleteAccount);

                LoadData();
            }
            
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' from Staff WHERE StaffID LIKE '%" + txtbxSearch.Text + "%'" + "or firstName LIKE '%" + txtbxSearch.Text + "%'" + "or lastName LIKE '%" + txtbxSearch.Text + "%'";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable dt = new DataTable();
            SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            sql_adapter.Fill(dt);

            dgvAccountDelete.DataSource = dt;
            sql_conn.Close();
        }
    }
}
