//using MySql.Data.MySqlClient; //Для работы с SQL
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
            RemEdit DEPEdit = new RemEdit(); //Создаем объект с новой формой, выделяем память
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
            RemEdit DEPEdit = new RemEdit(); //Создаем объект с новой формой, выделяем память
            DEPEdit.ShowDialog();
        }
        private void label1_MouseMove(object sender, EventArgs e)
        {
            panelEditDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ObslEdit ObslEdit = new ObslEdit(); //Создаем объект с новой формой, выделяем память
            ObslEdit.ShowDialog();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DelPPR DelPPR = new DelPPR(); //Создаем объект с новой формой, выделяем память
            DelPPR.ShowDialog();
        }
    }
}
