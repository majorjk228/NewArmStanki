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
    }
}
