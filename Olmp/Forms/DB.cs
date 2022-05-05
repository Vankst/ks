using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;
using OpenXmlPowerTools;

namespace Olmp.Forms
{
    class DB
    {
        public string con = @"Data Source=10.111.105.2,1433\SQLEXPRESS;Initial Catalog=pr-20.102k-chm22;User ID=20.102k-12;Password=SnnmCK12";
        public void SignIn(string login, out string password, out bool pr)
        {
            password = "";
            pr = true;

            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query =  $@"select password from users where login = '{login}';";
                SqlCommand command = new SqlCommand(query, Con);
                password = command.ExecuteScalar().ToString();
                Con.Close();
            }
            if (password == "")
                pr = false;

        }

    }
}
