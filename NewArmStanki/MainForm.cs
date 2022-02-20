using MySql.Data.MySqlClient; //Для работы с SQL
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEditDep_Click(object sender, EventArgs e)
        {
            DB db = new DB();   //Создали объект для использования бд

            //string EditDep = textBoxEditDep.Text;
            //string RedDep =;

            /*  MySqlCommand command = new MySqlCommand("INSERT INTO `test`.`main` (`NAME`, `DEP1`, `DEP2`) VALUES ('Плата 48', @DEP1, 'Цех 10')", db.getConnection());//SQL запрос
              //MySqlCommand command = new MySqlCommand("INSERT INTO `test`.`main` (`DEP1`) VALUES (@DEP1)", db.getConnection()); //SQL запрос образаюсь к депу

              command.Parameters.Add("@DEP1", MySqlDbType.VarChar).Value = textBoxEditDep.Text; //Забираем из текст бокса текст.
            */  //command.Parameters.Add("@DEP1", MySqlDbType.VarChar).Value = textBoxEditDep.Text; //Для других полей аналогично меняем переменную и текста


            MySqlCommand command = new MySqlCommand("UPDATE main " +
                "SET DEP1 = @DEP1 WHERE DEP1 = @DEP12", db.getConnection());//SQL запрос

            command.Parameters.Add("@DEP12", MySqlDbType.VarChar).Value = textBoxEditDep.Text;

            command.Parameters.Add("@DEP1", MySqlDbType.VarChar).Value = textBoxEditDep2.Text; //Забираем из текст бокса текст.


            db.openConnection(); //Открываем соединение с БД


            if (command.ExecuteNonQuery() == 1) //Если подключение удачное то вывдеется текст
                MessageBox.Show("Запись добавлена");
            else
                MessageBox.Show("Запись Не Добавлена", "Ошибка");

            db.closeConnection(); //Закрываем соединение с БД (Необходимо чтобы снизить загрузку на бд
        }

       private void MainForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения (проверка)
        {
            {
                if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Предупреждение", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                    e.Cancel = false;
                    Environment.Exit(0); //Закрытие всего приложения
            }
        }

        private void редактироватьПодразделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEPEdit DEPEdit = new DEPEdit(); //Создаем объект с новой формой, выделяем память
            DEPEdit.Show();
        }
    }
}
