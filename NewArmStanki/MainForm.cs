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

        private void panelEditDep_MouseMove(object sender, MouseEventArgs e)
        {
            panelEditDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
        }

        private void panelEditDep_MouseLeave(object sender, EventArgs e)
        {
            panelEditDep.BackColor = Color.LightGray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DEPEdit DEPEdit = new DEPEdit(); //Создаем объект с новой формой, выделяем память
            DEPEdit.Show();
        }
        private void label1_MouseMove(object sender, EventArgs e)
        {
            panelEditDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
        }
    }
}
