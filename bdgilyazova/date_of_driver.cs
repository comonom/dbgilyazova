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
    public partial class date_of_driver : System.Windows.Forms.Form
    {
        private object table;

        public date_of_driver(User user)
        {
            InitializeComponent();
            tbFIO.Text = user.fullname;
            tbBirth.Text = user.birth;
            tbHeight.Text = user.height;
            tbPassportData.Text = user.passportdata;

        }

        private void btnOut_Click(object sender, EventArgs e) //выход из системы
        {
            Form1 g = new Form1();
            g.Show();
            Hide();
            return;
        }

        private void btnAnother_Click(object sender, EventArgs e) //переход к другим пользователям
        {
            User user = new User(table.Rows[0]);
            Another another = new Another();
            another.Show();
            Hide();
            return;
        }

        private void btnInfoCar_Click(object sender, EventArgs e)
        {
            InfoCar infocar = new InfoCar();
            infocar.Show();
            Hide();
            return;

        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
