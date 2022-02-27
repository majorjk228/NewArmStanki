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
    public partial class ObslEdit : Form
    {
        public ObslEdit()
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
        public void comboBox1_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            DataTable dataTable = new DataTable();

            OracleDataAdapter adapter = new OracleDataAdapter();

            OracleCommand command = new OracleCommand("select DEP2 from main", db.getConnection());

            adapter.SelectCommand = command; // выбрали нужную команду и выполнили
            adapter.Fill(dataTable); //Данные которые получили, положили в дата тейбл, Обращаюсь к каждому элементу БД
            if (dataTable.Rows.Count > 0) //Сколько есть записей
            {
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "DEP2"; //Вывожу колонку DEP1
                comboBox1.ValueMember = "DEP2";
                comboBox1.DisplayMember.ToString();
            }
            else
                MessageBox.Show("Не удалось загрузить подразделения", "Ошибка");
        }

        private void buttonEditDep_Click(object sender, EventArgs e)
        {

            char[] MyChar = { ' ' };
            char[] MyChar2 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Не выбрано текущее подразделение", "Ошибка");
                return;
            }
            string OldDep = comboBox1.SelectedValue.ToString(); //Кладем в переменную значение со строки
            string OldDep1 = OldDep.TrimStart(MyChar); //Не учитываем пробелы в начале
            string OldDep2 = OldDep1.TrimEnd(MyChar); //Не учитываем пробелы в Конце textBoxEditDep 2

            string NewDep = textBoxEdit2.Text; //Кладем в переменную значение со строки
            string NewDep1 = NewDep.TrimStart(MyChar); //Не учитываем пробелы в начале
            string NewDep2 = NewDep1.TrimEnd(MyChar); //Не учитываем пробелы в Конце

            DB db = new DB();   //Создали объект для использования бд


            OracleCommand command = new OracleCommand("UPDATE main SET DEP2 = :DepNew " +
                "where DEP2 = :DepOld", db.getConnection());//Oracle запрос


            if (NewDep2 != "")
            {
                command.Parameters.Add("DepNew", OracleDbType.Varchar2).Value = NewDep2; //Забираем из текст бокса текст. 
            }
            else
                MessageBox.Show("Укажите новое подразделение", "Ошибка");

            if (OldDep2 != "")
            {
                command.Parameters.Add("DepOld", OracleDbType.Varchar2).Value = OldDep2;
            }

            db.openConnection(); //Открываем соединение с БД

            if (command.ExecuteNonQuery() == 1) //Если выполнение удачное то вывдеется текст, если отработало
                MessageBox.Show("Запись обновлена");
            else
                MessageBox.Show("Не верно введено текущее подразделение", "Ошибка");

            db.closeConnection(); //Закрываем соединение с БД (Необходимо чтобы снизить загрузку на бд)
        }
        private void textBoxEdit2_TextChanged(object sender, EventArgs e) //Защита от дурака по вставке цеха
        {

            if (textBoxEdit2.TextLength < 4)
            {
                MessageBox.Show("Нельзя убрать 'Цех'", "Ошибка");
                textBoxEdit2.Text = "Цех ";
                textBoxEdit2.Focus();
                textBoxEdit2.Select(4, 0);
            }
        }

        private void textBoxEdit2_KeyPress(object sender, KeyPressEventArgs e) //Вводить только символы
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private void textBoxEdit2_MouseClick(object sender, MouseEventArgs e) //Ставлю курсор только после слова Цех(Защита от дурака по вставке цеха)
        {
            textBoxEdit2.Focus();
            textBoxEdit2.Select(4, 0);
        }
    }
}