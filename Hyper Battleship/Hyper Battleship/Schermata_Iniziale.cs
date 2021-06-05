using System;
using System.IO;
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
    public partial class Schermata_Iniziale : Form
    {
        public Schermata_Iniziale()
        {
            InitializeComponent();
        }        

        private void quitText_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();//termina il programma
        }

        private void startText_MouseClick(object sender, MouseEventArgs e)//mostra il pannello nero a destra della finestra per selezionare le opzioni per settare la partita
        {
            startText.Visible = false;
            classificaLabel.Visible = false;
            quitText.Visible = false;

            for (int i = 0; i < classificaGridView.RowCount - 1; i++)//per cancellare la tabella
            {
                classificaGridView.Rows.RemoveAt(i);
            }
            classificaGridView.Visible = false;
            schermataSuccessiva();
        }

        public void schermataSuccessiva()//per mostrare la schermata del login (secondo form)
        {
            //reinizializza alcune picturebox e variabili
            titoloGioco1.Visible = false;
            titoloGioco2.Visible = false;

            LoginForm f2 = new LoginForm();//crea un oggetto del secondo form
            f2.Show();//mostra il secondo form
            this.Hide();//nasconde il form
        }

        static string nomeFileClassifica = @"ClassificaGiocatori.txt";
        static string percorsoSalvataggioClassificaGiocatori = AppDomain.CurrentDomain.BaseDirectory + nomeFileClassifica;
        bool colonneCreate = false;
        private void classificaLabel_Click(object sender, EventArgs e)
        {
            if(classificaGridView.Visible == false)
            {
                classificaGridView.Visible = true;

                if (colonneCreate == false)//crea le colonne solo se è la prima volta che viene mostrato
                {
                    classificaGridView.ColumnCount = 2;
                    classificaGridView.Columns[0].Name = "Nome";
                    classificaGridView.Columns[1].Name = "Punteggio";
                    colonneCreate = true;
                }

                string[] top3GiocatoriNelFile = new string[3];
                top3Giocatori(ref top3GiocatoriNelFile);
                // Populate the rows.
                string[] splitTop3GiocatoriFile = top3GiocatoriNelFile[0].Split(',');
                string[] riga1 = new string[] { splitTop3GiocatoriFile[0], splitTop3GiocatoriFile[1] };

                splitTop3GiocatoriFile = top3GiocatoriNelFile[1].Split(',');
                string[] riga2 = new string[] { splitTop3GiocatoriFile[0], splitTop3GiocatoriFile[1] };

                splitTop3GiocatoriFile = top3GiocatoriNelFile[2].Split(',');
                string[] riga3 = new string[] { splitTop3GiocatoriFile[0], splitTop3GiocatoriFile[1] };
                object[] righe = new object[] { riga1, riga2, riga3 };

                foreach (string[] arrayRighe in righe)//aggiunge le righe al datagridview
                {
                    classificaGridView.Rows.Add(arrayRighe);
                }
            }
            else//rimuove le righe se il dataagridview è già visibile e poi lo nasconde
            {
                classificaGridView.Rows.RemoveAt(0);
                classificaGridView.Rows.RemoveAt(1);
                classificaGridView.Visible = false;
            }
        }

        private void top3Giocatori(ref string[] top3GiocatoriNelFile)
        {
            var datiGiocatori = File.ReadAllLines(percorsoSalvataggioClassificaGiocatori);
            string[] arraysostitutivo = new string[datiGiocatori.ToArray().Length];
            arraysostitutivo = datiGiocatori.ToArray();//copio l'array perchè utilizzare i metodi sucessivi con la variabile 'datiGiocatori' crea problemi, e non so perchè
            for (int i = 0; i < 3; i++)
            {
                if (arraysostitutivo.Length != 0)
                {
                    for (int j = 0; j < arraysostitutivo.Length; j++)
                    {
                        try
                        {
                            string[] dettagliPlayer = arraysostitutivo[j].Split(',');//riga corrispondente al valore di j
                            string[] dettagliPlayerSucessivo = arraysostitutivo[j + 1].Split(',');//riga sucessiva da confrontare
                            if (Convert.ToInt32(dettagliPlayer[1]) > Convert.ToInt32(dettagliPlayerSucessivo[1]))//memorizza nella top 3 il giocatore con il punteggio più alto
                            {
                                top3GiocatoriNelFile[i] = $"{dettagliPlayer[0]},{dettagliPlayer[1]}";
                            }
                            else
                            {
                                top3GiocatoriNelFile[i] = $"{dettagliPlayerSucessivo[0]},{dettagliPlayerSucessivo[1]}";
                            }
                        }
                        catch//solo nel caso ci siano precisi e spaccati 3 player registrati
                        {
                            string[] dettagliPlayer = arraysostitutivo[j].Split(',');
                            top3GiocatoriNelFile[i] = $"{dettagliPlayer[0]},{dettagliPlayer[1]}";
                        }
                    }
                    int numIndex = Array.IndexOf(arraysostitutivo, top3GiocatoriNelFile[i]);//trova la posizione nell'array dell'elemento che corrisponde al giocatore con il punteggio più alto
                    arraysostitutivo = arraysostitutivo.Where((val, idx) => idx != numIndex).ToArray();//lo rimuove
                }
                else
                {
                    top3GiocatoriNelFile[i] = "Non Registrato,Non Registrato";//quando non ci sono altre righe da confrontare, quindi nessun'altro player
                }
            }
        }
    }
}
