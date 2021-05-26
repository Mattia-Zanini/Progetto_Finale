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
    public partial class SchermataFinale : Form
    {
        public SchermataFinale()
        {
            InitializeComponent();
            nomeGiocatoreVittoria.Text = Program.nomeVincitore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Schermata_Iniziale f1 = new Schermata_Iniziale();
            f1.Show();
            this.Close();
        }
    }
}
