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
    public partial class Schermata_Iniziale : Form
    {
        public Schermata_Iniziale()
        {
            InitializeComponent();
        }

        private void Schermata_Iniziale_Load(object sender, EventArgs e)
        {
            Gioco game = new Gioco();
            game.chiusuraGiocoInnavvertita = true;//per ripristinare l'allert
        }

        private void quitText_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();//termina il programma
        }

        private void startText_MouseClick(object sender, MouseEventArgs e)
        {
            int y = schermataPreLobby.Location.Y;

            backButton.Visible = true;
            fastMatchButton.Visible = true;
            fullMatchButton.Visible = true;
            schermataPreLobby.Location = new Point(880, y);
            startText.Visible = false;
            settingsText.Visible = false;
            quitText.Visible = false;
        }

        public bool sezione = false; //true = seconda sezione, ovvero schermata di scelta tra singleplayer e multiplayer
                                     //false = prima sezione, ovvero schermata di scelta delle modalità di gioco
        private void backButton_Click(object sender, EventArgs e)
        {
            int y = schermataPreLobby.Location.Y;
            int y2 = backButton.Location.Y;

            if(sezione == false)
            {
                backButton.Visible = false;
                fastMatchButton.Visible = false;
                fullMatchButton.Visible = false;
                schermataPreLobby.Location = new Point(1265, y);
                startText.Visible = true;
                settingsText.Visible = true;
                quitText.Visible = true;
            }
            else
            {
                fastMatchButton.Visible = true;
                fullMatchButton.Visible = true;
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
            fullMatchButton.Visible = false;
            singlePlayerButton.Visible = true;
            multiplayerButton.Visible = true;
        }

        private void fullMatchButton_Click(object sender, EventArgs e)
        {
            sezione = true;
            fastMatchButton.Visible = false;
            fullMatchButton.Visible = false;
            singlePlayerButton.Visible = true;
            multiplayerButton.Visible = true;
            modalità = true;
        }

        public bool multigiocatore = false; //false = giocatore singolo
                                            //true = multigiocatore
        private void singlePlayerButton_Click(object sender, EventArgs e)
        {
            //ottiene la posizione del form
            Schermata_Iniziale schInizialeLocationPoint_pt = new Schermata_Iniziale();
            Point schermataIniziale_pt = new Point(schInizialeLocationPoint_pt.Left - 10, schInizialeLocationPoint_pt.Top - 30); //il "-10"e il "- 30" servono per rendere a livello estetico più precisa l'apparizione dell'altro form

            //traduce la posizione della finestra in coordinate dello schermo
            Point schInizialeLocationScreen_pt = this.PointToScreen(schermataIniziale_pt);//converte il valore della posizione della finestra, in coordinate nello schermo del computer

            Gioco game = new Gioco();//creo l'oggetto
            game.Location = schInizialeLocationScreen_pt;//assegna la posizione dell'attuale form a quello "Gioco"
            game.Show();//mostra l'altro form
            this.Hide();//nasconde l'attuale form
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            multigiocatore = true;
            Schermata_Iniziale schInizialeLocationPoint_pt = new Schermata_Iniziale();
            Point schermataIniziale_pt = new Point(schInizialeLocationPoint_pt.Left - 10, schInizialeLocationPoint_pt.Top - 30);

            Point schInizialeLocationScreen_pt = this.PointToScreen(schermataIniziale_pt);

            Gioco game = new Gioco();
            game.Location = schInizialeLocationScreen_pt;
            game.Show();
            this.Hide();
        }
    }
}
