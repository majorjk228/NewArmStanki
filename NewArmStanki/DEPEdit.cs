//using MySql.Data.MySqlClient;
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
    public partial class DEPEdit : Form
    {
        public DEPEdit()
        {
            InitializeComponent();

        }

        public void comboBox1_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            DataTable dataTable = new DataTable();

            OracleDataAdapter adapter = new OracleDataAdapter();

            OracleCommand command = new OracleCommand("select * from main", db.getConnection());

            adapter.SelectCommand = command; // выбрали нужную команду и выполнили
            adapter.Fill(dataTable); //Данные которые получили, положили в дата тейбл, Обращаюсь к каждому элементу БД
            if (dataTable.Rows.Count > 0) //Сколько есть записей
            {
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "DEP1";
                comboBox1.ValueMember = "DEP1";
                comboBox1.DisplayMember.ToString();
            }
            else
                MessageBox.Show("Не удалось загрузить подразделения");
        }

        private void buttonEditDep_Click(object sender, EventArgs e)
        {

            char[] MyChar = { ' ' };

            string OldDep = comboBox1.SelectedValue.ToString(); //Кладем в переменную значение со строки
            string OldDep1 = OldDep.TrimStart(MyChar); //Не учитываем пробелы в начале
            string OldDep2 = OldDep1.TrimEnd(MyChar); //Не учитываем пробелы в Конце textBoxEditDep 2


            string NewDep = textBoxEdit2.Text; //Кладем в переменную значение со строки
            string NewDep1 = NewDep.TrimStart(MyChar); //Не учитываем пробелы в начале
            string NewDep2 = NewDep1.TrimEnd(MyChar); //Не учитываем пробелы в Конце

            DB db = new DB();   //Создали объект для использования бд


            OracleCommand command = new OracleCommand("UPDATE main SET DEP1 = :DepNew " +
                "where DEP1 = :DepOld", db.getConnection());//SQL запрос

            if (NewDep2 != "")
            {
                command.Parameters.Add("DepNew", OracleDbType.Varchar2).Value = NewDep2; //Забираем из текст бокса текст. 
            }
            else
                MessageBox.Show("Укажите новое подразделение");

            if (OldDep2 != "")
            {
                command.Parameters.Add("DepOld", OracleDbType.Varchar2).Value = OldDep2;       
            }

            db.openConnection(); //Открываем соединение с БД

            if (command.ExecuteNonQuery() == 1) //Если выполнение удачное то вывдеется текст, если отработало
                MessageBox.Show("Запись обновлена");
            else
                MessageBox.Show("Не верно введено текущее подразделение", "Ошибка");
            
            db.closeConnection(); //Закрываем соединение с БД (Необходимо чтобы снизить загрузку на бд
        }
    }
}

