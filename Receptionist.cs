using System.Data.SQLite;

namespace HospitalManagementSystem
{
    public partial class Receptionist : Form
    {
        private SQLiteConnection sql_conn;

        public Receptionist(String username)
        {
            InitializeComponent();
            lblName.Text = username;
        }

        private void bttnLogOut_Click(object sender, EventArgs e)
        {
            LogOut form = new LogOut();
            form.Show();
        }

        private void bttnViewP_Click(object sender, EventArgs e)
        {
            ViewPatient form = new ViewPatient();
            form.Show();
        }

        private void bttnCreateP_Click(object sender, EventArgs e)
        {
            CreatePatient form = new CreatePatient();
            form.Show();
        }

        private void bttnUpdateP_Click(object sender, EventArgs e)
        {
            UpdatePatients form = new UpdatePatients();
            form.Show();
        }

        

        private void bttnArrangeA_Click(object sender, EventArgs e)
        {
            ArrangeAppointment form = new ArrangeAppointment();
            form.Show();
        }

        private void pcbxMenu_Click(object sender, EventArgs e)
        {
            if (panOptions.Visible == true)
            {
                panOptions.Visible = false;
                panPassword.Visible = false;
            }
            else
            {
                panOptions.Visible = true;
            }
        }

        private void bttnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (panPassword.Visible == true)
            {
                panPassword.Visible = false;
            }
            else
            {
                panPassword.Visible = true;
            }
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
            txtbxRepeat.Text = "";
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbxID.Text == lblName.Text && txtbxPassword.Text == txtbxRepeat.Text)
            {
                string query = "Update Account " + "set Password = '" + txtbxPassword.Text + "' where StaffID = '" + txtbxID.Text + "'";
                AmendDatabase(query);

                MessageBox.Show("Updated password");
            }

            else if (txtbxID.Text == lblName.Text && txtbxPassword.Text != txtbxRepeat.Text)
            {
                MessageBox.Show("The passwords dont match");
                txtbxRepeat.Text = "";
            }

            else
            {
                MessageBox.Show("Your username is incorrect.");
                txtbxPassword.Text = "";
                txtbxID.Text = "";
                txtbxRepeat.Text = "";
            }
        }
    }
}