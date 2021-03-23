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
            
        }

        private void quitText_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();//termina il programma
        }

        private void startText_MouseClick(object sender, MouseEventArgs e)
        {
            //// Ottiene la posizione del form
            //Schermata_Iniziale prova = new Schermata_Iniziale();
            //Point schermataIniziale_pt = new Point(prova.Left - 10, prova.Top - 30); //il "-10"e il "- 30" servono per rendere a livello estetico più precisa l'apparizione dell'altro form

            //// Translate into the screen coordinate system.
            //Point screen_pt = this.PointToScreen(schermataIniziale_pt);//converte il valore della posizione della finestra, in coordinate nello schermo del computer

            //Gioco game = new Gioco();//creo l'oggetto
            //game.Location = screen_pt;//assegna la posizione dell'attuale form a quello "Gioco"
            //game.Show();//mostra l'altro form
            //this.Hide();//nasconde l'attuale form

            int y = schermataPreLobby.Location.Y;
            int y2 = backButton.Location.Y;

            backButton.Visible = true;
            fastMatchButton.Visible = true;
            fullMatchButton.Visible = true;
            schermataPreLobby.Location = new Point(880, y);
            startText.Visible = false;
            settingsText.Visible = false;
            quitText.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            int y = schermataPreLobby.Location.Y;
            int y2 = backButton.Location.Y;

            backButton.Visible = false;
            fastMatchButton.Visible = false;
            fullMatchButton.Visible = false;
            schermataPreLobby.Location = new Point(1265, y);
            startText.Visible = true;
            settingsText.Visible = true;
            quitText.Visible = true;
        }
    }
}
