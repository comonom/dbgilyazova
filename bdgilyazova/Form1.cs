using MySqlConnector;
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
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
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
            GroupBox gbInfo;
            String lbFullname = tbFIO.Text;
            String lbPasportData=tbPassportData.Text;
            String lbHeight = tbHeight.Text;
            String lbBirth=tbBirth.Text;
            datebase DB = new datebase();
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand everydriver = new MySqlCommand("SELECT * FROM drivers WHERE login=@logindriver AND password = @passworddriver", DB.getConnection());
            everydriver.Parameters.Add("@logindriver", MySqlDbType.VarChar).Value=logindriver;
            everydriver.Parameters.Add("@passworddriver", MySqlDbType.VarChar).Value=passworddriver;
            adapter.SelectCommand = everydriver;



        }

    }
}
