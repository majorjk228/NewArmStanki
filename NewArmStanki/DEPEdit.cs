using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select DEP1 from main", db.getConnection());

            adapter.SelectCommand = command; // выбрали нужную команду и выполнили
            adapter.Fill(dataTable); //Данные которые получили, положили в дата тейбл, Обращаюсь к каждому элементу БД

            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "DEP1";
            comboBox1.ValueMember = "DEP1";
            comboBox1.DisplayMember.ToString();
            comboBox1.SelectedValueChanged += new EventHandler(comboBox1_SelectedValueChanged);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
           // {
                textBoxEditDep.Text = comboBox1.SelectedValue.ToString();
                string s = textBoxEditDep.Text;
                //{
                    // OldDep += new EventHandler(buttonEditDep_Click);
                //    buttonEditDep_Click(s);
                //}
                //  buttonEditDep_Click(s);
           // }
        }

        private void buttonEditDep_Click(object sender, EventArgs e)
        {

            char[] MyChar = { ' ' };

            string OldDep = textBoxEditDep.Text; //Кладем в переменную значение со строки
            string OldDep1 = OldDep.TrimStart(MyChar); //Не учитываем пробелы в начале
            string OldDep2 = OldDep1.TrimEnd(MyChar); //Не учитываем пробелы в Конце


            string NewDep = textBoxEdit2.Text; //Кладем в переменную значение со строки
            string NewDep1 = NewDep.TrimStart(MyChar); //Не учитываем пробелы в начале
            string NewDep2 = NewDep1.TrimEnd(MyChar); //Не учитываем пробелы в Конце

            DB db = new DB();   //Создали объект для использования бд


            MySqlCommand command = new MySqlCommand("UPDATE main SET DEP1 = @DEP1 WHERE DEP1 = @DEP12", db.getConnection());//SQL запрос

            if (OldDep2 != "")
            {
                command.Parameters.Add("@DEP12", MySqlDbType.VarChar).Value = OldDep2;
                    
            }

            if (NewDep2 != "")
            { 
                command.Parameters.Add("@DEP1", MySqlDbType.VarChar).Value = NewDep2; //Забираем из текст бокса текст. 
            }

            db.openConnection(); //Открываем соединение с БД

            if (command.ExecuteNonQuery() == 1) //Если подключение удачное то вывдеется текст, если отработало
                MessageBox.Show("Запись обновлена");
            else
                MessageBox.Show("Не верно введено текущее подразделение", "Ошибка");

            db.closeConnection(); //Закрываем соединение с БД (Необходимо чтобы снизить загрузку на бд
        }
    }
}

