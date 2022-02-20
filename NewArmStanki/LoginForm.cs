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

            this.PassField.AutoSize = false; //дизайн блок в начале
            this.PassField.Size = new Size(this.PassField.Size.Width, 34);
            this.LoginField.Text = "Введите login";
            this.LoginField.ForeColor = Color.Gray;
            this.PassField.UseSystemPasswordChar = false;
            this. PassField.Font = new Font(PassField.Font.FontFamily, 13);
            this.PassField.Text = "Введите пароль";
            this.PassField.ForeColor = Color.Gray;
        }

        //Блок ненужного дизайна, сохраню 
        /*                 private void CloseButton_Click(object sender, EventArgs e)
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

                           Point lastPoint;  передвижение формы 
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
              */

        private void PassField_Enter(object sender, EventArgs e)
        {
            PassField.UseSystemPasswordChar = true;
            PassField.Text = "";
            PassField.ForeColor = Color.Black;
        }

        private void PassField_Click(object sender, EventArgs e)
        {
            PassField.UseSystemPasswordChar = true;
            PassField.Text = "";
            PassField.ForeColor = Color.Black;
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            LoginField.Text = "";
            LoginField.ForeColor = Color.Black;
        }
        private void LoginField_Leave(object sender, EventArgs e) //Если пустое поле, то просьба ввести логин
        {
            if (LoginField.Text == "")
            {
                LoginField.Font = new Font(LoginField.Font.FontFamily, 13);
                LoginField.Text = "Введите login";
                LoginField.ForeColor = Color.Gray;
                return;
            }
        }
        private void PassField_Leave(object sender, EventArgs e) //Если пустое поле, то просьба ввести пароль
        {
            if (PassField.Text == "")
            {
                PassField.UseSystemPasswordChar = false;
                PassField.Font = new Font(PassField.Font.FontFamily, 13);
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;
                return;
            }
        }
        public void buttonLogin_Click(object sender, EventArgs e)
        {

            String loginUser = LoginField.Text; //забираем логин
            String passwordUser = PassField.Text; //забираем пасс


            DB db = new DB();   //Создали объект для использования бд

            DataTable dataTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from users where login = @uL and password = @uP", db.getConnection()); //команды для БД(защита от взлома)
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; //Указываю заместо заглушки беру данные из переменной
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser; //Указываю заместо заглушки беру данные из переменной

            adapter.SelectCommand = command; // выбрали нужную команду и выполнили
            adapter.Fill(dataTable); //Данные которые получили, положили в дата тейбл, Обращаюсь к каждому элементу БД

            if (dataTable.Rows.Count > 0) //Сколько есть записей
            {
                MessageBox.Show("Успешная авторизация");
                this.Hide();
                MainForm MainForm = new MainForm(); //Создаем объект с новой формой, выделяем память
                MainForm.Show();
            }
            else
                MessageBox.Show("Не удалось авторизоваться, попробуйте еще раз!","Предупреждение");
                LoginField.Text = loginUser; //оставляю введенный логин
                PassField.Text = null; //Чищу только пароль
                PassField.Focus();
                return;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения (проверка)
        {
            {
                if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Предупреждение", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;
                else
                    e.Cancel = false;
            }

        }
    }
}
