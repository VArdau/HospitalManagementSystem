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
    public partial class UpdatePassword : Form
    {
        private SQLiteConnection sql_conn;

        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void AmendDatabase(string query)
        {
            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);
            sql_cmd.ExecuteNonQuery();

            sql_conn.Close();

            txtbxID.Text = "";
            txtbxPassword.Text = "";
        }

        private void bttnUpdatePassword_Click(object sender, EventArgs e)
        {
            string query = "Update Account " + "set Password = '" + txtbxPassword.Text + "' where StaffID = '" + txtbxID.Text + "'";
            AmendDatabase(query);

            MessageBox.Show("Updated password");

        }
    }
}
