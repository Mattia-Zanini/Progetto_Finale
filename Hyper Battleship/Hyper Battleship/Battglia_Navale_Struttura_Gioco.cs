using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper_Battleship
{
    class Battglia_Navale_Struttura_Gioco
    {
        //Griglia 10 x 10 caselle. partita normale
        public static string[] StrutturaGriglia10 = new string[]  {"acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no"};

        //Griglia 6 x 6 caselle, partita veloce
        public static string[] StrutturaGriglia6 = new string[]   {"acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no",
                                                                   "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no", "acqua,G1_no,G2_no"};

        public static bool finePartita = false;
        public void Gioco()
        {
            do
            {
                //controllo se l'utente/utenti ha/hanno scelto una partita normale o veloce

            } while (finePartita == false);
        }
    }
}
