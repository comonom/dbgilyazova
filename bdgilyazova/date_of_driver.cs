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
    public partial class date_of_driver : Form
    {
        public date_of_driver()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Form1 g = new Form1();
            g.Show();
            Hide();
            return;
        }

    }
}
