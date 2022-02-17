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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 57);
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Green;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)//передвижение формы
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);    
        }

        private void label1_MouseMove(object sender, MouseEventArgs e) //передвижение формы
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            label1.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = LoginField.Text; //забираем логин
            String passwordUser = PassField.Text; //забираем пасс

            DB db = new DB();   //Создали несколько объектов

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from users where login = @uL and password = @uP", db.getConnection()); //команды для БД(защита от взлома)
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; //Указываю заместо заглушки беру данные из переменной
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser; //Указываю заместо заглушки беру данные из переменной

            adapter.SelectCommand = command; // выбрали нужную команду и выполнили
            adapter.Fill(dataTable); //Данные которые получили, положили в дата тейбл, Обращаюсь к каждому элементу БД

            if (dataTable.Rows.Count > 0) //Сколько есть записей
                MessageBox.Show("Удачная авторизация");
            else
                MessageBox.Show("Не удалось авторизоваться");

        }
    }
}
