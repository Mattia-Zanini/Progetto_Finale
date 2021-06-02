using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Hyper_Battleship
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            showLoginLayout();
            controlloPresenzaFileSalvataggioClassiica();

            /*
            // TAPPA BUCHI MOMENTANEO PER PERMETTERE DI UTILIZZARE IL GIOCO
            //comincia la partita
            Gameplay f3 = new Gameplay();
            Istruzioni f4 = new Istruzioni();
            f3.Show();
            f4.Show();//per mostrare come muovere le navi da posizionare
            this.Hide();
            */
        }

        private void showLoginLayout()
        {
            player1.Visible = true;
            usernameLabel.Visible = true; usernameTextBox.Visible = true;
            loginButton.Visible = true;
            loginAccountLabel.Visible = true;
            avvisoNumeroMinimoCaratteriDaInserire.Visible = true;
        }

        static string nomeFileClassifica = @"ClassificaGiocatori.txt";
        static string percorsoSalvataggioClassificaGiocatori = AppDomain.CurrentDomain.BaseDirectory + nomeFileClassifica;
        private void controlloPresenzaFileSalvataggioClassiica()//cotrnolla se c'è il file nel percorso prestabilito, nel caso non ci sia, il programma lo crea
        {
            if (!File.Exists(percorsoSalvataggioClassificaGiocatori)) { using (StreamWriter sw = File.CreateText(percorsoSalvataggioClassificaGiocatori)) { } }
        }

        //per tornare indietro nelle schermate
        private void backLabel_Click(object sender, EventArgs e)
        {
            if(Giocatore1 == "" && Giocatore2 == "")
            {
                Schermata_Iniziale f1 = new Schermata_Iniziale();
                f1.Show();
                this.Close();
            }
            else if(Giocatore1 != "" && Giocatore2 == "")
            {
                Giocatore1 = "";
                nomePlayerGiausato = "";
                player2.Visible = false;
                player1.Visible = true;
            }
        }

        private void yesStartMatch_Click(object sender, EventArgs e)
        {
            //comincia la partita
            Gameplay f3 = new Gameplay();
            Istruzioni f4 = new Istruzioni();
            f3.Show();
            f4.Show();//per mostrare come muovere le navi da posizionare
            this.Close();
        }

        private void noStartMatch_Click(object sender, EventArgs e)//reinizializza tutte le variabili per permettere agli utenti di rifare il login da capo
        {
            startMatchLabel.Visible = false;
            yesStartMatch.Visible = false;
            noStartMatch.Visible = false;
            startMatchLabel.Visible = false;
            MessageBox.Show("Dovrai riaccedere agli account");
            this.Height = 400; this.CenterToScreen(); Giocatore1 = ""; Giocatore2 = "";
        }

        private void prePartita()//modifica il layout della schermata, quando entrambi i giocaotir hanno scritto uno username
        {
            this.Height = 250; this.CenterToScreen();           
            startMatchLabel.Visible = true; yesStartMatch.Visible = true; noStartMatch.Visible = true;           
            backLabel.Visible = false;
            player2.Visible = false;
            avvisoNumeroMinimoCaratteriDaInserire.Visible = false;
            usernameLabel.Visible = false; usernameTextBox.Visible = false;           
            loginAccountLabel.Visible = false; loginButton.Visible = false;
        }

        string Giocatore1 = "", Giocatore2 = "";
        string nomePlayerGiausato = "";
        bool giocatoreTrovatoInPrecedenza = false;//serve nel caso abbiama già trovato il giocatore, me il suo punteggio è minore del record che quel giocatore aveva fatto in precedenza
        private void loginButton_Click(object sender, EventArgs e)//quando viene cliccato il pulsante login
        {
            if (player1.Visible)
            {
                nomePlayerGiausato = usernameTextBox.Text;
                controlloGiocatoreNellaClassifica(usernameTextBox.Text);
            }
            else
            {
                if (usernameTextBox.Text != nomePlayerGiausato)
                {
                    controlloGiocatoreNellaClassifica(usernameTextBox.Text);
                }
                else
                {
                    MessageBox.Show("É già entrato un utente con questo identico nome, cambialo");
                }
            }
        }

        private void controlloGiocatoreNellaClassifica(string nomeGiocatore)
        {
            if (nomeGiocatore != "" && nomeGiocatore.Length > 3)//controlla se l'utente ha inserito almeno 1 carattere all'interno del nome
            {
                var classifica = File.ReadAllLines(percorsoSalvataggioClassificaGiocatori);
                if (classifica.ToArray().Length != 0)
                {
                    for (int i = 0; i < classifica.ToArray().Length; i++)
                    {
                        string[] dettagligiocatore = classifica[i].Split(',');
                        if (nomeGiocatore == dettagligiocatore[0])
                        {
                            giocatoreTrovatoInPrecedenza = true;
                        }
                        else
                        {
                            if (i == classifica.ToArray().Length - 1 && giocatoreTrovatoInPrecedenza == false)
                            {
                                //nuovoGiocatore(classifica.ToArray());
                            }
                        }
                    }
                }
                else
                {
                    nuovoGiocatore();
                }
            }
            else
            {
                MessageBox.Show("Devi inserire un nome, non lasciare un spazio bianco .-.\nOppure devi inserire un nome di almeno 4 caratteri");
            }
        }

        private void nuovoGiocatore(ref string nomeGiocatore)
        {
            //Array.Resize(ref punteggi, punteggi.Length + 1);
            //punteggi[punteggi.Length - 1] = $"{nomeGiocatore},{score}";
            //File.WriteAllLines(percorsoFileRisultatiPartita, punteggi);
            //Controllonickname.Visible = false;
        }
    }
}
