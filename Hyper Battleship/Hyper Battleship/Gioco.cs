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
    public partial class Gioco : Form
    {
        public Gioco()
        {
            InitializeComponent();
        }

        public bool chiusuraGiocoInnavvertita = true;
        private void Gioco_Deactivate(object sender, EventArgs e)
        {
            if(chiusuraGiocoInnavvertita == true)//per tornare alla schermata principale senza terminare il programma
            {
                Application.Exit();
            }
        }

        public static string playerStats = @"statisticheGiocatori.txt";
        public static string playerStatsFile = AppDomain.CurrentDomain.BaseDirectory + playerStats;
        private void Hyper_Battleship_Load(object sender, EventArgs e)
        {
            if (!File.Exists(playerStatsFile))//controlla che il file non sia presente
            {
                using (StreamWriter sw = File.CreateText(playerStatsFile))//crea il file
                {

                }
            }
        }

        public string statoSelezione = "libero";
        private void newPlayerButton_Click(object sender, EventArgs e)
        {
            if(statoSelezione == "libero")
            {
                statoSelezione = "new_player";
                newPlayerButton.ForeColor = SystemColors.InactiveCaption;

                namePLayerText.Visible = true;
                passwordPlayerText.Visible = true;
                playerNameInsertBox.Visible = true;
                playerPasswordInsertBox.Visible = true;
                confirmButton.Visible = true;
            }
            else if(statoSelezione == "new_player")
            {
                newPlayerButton.ForeColor = SystemColors.ControlText;

                namePLayerText.Visible = false;
                passwordPlayerText.Visible = false;
                playerNameInsertBox.Visible = false;
                playerPasswordInsertBox.Visible = false;
                confirmButton.Visible = false;
                statoSelezione = "libero";
                avvisoCredenzialiNonValide.Text = "";
            }
        }

        private void alreadyExistPlayerButton_Click(object sender, EventArgs e)
        {
            if (statoSelezione == "libero")
            {
                statoSelezione = "already_player";
                alreadyExistPlayerButton.ForeColor = SystemColors.InactiveCaption;

                namePLayerText.Visible = true;
                passwordPlayerText.Visible = true;
                playerNameInsertBox.Visible = true;
                playerPasswordInsertBox.Visible = true;
                confirmButton.Visible = true;
            }
            else if(statoSelezione == "already_player")
            {
                alreadyExistPlayerButton.ForeColor = SystemColors.ControlText;

                namePLayerText.Visible = false;
                passwordPlayerText.Visible = false;
                playerNameInsertBox.Visible = false;
                playerPasswordInsertBox.Visible = false;
                confirmButton.Visible = false;
                statoSelezione = "libero";
                avvisoCredenzialiNonValide.Text = "";
            }
        }

        public bool correctPlayerName = false, correctPlayerPassword = false;

        public void controlloGiocatore()
        {
            correctPlayerName = false;
            correctPlayerPassword = false;
            if (statoSelezione == "new_player")
            {
                var giocatoriPresenti = File.ReadLines(playerStatsFile);
                string[] giocatoriFile = new string[giocatoriPresenti.ToArray().Length + 1];

                giocatoriFile[giocatoriFile.Length - 1] = $"{playerNameInsertBox.Text},{playerPasswordInsertBox.Text}";
                File.WriteAllLines(playerStatsFile, giocatoriFile);
                correctPlayerName = true;
                correctPlayerPassword = true;
            }
            else if(statoSelezione == "already_player")
            {
                var giocatoriPresenti = File.ReadLines(playerStatsFile);
                string[] giocatoriFile = new string[giocatoriPresenti.ToArray().Length];

                for (int i = 0; i < giocatoriPresenti.ToArray().Length; i++) //ciclo che divide e inserisce il nome e cognome dei dipendenti dal file esterno all'array Nome_Dipendente
                {
                    giocatoriFile[i] = giocatoriPresenti.ToArray()[i]; //elenco_dipendenti è uguale alla righa di data
                    string[] subs = giocatoriFile[i].Split(','); //utilizzo del comando line.split
                                                                 //Nome_Dipendenti[i] = $"{subs[0]} {subs[1]}"; //nome_dipendenti è uguale alle posizione 0 e 1 di elenco_dipendenti

                    if (playerNameInsertBox.Text == subs[0])
                    {
                        correctPlayerName = true;
                    }
                    if (playerPasswordInsertBox.Text == subs[1])
                    {
                        correctPlayerPassword = true;
                    }
                }

            }

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            avvisoCredenzialiNonValide.ForeColor = Color.Red;
            controlloGiocatore();
            if (playerNameInsertBox.Text == "")
            {
                avvisoCredenzialiNonValide.Text = "Inserire una nome utente valido";
            }
            else if(playerPasswordInsertBox.Text == "")
            {
                avvisoCredenzialiNonValide.Text = "Inserire delle credenziali valide";
            }
            else if(correctPlayerName == true && correctPlayerPassword == false)
            {
                avvisoCredenzialiNonValide.Text = "Password Errata";
                playerPasswordInsertBox.Clear();
            }
            else if(correctPlayerName == true && correctPlayerPassword == true)
            {
                avvisoCredenzialiNonValide.ForeColor = Color.Lime;
                avvisoCredenzialiNonValide.Text = "Utente trovato";
            }
            else
            {
                avvisoCredenzialiNonValide.Text = "Utente inesistente";
                playerNameInsertBox.Clear();
                playerPasswordInsertBox.Clear();
            }
        }

        private void backButtonGame_Click(object sender, EventArgs e)
        {
            chiusuraGiocoInnavvertita = false;
            //ottiene la posizione del form
            Gioco gameLocationPoint_pt = new Gioco();
            Point gameLocation_pt = new Point(gameLocationPoint_pt.Left - 10, gameLocationPoint_pt.Top - 30); //il "-10"e il "- 30" servono per rendere a livello estetico più precisa l'apparizione dell'altro form

            //traduce la posizione della finestra in coordinate dello schermo
            Point gameLocationScreen_pt = this.PointToScreen(gameLocation_pt);//converte il valore della posizione della finestra, in coordinate nello schermo del computer

            Schermata_Iniziale schIniziale = new Schermata_Iniziale();
            schIniziale.Location = gameLocationScreen_pt;//assegna la posizione dell'attuale form a quello "Gioco"
            schIniziale.Show();//mostra l'altro form
            this.Hide();//nasconde l'attuale form
        }
    }
}
