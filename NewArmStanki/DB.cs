using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArmStanki
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;username=root;database=test");

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

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
