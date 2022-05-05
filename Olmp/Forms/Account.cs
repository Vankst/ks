using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Olmp.Forms;

namespace Olmp
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        public static string login;
        private void Account_Load(object sender, EventArgs e)
        {
           
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            lbl_hi.Text = "Добро";
            if (hours > 6 && hours < 11)
                lbl_hi.Text += "е утро";
            else if (hours >= 12 && hours < 18)
                lbl_hi.Text += "го дня";
            else if (hours >= 18 && hours <= 22)
                lbl_hi.Text += "го вечера";
            else
                lbl_hi.Text += "й ночи";
            lbl_hi.Text += ", " + login;

        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.login = login;
            Main.SignIN = true;
            main.Show();
            this.Close();
        }

      

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.SignIN = false;
            Main.login = string.Empty;
            main.Show();
            this.Close();
        }

        private void btn_tablelist_Click(object sender, EventArgs e)
        {
            TableList tL = new TableList();
            TableList.login = login;
            tL.Show();
            this.Close();
           
        }
    }
}
