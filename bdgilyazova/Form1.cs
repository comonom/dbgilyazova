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

namespace bdgilyazova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            String logindriver = tbLogin.Text;
            String passworddriver = tbPassword.Text;
            datebase BD = new datebase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(); //
            MySqlCommand command = new MySqlCommand("SELECT*FROM drivers WHERE login=@logindriver AND password = @passworddriver", BD.getConnection());
            command.Parameters.Add("@logindriver", MySqlDbType.VarChar).Value = logindriver; //указали тип данных для переменной и подставили в заглушку @ нужные данные
            command.Parameters.Add("@passworddriver", MySqlDbType.VarChar).Value = passworddriver;
            adapter.SelectCommand = command; //указание команды выше
            adapter.Fill(table); //заполнение table полученными данными
            if (table.Rows.Count > 0) //если записей больше 0, то данные введены верно
            { 
                MessageBox.Show("Welcome!");
                date_of_driver f = new date_of_driver();
                f.Show();
                Hide();
                return;
            }
                MessageBox.Show("Error!");
            Form1 g = new Form1();
            g.Close();
            Hide();
            return;
            //выбор данных из БД

        }
    }
}
