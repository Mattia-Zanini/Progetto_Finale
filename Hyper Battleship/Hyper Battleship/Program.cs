using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyper_Battleship
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Schermata_Iniziale f1 = new Schermata_Iniziale();
            f1.Show();
            Application.Run();//per avviarlo in modo "distaccato" dagli altri form
        }
    }
}
