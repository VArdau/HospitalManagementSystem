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
    public partial class CreateAccount : Form
    {

        private SQLiteConnection sql_conn;

        public CreateAccount()
        {
            InitializeComponent();
        }

        

        private void AmendDatabase(string query)
        {
            SQLiteConnection sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);


            sql_cmd.ExecuteNonQuery();
            txtbxID.Text = "";
            cbxDepartment.Text = "";
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

        //private void bttnLogOut_Click(object sender, EventArgs e)
        //{
        //    LogOut form = new LogOut();
        //    form.Show();
        //}

        //private void pcbxReturn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void bttnCreate_Click(object sender, EventArgs e)
        {

            string query = "Insert into Staff (StaffID, DepartmentID, firstName, lastName, role, address, dob, gender, phoneNumber, email, qualification, salary) values ('" + txtbxID.Text + "', '" + cbxDepartment.Text + "', '"
            + txtbxFirstName.Text + "', '" + txtbxLastName.Text + "', '" + txtbxRole.Text + "', '" + txtbxAddress.Text + "', '" + txtbxDOB.Text + "', '" + txtbxGender.Text + "'" +
            ", '" + txtbxNumber.Text + "', '" + txtbxEmail.Text + "', '" + txtbxQualification.Text + "', '" + txtbxSalary.Text + "');";

            AmendDatabase(query);
            //LoadData();
            MessageBox.Show("An account has been created.");
        }

        private void bttnCreateLogin_Click(object sender, EventArgs e)
        {
            CreateLogin form = new CreateLogin();
            form.Show();
        }

        private void bttnCreatePw_Click(object sender, EventArgs e)
        {
            CreateLogin form = new CreateLogin();
            form.Show();
        }
    }
}
