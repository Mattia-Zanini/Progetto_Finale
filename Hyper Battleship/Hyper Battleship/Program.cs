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
        public static int quantitàAssaltoDoppioGiocatore1 = 2, quantitàAssaltoDoppioGiocatore2 = 2;
        public static bool finePartita = false;
        public static bool multigiocatore = false; //false = giocatore singolo
                                                   //true = multigiocatore
        public static bool modalità = false; //false = partita veloce
                                             //true = partita normale
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
