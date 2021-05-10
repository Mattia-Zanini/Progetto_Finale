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
        
        public bool chiusuraApplicazioneInavveritaF1 = true;
        private void Schermata_Iniziale_Load(object sender, EventArgs e)
        {
        }
        private void Schermata_Iniziale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(chiusuraApplicazioneInavveritaF1 == true)
            {
                Application.Exit();
            }
        }

        private void quitText_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();//termina il programma
        }

        private void startText_MouseClick(object sender, MouseEventArgs e)//mostra il pannello nero a destra della finestra per selezionare le opzioni per settare la partita
        {
            backButton.Visible = true;
            fastMatchButton.Visible = true;
            normalMatchButton.Visible = true;
            schermataPreLobby.Location = new Point(880, schermataPreLobby.Location.Y);
            startText.Visible = false;
            settingsText.Visible = false;
            quitText.Visible = false;
        }

        public bool sezione = false; //true = seconda sezione, ovvero schermata di scelta tra singleplayer e multiplayer
                                     //false = prima sezione, ovvero schermata di scelta delle modalità di gioco
        private void backButton_Click(object sender, EventArgs e)//per tornare indietro con le opzioni o a tornare alla schermata iniziale
        {
            if(sezione == false)
            {
                backButton.Visible = false;
                fastMatchButton.Visible = false;
                normalMatchButton.Visible = false;
                schermataPreLobby.Location = new Point(1265, schermataPreLobby.Location.Y);
                startText.Visible = true;
                settingsText.Visible = true;
                quitText.Visible = true;
            }
            else
            {
                fastMatchButton.Visible = true;
                normalMatchButton.Visible = true;
                singlePlayerButton.Visible = false;
                multiplayerButton.Visible = false;
                sezione = false;
            }
        }
        private void fastMatchButton_Click(object sender, EventArgs e)//per impostare la partita veloce
        {
            sezione = true;
            fastMatchButton.Visible = false;
            normalMatchButton.Visible = false;
            singlePlayerButton.Visible = true;
            multiplayerButton.Visible = true;
        }

        private void normalMatchButton_Click(object sender, EventArgs e)//per impostare la partita normale
        {
            sezione = true;
            fastMatchButton.Visible = false;
            normalMatchButton.Visible = false;
            singlePlayerButton.Visible = true;
            multiplayerButton.Visible = true;
            Program.modalità = true;
        }

        private void singlePlayerButton_Click(object sender, EventArgs e)
        {
            schermataSuccessiva();
        }

        private void multiplayerButton_Click(object sender, EventArgs e)//imposta la partita multigiocatore
        {
            Program.multigiocatore = true;
            schermataSuccessiva();
        }

        public void schermataSuccessiva()//per mostrare la schermata del login (secondo form)
        {
            //reinizializza alcune picturebox e variabili
            titoloGioco1.Visible = false;
            titoloGioco2.Visible = false;
            backButton.Visible = false;
            fastMatchButton.Visible = false;
            normalMatchButton.Visible = false;
            singlePlayerButton.Visible = false;
            multiplayerButton.Visible = false;
            sezione = false;
            schermataPreLobby.Location = new Point(1265, schermataPreLobby.Location.Y);

            LoginForm f2 = new LoginForm();//crea un oggetto del secondo form
            f2.Show();//mostra il secondo form
            this.Hide();//nasconde il form
        }
    }
}
