using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSystem
{
    public partial class LogIn : Form
    {
        private SQLiteConnection sql_conn;

        public LogIn()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e) // https://www.youtube.com/watch?v=n2FWwmgMKok making the login, as I started making the changing password I had to think somehow get the password from the database
        {
            string password = txtbxPassword.Text;
            string username = txtbxUsername.Text;

            sql_conn = new SQLiteConnection(@"data source = FInalHMSystemDB.db");
            sql_conn.Open();

            string query = "Select Account.Password, Staff.role from Account, Staff where Staff.StaffID = '" + username + "' AND Password = '" + password + "'";
            SQLiteCommand sql_cmd = new SQLiteCommand(query, sql_conn);

            DataTable details = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_cmd);
            adapter.Fill(details);
            

            if (details.Rows.Count > 0)
            {
                string info = details.Rows[0].ItemArray[1].ToString();

                if (txtbxUsername.Text == username && txtbxPassword.Text == password && info == "Receptionist")
                {
                    Receptionist form = new Receptionist(txtbxUsername.Text);
                    form.Show();
                    txtbxPassword.Text = "";
                    txtbxUsername.Text = "";
                }


                else if (txtbxUsername.Text == username && txtbxPassword.Text == password && info == "Nurse")
                {
                    Nurse form = new Nurse(txtbxUsername.Text);
                    form.Show();
                    txtbxPassword.Text = "";
                    txtbxUsername.Text = "";
                }

                else if (txtbxUsername.Text == username && txtbxPassword.Text == password && info == "Doctor")
                {
                    Doctor form = new Doctor(txtbxUsername.Text);
                    form.Show();
                    txtbxPassword.Text = "";
                    txtbxUsername.Text = "";
                }

                else if (txtbxUsername.Text == username && txtbxPassword.Text == password && info == "Manager")
                {
                    Manager form = new Manager(txtbxUsername.Text);
                    form.Show();
                    txtbxPassword.Text = "";
                    txtbxUsername.Text = "";
                }

                else if (txtbxUsername.Text == username && txtbxPassword.Text == password && info == "Admin")
                {
                    Admin form = new Admin(txtbxUsername.Text);
                    form.Show();
                    txtbxPassword.Text = "";
                    txtbxUsername.Text = "";
                }
            }

            else
            {
                MessageBox.Show("The username or password is incorrect, try again");
                txtbxPassword.Text = "";
            }


            //else if (txtbxUsername.Text == username && txtbxPassword.Text == password && txtbxUsername.Text.StartsWith("n")) // https://stackoverflow.com/a/33084664 I noticed that as more users would be added, each user shouldnt be typed out separtetly. I tried making a role query but because of the naming i had made for the users i found out how to find a specific letter (in the future with more time i could make it better and have list instead).
            //{
            //    Nurse form = new Nurse(txtbxUsername.Text);
            //    form.Show();
            //    txtbxPassword.Text = "";
            //    txtbxUsername.Text = "";
            //}

            //if (txtbxUsername.Text == "r0001" && txtbxPassword.Text == password)
            //{
            //    Receptionist form = new Receptionist(txtbxUsername.Text);
            //    form.Show();
            //    txtbxPassword.Text = "";
            //    txtbxUsername.Text = "";
            //}

            //else if (txtbxUsername.Text == "n0001" && txtbxPassword.Text == password)
            //{
            //    Nurse form = new Nurse(txtbxUsername.Text);
            //    form.Show();
            //    txtbxPassword.Text = "";
            //    txtbxUsername.Text = "";
            //}

            //else if (txtbxUsername.Text == "d0001" && txtbxPassword.Text == password)
            //{
            //    Doctor form = new Doctor(txtbxUsername.Text);
            //    form.Show();
            //    txtbxPassword.Text = "";
            //    txtbxUsername.Text = "";
            //}

            //else if (txtbxUsername.Text == "m0001" && txtbxPassword.Text == password)
            //{
            //    Manager form = new Manager(txtbxUsername.Text);
            //    form.Show();
            //    txtbxPassword.Text = "";
            //    txtbxUsername.Text = "";
            //}

            //else if (txtbxUsername.Text == "a1" && txtbxPassword.Text == password)
            //{
            //    Admin form = new Admin(txtbxUsername.Text);
            //    form.Show();
            //    txtbxPassword.Text = "";
            //    txtbxUsername.Text = "";
            //}

            //else
            //{
            //    MessageBox.Show("The username or password is incorrect, try again");
            //    txtbxPassword.Text = "";
            //}



            //if (txtbxUsername.Text == "r0001" && txtbxPassword.Text ==  "Lilac9901")
            //{
            //    Receptionist form = new Receptionist(txtbxUsername.Text);
            //    form.Show();
            //    txtbxUsername.Text = "";
            //    txtbxPassword.Text = "";

            //}

            //else if (txtbxUsername.Text == "n0001" && txtbxPassword.Text == "Burgundy0092")
            //{
            //    Nurse form = new Nurse(txtbxUsername.Text);
            //    form.Show();
            //    txtbxUsername.Text = "";
            //    txtbxPassword.Text = "";
            //}

            //else if (txtbxUsername.Text == "d0001" && txtbxPassword.Text == "Olive1934")
            //{
            //    Doctor form = new Doctor(txtbxUsername.Text);
            //    form.Show();
            //    txtbxUsername.Text = "";
            //    txtbxPassword.Text = "";
            //}

            //else if (txtbxUsername.Text == "m0001" && txtbxPassword.Text == "Scarlet8862")
            //{
            //    Manager form = new Manager(txtbxUsername.Text);
            //    form.Show();
            //    txtbxUsername.Text = "";
            //    txtbxPassword.Text = "";
            //}

            //else if (txtbxUsername.Text == "a1" && txtbxPassword.Text == "Violet2019")
            //{
            //    Admin form = new Admin(txtbxUsername.Text);
            //    form.Show();
            //    txtbxUsername.Text = "";
            //    txtbxPassword.Text = "";
            //}

            //else
            //{
            //    MessageBox.Show("The username or password is incorrect, try again");
            //    txtbxUsername.Text = "";
            //    txtbxPassword.Text = "";
            //}
        }

        private void pcbxSeePassword_Click(object sender, EventArgs e) // https://www.youtube.com/watch?v=iD17cWr10Js
        {
            if (txtbxPassword.PasswordChar == '*')
            {
                pcbxHidePassword.BringToFront();
                txtbxPassword.PasswordChar = '\0';
            }
        }

        private void pcbxHidePassword_Click(object sender, EventArgs e)
        {
            if (txtbxPassword.PasswordChar == '\0')
            {
                pcbxSeePassword.BringToFront();
                txtbxPassword.PasswordChar = '*';
            }
        }
    }
}
