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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagementSystem
{
    public partial class ViewEmployee : Form
    {
        private SQLiteConnection sql_conn;
        string username;
        public ViewEmployee(string username)
        {
            InitializeComponent();
            //lblUsername.Text = username;
            this.username = username;
        }

        private void bttnLogOut_Click(object sender, EventArgs e)
        {
            LogOut form = new LogOut();
            form.Show();
        }


        private void LoadData()
        {

            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();
            string queryD = "Select * From Staff WHERE StaffID = '" + username + "'";
            SQLiteCommand sql_cmd = new SQLiteCommand(queryD, sql_conn);

            DataTable details = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_cmd);
            adapter.Fill(details);
            string info = details.Rows[0].ItemArray[1].ToString();

            foreach (object dept in info) // used a foreach so it practical now
            {
                dept.ToString();

                string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', " +
                    "dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' FROM Staff WHERE DepartmentID = '" + info + "'";

                SQLiteCommand cmd = new SQLiteCommand(query, sql_conn);

                DataTable dt = new DataTable();
                SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(cmd);
                sql_adapter.Fill(dt);

                dgvEmployeeView.DataSource = dt;
                sql_conn.Close();
            }


            //// while its working its going to get messy when more departments are made, also making a label seems odd but its the only way i could figure how to do it.
            //sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            //sql_conn.Open();
            //string queryD = "Select * From Staff WHERE StaffID = '" + lblUsername.Text + "'";
            //SQLiteCommand sql_cmd = new SQLiteCommand(queryD, sql_conn);

            //DataTable details = new DataTable();
            //SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_cmd);
            //adapter.Fill(details);
            //string info = details.Rows[0].ItemArray[1].ToString();

            //if (info == "Cardiology")
            //{
            //    string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', " +
            //        "dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' FROM Staff WHERE DepartmentID = 'Cardiology'";

            //    SQLiteCommand cmd = new SQLiteCommand(query, sql_conn);

            //    DataTable dt = new DataTable();
            //    SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(cmd);
            //    sql_adapter.Fill(dt);

            //    dgvEmployeeView.DataSource = dt;
            //    sql_conn.Close();
            //}

            //else if (info == "Hematology")
            //{
            //    string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', " +
            //        "dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' FROM Staff WHERE DepartmentID = 'Cardiolog'";

            //    SQLiteCommand cmd = new SQLiteCommand(query, sql_conn);

            //    DataTable dt = new DataTable();
            //    SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(cmd);
            //    sql_adapter.Fill(dt);

            //    dgvEmployeeView.DataSource = dt;
            //    sql_conn.Close();
            //}



            // first attempt - bad because i just noticed i have to specify department
            // SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            // sql_conn.Open();

            // string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', " +
            //     "dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' FROM Staff WHERE DepartmentID = 'Cardiology'";

            //// "select staff.firstName, staff.lastName, DepartmentTeam.DepartmentTeamID, Department.DepartmentID from staff inner join DepartmentTeam on (Staff.StaffID = DepartmentTeam.StaffID) " +
            ////     "inner join Department on (Staff.DepartmentID = Department.DepartmentID);";
            // SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            // DataTable dt = new DataTable();
            // SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            // sql_adapter.Fill(dt);

            // dgvEmployeeView.DataSource = dt;
            // sql_conn.Close();


        }



        private void Display(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pcbxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {

            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();
            string queryD = "Select * From Staff WHERE StaffID = '" + username + "'";
            SQLiteCommand sql_cmd = new SQLiteCommand(queryD, sql_conn);

            DataTable details = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_cmd);
            adapter.Fill(details);
            string info = details.Rows[0].ItemArray[1].ToString();

            foreach (object dept in info) 
            {
                dept.ToString();

                string query = "SELECT StaffID AS 'Staff', DepartmentID AS 'Department', firstName AS 'Firstname', lastName AS 'Lastname', role AS 'Role', address AS 'Address', " +
                    "dob AS 'DOB', gender AS 'Gender', phoneNumber AS 'Phone Number', email AS 'Email', qualification AS 'Qualification', salary AS 'Salary' FROM Staff WHERE" +
                    " StaffID LIKE '%" + txtbxSearch.Text + "%'" + "or firstName LIKE '%" + txtbxSearch.Text + "%'" + "or lastName LIKE '%" + txtbxSearch.Text + "%'" + "AND DepartmentID = '" + info + "'";

                SQLiteCommand cmd = new SQLiteCommand(query, sql_conn);

                DataTable dt = new DataTable();
                SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(cmd);
                sql_adapter.Fill(dt);

                dgvEmployeeView.DataSource = dt;
                sql_conn.Close();
            }


            // because didnt have load needed to do this connection to be able to load
            //    sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            //    sql_conn.Open();

            //    string query = "select * from Staff WHERE StaffID LIKE '%" + txtbxSearch.Text + "%'" + "or firstName LIKE '%" + txtbxSearch.Text + "%'" + "or lastName LIKE '%" + txtbxSearch.Text + "%'" + "AND DepartmentID = 'Cardiology'";
            //    SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            //    DataTable dt = new DataTable();
            //    SQLiteDataAdapter sql_adapter = new SQLiteDataAdapter(sql_cmd);
            //    sql_adapter.Fill(dt);

            //    dgvEmployeeView.DataSource = dt;
            //    sql_conn.Close();
            //}
        }
    }
}
