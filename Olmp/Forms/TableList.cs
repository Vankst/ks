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
namespace Olmp.Forms
{
    public partial class TableList : Form
    {
        public TableList()
        {
            InitializeComponent();
        }
        public static string login;
       
    

        private void TableList_Load(object sender, EventArgs e)
        {
            cb_table.Items.AddRange(new string[] { "Сотрудники", "Поставщики", "Заявки на товары", "Товары", "Списанные товары" });
            cb_action.Items.AddRange(new string[] { "Добавить", "Удалить", "Изменить", "Поиск", "Сортировка", "Фильтрация" });

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cb_action.SelectedIndex > -1 && cb_table.SelectedIndex > -1)
            {
                Appaction appaction = new Appaction();
                Appaction.nameTable = cb_table.Text;
                Appaction.action = cb_action.Text;
                Appaction.login = login;
                appaction.Show();
                this.Close();
            }
        }
        private void btn_main_Click(object sender, EventArgs e)
        {
        }

    }
}
