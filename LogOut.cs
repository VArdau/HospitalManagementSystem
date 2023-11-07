using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //LogIn form = new LogIn();
            //form.Show();
            //System.Windows.Forms.Application.Exit();

            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "LogIn") thisForm.Close();
            } // https://stackoverflow.com/a/9029732 wanted to close all forms apart from the log in, i had tried many things but nothing worked the way i wanted it to
        }

        private void bttnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
