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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAuth_Click(object sender, EventArgs e)
        {
            String logindriver = tbLogin.Text; 
            String passworddriver = tbPassword.Text;
            datebase BD = new datebase();
            BD.openConnection();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM drivers WHERE login=@logindriver AND password = @passworddriver", BD.getConnection());
            command.Parameters.Add("@logindriver", MySqlDbType.VarChar).Value = logindriver; //указали тип данных для переменной и подставили в заглушку @ нужные данные
            command.Parameters.Add("@passworddriver", MySqlDbType.VarChar).Value = passworddriver;
            table.Load(command.ExecuteReader());
            if (table.Rows.Count > 0) //если записей больше 0, то данные введены верно
            {
                User user = new User(table.Rows[0]);
                InfoCar infocar = new InfoCar(table.Rows[0]);
                MessageBox.Show("Welcome, "+user.fullname+"!");
                date_of_driver f = new date_of_driver(user);
                f.Show();
                Hide();
                return;
            }
            MessageBox.Show("Error, retry!");
            Form1 g = new Form1();
            g.Show();
            Hide();
            return;
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
