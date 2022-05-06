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
            Grid_View.Visible = false;
            if(action == "Добавить")
            {
                if(nameTable == "Сотрудники"){
                    lbl10.Visible = false;
                    tb_10.Visible = false;
                    lbl1.Text = "Имя";
                    lbl2.Text = "Фамилия";
                    lbl3.Text = "Отчество";
                    lbl4.Text = "Номер телефона";
                    lbl5.Text = "Банковский счет";
                    lbl6.Text = "Пол";
                    tb_6.MaxLength = 1;
                    lbl7.Text = "Паспортные данные";
                    lbl8.Text = "ИНН";
                    lbl9.Text = "Должность";
                }
                else if(nameTable == "Поставщики") {
                    tb_3.Visible = false;
                    tb_4.Visible = false;
                    tb_5.Visible = false;
                    tb_6.Visible = false;
                    tb_7.Visible = false;
                    tb_8.Visible = false;
                    tb_9.Visible = false;
                    tb_10.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl9.Visible = false;
                    lbl10.Visible = false;
                    lbl1.Text = "Название компании";
                    lbl2.Text = "Cпециализация товара";
                }
                else if(nameTable == "Заявки на товары") {
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
                    lbl1.Text = "Название";
                    lbl2.Text = "Количество";
                    lbl3.Text = "Итоговая стоимость";
                    lbl4.Text = "Номер поставщика";

                }
                else if(nameTable == "Товары") {
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
                    lbl10.Visible = false;;
                    lbl1.Text = "Название";
                    lbl2.Text = "Количество";
                    lbl3.Text = "Стоимость";
                    lbl4.Text = "Номер поставщика";
                }
                else if(nameTable == "Списанные товары") {
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
                    lbl1.Text = "Номер товара";
                    lbl2.Text = "Количество";
                    lbl3.Text = "Убыток";
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
                    lbl1.Text = "Табельный номер";

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
                Grid_View.Visible = true;
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
                if (nameTable == "Сотрудники")
                {
                    label1.Text = "Фамилия";

                }
                else if (nameTable == "Поставщики")
                {
                    label1.Text = "Название компании";
                }
                else if (nameTable == "Заявки на товары")
                {
                  
                    label1.Text = "Код заявки";

                }
                else if (nameTable == "Товары")
                {
                    
                    label1.Text = "Название";
                }
                else if (nameTable == "Списанные товары")
                {
                  
                    label1.Text = "ID";

                }
            }
            else if (action == "Фильтрация") {
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
                if (nameTable == "Сотрудники")
                {

                    label1.Text = "Фамилия";
                }
                else
                {
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

        private void btn_execute_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            if(action == "Добавить") { 
                if(nameTable == "Сотрудники") {
                    dB.addSotr(tb_1.Text, tb_2.Text, tb_3.Text, tb_4.Text, tb_5.Text, tb_6.Text, tb_7.Text, tb_8.Text, tb_9.Text);
                }
                else if(nameTable == "Поставщики") {
                    dB.addPost(tb_1.Text, tb_2.Text);
                }
                else if(nameTable == "Заявки на товары") {
                    dB.addZProd(tb_1.Text, tb_2.Text, tb_3.Text, tb_4.Text);
                }
                else if(nameTable == "Товары") {
                    dB.addProd(tb_1.Text, tb_2.Text, tb_3.Text, tb_4.Text);
                }
                else if(nameTable == "Списанные товары") {
                    dB.addSpProd(tb_1.Text, tb_2.Text, tb_3.Text);
                }
            }
            else if(action == "Удалить") { 
                if(nameTable == "Сотрудники") {
                    dB.Delete("[Сотрудники]", "[Информация о сотрудниках]", "[Табельный номер]", tb_1.Text);
                }
                else if(nameTable == "Поставщики") {
                    dB.Delete("[Поставщик]", string.Empty, "[Назване компании]", tb_1.Text);
                }
                else if(nameTable == "Заявки на товары") {
                    dB.Delete("[Заявки на товары]", string.Empty, "[Код заявки]", tb_1.Text);
                }
                else if(nameTable == "Товары") {
                    dB.Delete("[Товар]", string.Empty, "");
                }
            }
        }
    }
}
