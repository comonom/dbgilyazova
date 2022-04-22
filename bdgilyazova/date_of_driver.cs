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
        public date_of_driver()
        {
            InitializeComponent();
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
            Another another = new Another();
            another.Show();
            Hide();
            return;
        }
    }
}
