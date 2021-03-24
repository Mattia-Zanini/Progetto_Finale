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

        public bool chiusuraApplicazioneInavveritaF2 = true;//per terminare il programma solo quando si chiude la finestra
        private void Gioco_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chiusuraApplicazioneInavveritaF2 == true)
            {
                Application.Exit();
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
                if (giocatore == 1)
                {
                    player1Picture.Visible = false;
                    player2Picture.Visible = true;
                }
                else
                {
                    player1Picture.Visible = true;
                    player2Picture.Visible = false;
                }
            }
            else if(statoSelezione == "new_player")
            {
                newPlayerButton.ForeColor = SystemColors.ControlText;

                namePLayerText.Visible = false;
                passwordPlayerText.Visible = false;
                playerNameInsertBox.Visible = false;
                playerPasswordInsertBox.Visible = false;
                confirmButton.Visible = false;
                player1Picture.Visible = false;
                player2Picture.Visible = false;
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
                if(giocatore == 1)
                {
                    player1Picture.Visible = false;
                    player2Picture.Visible = true;
                }
                else
                {
                    player1Picture.Visible = true;
                    player2Picture.Visible = false;
                }
            }
            else if (statoSelezione == "already_player")
            {
                alreadyExistPlayerButton.ForeColor = SystemColors.ControlText;

                namePLayerText.Visible = false;
                passwordPlayerText.Visible = false;
                playerNameInsertBox.Visible = false;
                playerPasswordInsertBox.Visible = false;
                confirmButton.Visible = false;
                player1Picture.Visible = false;
                player2Picture.Visible = false;
                statoSelezione = "libero";
                avvisoCredenzialiNonValide.Text = "";
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            avvisoCredenzialiNonValide.ForeColor = Color.Red;
            controlloGiocatore();
            if(statoSelezione == "already_player")
            {
                if (playerNameInsertBox.Text == "")
                {
                    avvisoCredenzialiNonValide.Text = "Inserire una nome utente valido";
                }
                else if (playerPasswordInsertBox.Text == "")
                {
                    avvisoCredenzialiNonValide.Text = "Inserire delle credenziali valide";
                }
                else if (correctPlayerName == true && correctPlayerPassword == false)
                {
                    avvisoCredenzialiNonValide.Text = "Password Errata";
                    playerPasswordInsertBox.Clear();
                }
                else if(nomePlayerGiausato == playerNameInsertBox.Text)
                {
                    avvisoCredenzialiNonValide.Text = "Sei già entrato con questo utente";
                }
                else if (correctPlayerName == true && correctPlayerPassword == true)
                {
                    avvisoCredenzialiNonValide.ForeColor = Color.Lime;
                    avvisoCredenzialiNonValide.Text = "Utente trovato";
                    giocatore++;
                    if (giocatore == 1)
                    {
                        nomePlayerGiausato = playerNameInsertBox.Text;
                        playerNameInsertBox.Clear();
                        playerPasswordInsertBox.Clear();
                        player1Picture.Visible = false;
                        player2Picture.Visible = true;
                    }
                    else if(giocatore == 2)//nel caso tutti e due i giocatori sono pronti
                    {
                        namePLayerText.Visible = false;
                        passwordPlayerText.Visible = false;
                        playerNameInsertBox.Visible = false;
                        playerPasswordInsertBox.Visible = false;
                        confirmButton.Visible = false;
                        player1Picture.Visible = false;
                        player2Picture.Visible = false;
                        alreadyExistPlayerButton.Visible = false;
                        newPlayerButton.Visible = false;
                        avvisoCredenzialiNonValide.Visible = false;
                        preLobby = true;
                        Schermata_Iniziale f1 = new Schermata_Iniziale();
                        if (f1.multigiocatoreValore() == true)
                        {
                            preLobbyTextMultiplayer.Visible = true;
                        }
                        else
                        {
                            preLobbyTextSingleplayer.Visible = true;
                        }
                    }
                }
                else
                {
                    avvisoCredenzialiNonValide.Text = "Utente inesistente";
                    playerNameInsertBox.Clear();
                    playerPasswordInsertBox.Clear();
                }
            }
        }

        public bool correctPlayerName = false, correctPlayerPassword = false;
        public byte giocatore = 0;
        public string nomePlayerGiausato;
        public void controlloGiocatore()
        {
            correctPlayerName = false;
            correctPlayerPassword = false;
            if (statoSelezione == "new_player")
            {
                var giocatoriPresenti = File.ReadLines(playerStatsFile);

                for (int i = 0; i < giocatoriPresenti.ToArray().Length; i++)
                {
                    string[] elemento = giocatoriPresenti.ToArray()[i].Split(',');

                    if (playerNameInsertBox.Text == elemento[0])
                    {
                        correctPlayerName = true;
                    }
                    if (playerPasswordInsertBox.Text == elemento[1])
                    {
                        correctPlayerPassword = true;
                    }
                }
                if (correctPlayerName == true)
                {
                    avvisoCredenzialiNonValide.ForeColor = Color.Red;
                    avvisoCredenzialiNonValide.Text = "Utente già esistente";
                    playerNameInsertBox.Clear();
                    playerPasswordInsertBox.Clear();
                }
                else if (playerNameInsertBox.Text == "")
                {
                    avvisoCredenzialiNonValide.Text = "Inserire una nome utente valido";
                }
                else if (playerPasswordInsertBox.Text == "")
                {
                    avvisoCredenzialiNonValide.Text = "Inserire delle credenziali valide";
                }
                else
                {
                    string[] giocatoriFile = new string[giocatoriPresenti.ToArray().Length + 1];
                    Array.Copy(giocatoriPresenti.ToArray(), giocatoriFile, giocatoriPresenti.ToArray().Length);
                    giocatoriFile[giocatoriFile.Length - 1] = $"{playerNameInsertBox.Text},{playerPasswordInsertBox.Text}";
                    File.WriteAllLines(playerStatsFile, giocatoriFile);
                    avvisoCredenzialiNonValide.ForeColor = Color.Green;
                    avvisoCredenzialiNonValide.Text = "Nuovo utente registrato";
                    playerNameInsertBox.Clear();
                    playerPasswordInsertBox.Clear();
                    giocatore++;
                    if (giocatore == 1)
                    {
                        nomePlayerGiausato = playerNameInsertBox.Text;
                        playerNameInsertBox.Clear();
                        playerPasswordInsertBox.Clear();
                        player1Picture.Visible = false;
                        player2Picture.Visible = true;
                    }
                    else if (giocatore == 2)//nel caso tutti e due i giocatori sono pronti
                    {
                        namePLayerText.Visible = false;
                        passwordPlayerText.Visible = false;
                        playerNameInsertBox.Visible = false;
                        playerPasswordInsertBox.Visible = false;
                        confirmButton.Visible = false;
                        player1Picture.Visible = false;
                        player2Picture.Visible = false;
                        alreadyExistPlayerButton.Visible = false;
                        newPlayerButton.Visible = false;
                        avvisoCredenzialiNonValide.Visible = false;
                        preLobby = true;
                        Schermata_Iniziale f1 = new Schermata_Iniziale();
                        if (f1.multigiocatore == true)
                        {
                            preLobbyTextMultiplayer.Visible = true;
                        }
                        else
                        {
                            preLobbyTextSingleplayer.Visible = true;
                        }
                    }
                }
            }
            else if (statoSelezione == "already_player")
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

        public bool preLobby = false;
        private void backButtonGame_Click(object sender, EventArgs e)
        {
            if(preLobby == false)
            {
                //ottiene la posizione del form
                Gioco gameLocationPoint_pt = new Gioco();
                Point gameLocation_pt = new Point(gameLocationPoint_pt.Left - 10, gameLocationPoint_pt.Top - 30); //il "-10"e il "- 30" servono per rendere a livello estetico più precisa l'apparizione dell'altro form

                //traduce la posizione della finestra in coordinate dello schermo
                Point gameLocationScreen_pt = this.PointToScreen(gameLocation_pt);//converte il valore della posizione della finestra, in coordinate nello schermo del computer

                Schermata_Iniziale f1 = new Schermata_Iniziale();
                f1.Location = gameLocationScreen_pt;//assegna la posizione dell'attuale form a quello "Gioco"
                f1.Show();//mostra l'altro form
                chiusuraApplicazioneInavveritaF2 = false;
                this.Close();//nasconde l'attuale form
            }
            else
            {
                namePLayerText.Visible = true;
                passwordPlayerText.Visible = true;
                playerNameInsertBox.Visible = true;
                playerNameInsertBox.Clear();
                playerPasswordInsertBox.Visible = true;
                playerPasswordInsertBox.Clear();
                confirmButton.Visible = true;
                player1Picture.Visible = true;
                alreadyExistPlayerButton.Visible = true;
                newPlayerButton.Visible = true;
                avvisoCredenzialiNonValide.Visible = true;
                avvisoCredenzialiNonValide.Text = "";
                giocatore = 0;
                nomePlayerGiausato = "";
                preLobby = false;
                preLobbyTextMultiplayer.Visible = false;
                preLobbyTextSingleplayer.Visible = false;
            }
        }
    }
}
