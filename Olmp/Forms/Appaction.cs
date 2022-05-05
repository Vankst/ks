using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olmp.Forms
{
    public partial class Appaction : Form
    {
        public Appaction()
        {
            InitializeComponent();
        }

        public static string nameTable;
        public static string action;
        public static string login;
        private void Appaction_Load(object sender, EventArgs e)
        {
            if(action == "Добавить")
            {
                if(nameTable == "Сотрудники"){
                    lbl1.Text = "Табельный номер";
                    lbl2.Text = "Имя";
                    lbl3.Text = "Фамилия";
                    lbl4.Text = "Отчество";
                    lbl5.Text = "Номер телефона";
                    lbl6.Text = "Банковский счет";
                    lbl7.Text = "Пол";
                    lbl8.Text = "Паспортные данные";
                    lbl9.Text = "ИНН";
                    lbl10.Text = "Должность";
                }
                else if(nameTable == "Поставщики") {
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Номер поставщика";
                    lbl2.Text = "Название компании";
                    lbl3.Text = "Cпециализация товара";
                }
                else if(nameTable == "Заявки на товары") {
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Код заявки";
                    lbl2.Text = "Название";
                    lbl3.Text = "Количество";
                    lbl4.Text = "Итоговая стоимость";
                    lbl5.Text = "Номер поставщика";

                }
                else if(nameTable == "Товары") {
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Номер товара";
                    lbl2.Text = "Название";
                    lbl3.Text = "Количество";
                    lbl4.Text = "Стоимость";
                    lbl5.Text = "Номер поставщика";
                }
                else if(nameTable == "Списанные товары") {
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "ID";
                    lbl2.Text = "Номер товара";
                    lbl3.Text = "Количество";
                    lbl4.Text = "Убыток";
                }
            }
            else if(action == "Удалить"){
                if (nameTable == "Сотрудники")
                {
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Фамилия";

                }
                else if (nameTable == "Поставщики")
                {
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Название компании";
                }
                else if (nameTable == "Заявки на товары")
                {
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Код заявки";

                }
                else if (nameTable == "Товары")
                {
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Название";
                }
                else if (nameTable == "Списанные товары")
                {
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "ID";

                }
            }
            else if (action == "Изменить") {
                if (nameTable == "Сотрудники")
                {
                    lbl1.Text = "Табельный номер";
                    lbl2.Text = "Имя";
                    lbl3.Text = "Фамилия";
                    lbl4.Text = "Отчество";
                    lbl5.Text = "Номер телефона";
                    lbl6.Text = "Банковский счет";
                    lbl7.Text = "Пол";
                    lbl8.Text = "Паспортные данные";
                    lbl9.Text = "ИНН";
                    lbl10.Text = "Должность";
                }
                else if (nameTable == "Поставщики")
                {
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Номер поставщика";
                    lbl2.Text = "Название компании";
                    lbl3.Text = "Cпециализация товара";
                }
                else if (nameTable == "Заявки на товары")
                {
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Код заявки";
                    lbl2.Text = "Название";
                    lbl3.Text = "Количество";
                    lbl4.Text = "Итоговая стоимость";
                    lbl5.Text = "Номер поставщика";

                }
                else if (nameTable == "Товары")
                {
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Номер товара";
                    lbl2.Text = "Название";
                    lbl3.Text = "Количество";
                    lbl4.Text = "Стоимость";
                    lbl5.Text = "Номер поставщика";
                }
                else if (nameTable == "Списанные товары")
                {
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "ID";
                    lbl2.Text = "Номер товара";
                    lbl3.Text = "Количество";
                    lbl4.Text = "Убыток";
                }
            }
            else if(action == "Поиск") {
                if (nameTable == "Сотрудники")
                {
                    tb_1.Visible = false;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    label1.Text = "Фамилия";

                }
                else if (nameTable == "Поставщики")
                {
                    tb_1.Visible = false;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    label1.Text = "Название компании";
                }
                else if (nameTable == "Заявки на товары")
                {
                    tb_1.Visible = false;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    label1.Text = "Код заявки";

                }
                else if (nameTable == "Товары")
                {
                    tb_1.Visible = false;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    label1.Text = "Название";
                }
                else if (nameTable == "Списанные товары")
                {
                    tb_1.Visible = false;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    label1.Text = "ID";

                }
            }
            else if (action == "Фильтрация") {
                if (nameTable == "Сотрудники")
                {
                    tb_1.Visible = false;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    label1.Text = "Фамилия";
                }
                else
                {
                    tb_1.Visible = false;
                    tb_2.Visible = false;
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    label1.Text = "Фильтрация только по таблице Сотрудники";
                }


            }
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            Account.login = login;
            account.Show();
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
    }
}
