using Olmp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olmp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static bool SignIN;
        public static string login;
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void btn_PersonalArea_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            SignIN = false;
            login = string.Empty;
            btn_signin.Visible = true;
            btn_signup.Visible = true;
            btn_PersonalArea.Visible = false;
            btn_exit.Visible = false;
        }

        private void btn_main_Click(object sender, EventArgs e)
        {

        }
    }
}
