using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Olmp.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            bool pr = true;
            string password = "";
            if (tb_login.Text == String.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите email";
                return;
            }
            else if (tb_password.Text == String.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите пароль";
                return;

            }
            else
            {
                DB dB = new DB();
                dB.SignIn(tb_login.Text, out password, out pr);
                if (tb_password.Text == password && pr == true)
                {
                    Account account = new Account();
                    Account.login = tb_login.Text;
                    Main main = new Main();
                    Main.SignIN = true;
                    Main.login = tb_login.Text;
                    account.Show();
                    this.Hide();
            }
                else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Неправильный логин или пароль";
            }
        }
        }

        //public string CreateMD5Hash(string input)
        //{

        //    MD5 md5 = MD5.Create();
        //    byte[] inputBytes = Encoding.ASCII.GetBytes(input);
        //    byte[] hashBytes = md5.ComputeHash(inputBytes);
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < hashBytes.Length; i++)
        //    {
        //        sb.Append(hashBytes[i].ToString("X2"));
        //    }
        //    return sb.ToString();
        //}
        //static bool IsEmail(string email)
        //{
        //    string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
        //    if (Regex.IsMatch(email, cond))
        //        return true;
        //    else 
        //        return false;

        //}

        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
