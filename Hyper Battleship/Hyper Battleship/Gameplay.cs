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
    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
        }

        //Griglia 10 x 10 caselle. partita normale
        public static string[] StrutturaGriglia10 = new string[]  {"acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no" };
        //Griglia 6 x 6 caselle, partita veloce
        public static string[] StrutturaGriglia6 = new string[]   {"acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no" };

        public static bool finePartita = false;
        public static int scoreGiocatore1 = 0, scoreGiocatore2 = 0;
        public void Gioco(bool modalità)
        {
            int turno = 0;
            Schermata_Iniziale f1 = new Schermata_Iniziale();
            byte quantitàRadar = 1, quantitàDoppioAssalto;//booster partita
            if (modalità == false)//controllo se l'utente/utenti ha/hanno scelto una partita normale o veloce
            {
                quantitàDoppioAssalto = 1;
            }
            else
            {
                quantitàDoppioAssalto = 2;
            }

            //Giocatore 1 dispone le navi
            //Giocatore 2 dispone le navi

            do
            {
                turno++;

            } while (finePartita == false);
        }
    }
}
