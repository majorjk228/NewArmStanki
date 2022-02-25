//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace NewArmStanki
{
    internal class DB
    {

        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=admin;password=root;database=test"); //Подключение к бд домашнее

        OracleConnection connection = new OracleConnection("DBA PRIVILEGE=SYSDBA;USER ID=SYS;PASSWORD=123;DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True");

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

        public OracleConnection getConnection() //Возвращает само соединение С БД
        {
            return connection;
        }


    }
}
