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
    public partial class IstruzioniAttacco : Form
    {
        public IstruzioniAttacco()
        {
            InitializeComponent();
        }

        private void contornoTastoOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contornoTastoOK_MouseEnter(object sender, EventArgs e)
        {
            contornoTastoOK.Image = Properties.Resources.contornoTastoOK;
        }

        private void contornoTastoOK_MouseLeave(object sender, EventArgs e)
        {
            contornoTastoOK.Image = null;
        }
    }
}
