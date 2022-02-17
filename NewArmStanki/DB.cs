using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewArmStanki
{
    internal class DB
    {
            
        //MySqlConnection connection = new MySqlConnection("server=localhost;port=25;username=admin;password=root;database=test"); //Подключение к бд рабочее
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=admin;password=root;database=test"); //Подключение к бд домашнее


        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed) //Если не подклчена
            connection.Open();  //Подключаюсь к бд
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) //Если подключена
            connection.Close();  //Отключаюсь к бд
        }

        public MySqlConnection getConnection() //Возвращает само соединение С БД
        {
            return connection;
        }


    }
}
