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
    public partial class CreateLogin : Form
    {
        public CreateLogin()
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
            txtbxPassword.Text = "";
        }

        private void bttnCreateLogin_Click(object sender, EventArgs e)
        {
            string query = "Insert into Account (StaffID, Password) values ('" + txtbxID.Text + "', '" + txtbxPassword.Text + "');";

            AmendDatabase(query);
            MessageBox.Show("A login has been made.");
            //LoadData();

        }
    }
}
