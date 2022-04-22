using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdgilyazova
{
    class datebase
    {
        MySqlConnection connection = new MySqlConnection("server=cfif31.ru;user name=ISPr24-38_EluazovaAR;password=3Gmvd0904;database=ISPr24-38_EluazovaAR_solution");
        
            public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            //проверка состояния бд, если не подключены - идет подключение , во 2 методе наоборот(завершение работы с бд) 
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection() 
        {
            return connection;
            //возвращение соединения к бд
        }


    }
}
