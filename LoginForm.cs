using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = mailtxt.Text;
            string password = passtxt.Text;

            User user = new User();
            bool loginSuccessful = user.Login(email, password);

            if (loginSuccessful)
            {
                // Close the login form or navigate to another form
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
