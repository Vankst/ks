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

        public void addSotr(string name, string surname, string patronymic, string numb_phone, string bank, string sex, string passport, string inn, string position)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"insert into Сотрудники(Имя, Фамилия, Отчество) values ('{name}', '{surname}', '{patronymic}');";
                string query2 = $"insert into [Информация о сотрудниках]([Номер телефона],[Банковский счет],[Пол],[Паспортные данные],ИНН,Должность) values({numb_phone}, {bank}, '{sex}', {passport}, {inn}, '{position}')";
                SqlCommand command = new SqlCommand(query, Con);
                SqlCommand command2 = new SqlCommand(query2, Con);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                Con.Close();

            }
        }

        public void addPost(string namePost, string specProd)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"insert into Поставщики([Название компании], [Специализация товара], [Табельный номер]) values ('{namePost}', '{specProd}', 1);";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();

            }
        }

        public void addZProd(string name, string kolv, string st, string numbPost)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"insert into [Заявки на товары]([Дата заявки],[Название] ,[Количество],[Итоговая стоимость],[Табельный номер],[Номер поставщика]) values ('{DateTime.Now:g}', '{name}', {kolv}, {st}, 1, {numbPost});";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();

            }
        }
        public void addProd(string name, string kolv, string st, string numbPost)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"insert into Товар ([Название] ,[Количество],[Стоимость],[Номер поставщика]) values ('{name}', {kolv}, {st}, {numbPost});";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();

            }
        }
        public void addSpProd(string numb, string kolv, string loss)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"insert into [Списанная продукция] ([Номер товара] ,[Количество],[Убыток],[Табельный номер]) values ({numb}, {kolv}, {loss}, 1);";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();

            }
        }

        public void Delete(string nameTable, string nameT, string delParam, string Param)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = "DELETE FROM " + nameTable + " WHERE" + delParam +" = " + Param;
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                if (nameTable != string.Empty)
                {
                    query = "DELETE FROM " + nameT + " WHERE" + delParam + " = " + Param;
                    command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                }
                Con.Close();

            }
        }


    }
}
