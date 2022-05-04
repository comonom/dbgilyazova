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
    public partial class InfoCar : Form
    {
        public InfoCar()
        {
            InitializeComponent();
            tbID.Text = InfoCar.id;
            tbVim.Text = infocar.vim;

        }

        private void InfoCar_Load(object sender, EventArgs e)
        {

        }
    }
}
