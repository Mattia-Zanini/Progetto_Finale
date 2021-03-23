using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyper_Battleship
{
    public partial class Gioco : Form
    {
        public Gioco()
        {
            InitializeComponent();
        }

        private void Hyper_Battleship_Load(object sender, EventArgs e)
        {

        }

        private void Gioco_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
