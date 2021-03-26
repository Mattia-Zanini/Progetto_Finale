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
            fullMatchButton.Visible = true;
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
                fullMatchButton.Visible = false;
                schermataPreLobby.Location = new Point(1265, schermataPreLobby.Location.Y);
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
            schermataSuccessiva();
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            multigiocatore = true;
            schermataSuccessiva();
        }

        public void schermataSuccessiva()
        {
            titoloGioco1.Visible = false;
            titoloGioco2.Visible = false;
            backButton.Visible = false;
            fastMatchButton.Visible = false;
            fullMatchButton.Visible = false;
            singlePlayerButton.Visible = false;
            multiplayerButton.Visible = false;
            sezione = false;
            schermataPreLobby.Location = new Point(1265, schermataPreLobby.Location.Y);

            this.BackgroundImage = null;
            this.BackgroundImage = Properties.Resources.Hyper_Battleship_Schermata_Gioco_Piccola;
            alreadyExistPlayerButton.Visible = true;
            newPlayerButton.Visible = true;
            backButtonGame.Visible = true;
            preLobby();
        }

        //////////////////////PRE-PARTITA//////////////////////

        public static string playerStats = @"statisticheGiocatori.txt";
        public static string playerStatsFile = AppDomain.CurrentDomain.BaseDirectory + playerStats;
        private void preLobby()
        {
            if (!File.Exists(playerStatsFile))//controlla che il file non sia presente
            {
                using (StreamWriter sw = File.CreateText(playerStatsFile))//crea il file
                {
                }
            }
        }

        public string statoSelezione = "libero";
        private void newPlayerButton_Click_1(object sender, EventArgs e)
        {
            if (statoSelezione == "libero")
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
            else if (statoSelezione == "new_player")
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

        private void alreadyExistPlayerButton_Click_1(object sender, EventArgs e)
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

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            avvisoCredenzialiNonValide.ForeColor = Color.Red;
            controlloGiocatore();
            if (statoSelezione == "already_player")
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
                else if (nomePlayerGiausato == playerNameInsertBox.Text)
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
                        prePartitaLayout = true;
                        if (multigiocatore == true)
                        {
                            preLobbyTextMultiplayer.Visible = true;
                        }
                        else
                        {
                            preLobbyTextSingleplayer.Visible = true;
                        }
                        inizioPartitaButton.Visible = true;
                        quitPreLobbyButton.Visible = true;
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
                        prePartitaLayout = true;
                        if (multigiocatore == true)
                        {
                            preLobbyTextMultiplayer.Visible = true;
                        }
                        else
                        {
                            preLobbyTextSingleplayer.Visible = true;
                        }
                        inizioPartitaButton.Visible = true;
                        quitPreLobbyButton.Visible = true;
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

        public bool prePartitaLayout = false;
        private void inizioPartitaButton_Click_1(object sender, EventArgs e)
        {
            //inizio del gioco
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
            prePartitaLayout = false;
            preLobbyTextMultiplayer.Visible = false;
            preLobbyTextSingleplayer.Visible = false;
            inizioPartitaButton.Visible = false;
            quitPreLobbyButton.Visible = false;
            backButtonGame.Visible = false;

            this.BackgroundImage = null;
            this.BackColor = Color.Black;
        }

        private void quitPreLobbyButton_Click_1(object sender, EventArgs e)
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
            prePartitaLayout = false;
            preLobbyTextMultiplayer.Visible = false;
            preLobbyTextSingleplayer.Visible = false;
            inizioPartitaButton.Visible = false;
            quitPreLobbyButton.Visible = false;
        }

        private void backButtonGame_Click_1(object sender, EventArgs e)
        {
            if (prePartitaLayout == false)
            {
                namePLayerText.Visible = false;
                passwordPlayerText.Visible = false;
                playerNameInsertBox.Visible = false;
                playerNameInsertBox.Clear();
                playerPasswordInsertBox.Visible = false;
                playerPasswordInsertBox.Clear();
                confirmButton.Visible = false;
                player1Picture.Visible = false;
                alreadyExistPlayerButton.Visible = false;
                newPlayerButton.Visible = false;
                avvisoCredenzialiNonValide.Visible = false;
                avvisoCredenzialiNonValide.Text = "";
                giocatore = 0;
                nomePlayerGiausato = "";

                this.BackgroundImage = null;
                this.BackgroundImage = Properties.Resources.Hyper_Battleship_Schermata_Iniziale;
                titoloGioco1.Visible = true;
                titoloGioco2.Visible = true;
                backButtonGame.Visible = false;
                startText.Visible = true;
                settingsText.Visible = true;
                quitText.Visible = true;
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
                prePartitaLayout = false;
                preLobbyTextMultiplayer.Visible = false;
                preLobbyTextSingleplayer.Visible = false;
            }
        }

            /////////////PARTITA/////////////////////
    }
}
