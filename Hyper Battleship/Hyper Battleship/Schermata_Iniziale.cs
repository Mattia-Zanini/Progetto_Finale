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

        private void startText_MouseClick(object sender, MouseEventArgs e)
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
        private void backButton_Click(object sender, EventArgs e)
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

        public bool modalità = false; //false = partita veloce
                                      //true = partita normale
        private void fastMatchButton_Click(object sender, EventArgs e)
        {
            sezione = true;
            fastMatchButton.Visible = false;
            normalMatchButton.Visible = false;
            singlePlayerButton.Visible = true;
            multiplayerButton.Visible = true;
        }

        private void normalMatchButton_Click(object sender, EventArgs e)
        {
            sezione = true;
            fastMatchButton.Visible = false;
            normalMatchButton.Visible = false;
            singlePlayerButton.Visible = true;
            multiplayerButton.Visible = true;
            modalitàAssign();
        }
        public bool modalitàAssign()
        {
            modalità = true;
            return modalità;
        }

        public bool multigiocatore = false; //false = giocatore singolo
                                            //true = multigiocatore
        private void singlePlayerButton_Click(object sender, EventArgs e)
        {
            schermataSuccessiva();
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            multigiocatoreAssign();
            schermataSuccessiva();
        }
        public bool multigiocatoreAssign()
        {
            multigiocatore = true;
            return multigiocatore;
        }

        public void schermataSuccessiva()
        {
            titoloGioco1.Visible = false;
            titoloGioco2.Visible = false;
            backButton.Visible = false;
            fastMatchButton.Visible = false;
            normalMatchButton.Visible = false;
            singlePlayerButton.Visible = false;
            multiplayerButton.Visible = false;
            sezione = false;
            schermataPreLobby.Location = new Point(1265, schermataPreLobby.Location.Y);

            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Hide();
        }
    }
}
