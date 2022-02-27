using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace NewArmStanki
{
    public partial class DelPPR : Form
    {
        public DelPPR()
        {
            InitializeComponent();
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable dataTable = new DataTable();

            OracleDataAdapter adapter = new OracleDataAdapter();

            OracleCommand command = new OracleCommand("select ITEMNAME from main", db.getConnection());

            adapter.SelectCommand = command; // выбрали нужную команду и выполнили
            adapter.Fill(dataTable); //Данные которые получили, положили в дата тейбл, Обращаюсь к каждому элементу БД
            if (dataTable.Rows.Count > 0) //Сколько есть записей
            {
                comboBox2.DataSource = dataTable;
                comboBox2.DisplayMember = "ITEMNAME"; //Вывожу колонку ITEMNAME
                comboBox2.ValueMember = "ITEMNAME";
                comboBox2.DisplayMember.ToString();
            }
            else
                MessageBox.Show("Не удалось загрузить инвентарный номер", "Ошибка");
        }

        private void buttonEditDep_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Не выбран инвентарный номер", "Ошибка");
                return;
            }          
            string invent = comboBox2.SelectedValue.ToString();

            DB db = new DB();   //Создали объект для использования бд

            OracleCommand command = new OracleCommand("DELETE main where ITEMNAME = :inv", db.getConnection());//Oracle запрос

            if (invent == "")
            {
                MessageBox.Show("Укажите инвентарный номер", "Ошибка");
            }

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить " + invent + "?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command.Parameters.Add("inv", OracleDbType.Varchar2).Value = invent;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            db.openConnection(); //Открываем соединение с БД

            if (command.ExecuteNonQuery() == 1) //Если выполнение удачное то вывдеется текст, если отработало
                MessageBox.Show("Запись удалена!");
            else
                MessageBox.Show("Запись не удалена!", "Ошибка");

            db.closeConnection(); //Закрываем соединение с БД (Необходимо чтобы снизить загрузку на бд)
        }
    }
}
