using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyper_Battleship
{
    static class Program
    {
        public static string nomeVincitore = "";
        public static string nomeGiocatore1 = "", nomeGiocatore2 = "";
        public static bool partitaConclusa = false;
        public static int scoreGiocatore1 = 0, scoreGiocatore2 = 0;
        public static bool finePartita = false;

        //per decidere se una vota conclusa la partita, salvare o meno i dati dei corrispettivi giocatori
        public static bool salvataggioDatiGiocatore1 = false;
        public static bool salvataggioDatiGiocatore2 = false;

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
