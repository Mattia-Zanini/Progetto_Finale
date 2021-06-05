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
        }

        private void showLoginLayout()
        {
            player1.Visible = true;
            usernameLabel.Visible = true; usernameTextBox.Visible = true;
            loginButton.Visible = true;
            loginAccountLabel.Visible = true;
            avvisoNumeroMinimoCaratteriDaInserire.Visible = true;
            backLabel.Visible = true;
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
            //assegna i nomi dei due giocatori
            Program.nomeGiocatore1 = Giocatore1;
            Program.nomeGiocatore2 = Giocatore2;

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
            this.CenterToScreen(); Giocatore1 = ""; Giocatore2 = "";
            showLoginLayout();
        }

        private void prePartita()//modifica il layout della schermata, quando entrambi i giocaotir hanno scritto uno username
        {
            this.CenterToScreen();           
            startMatchLabel.Visible = true; yesStartMatch.Visible = true; noStartMatch.Visible = true;           
            backLabel.Visible = false;
            player2.Visible = false;
            avvisoNumeroMinimoCaratteriDaInserire.Visible = false;
            usernameLabel.Visible = false; usernameTextBox.Visible = false;           
            loginAccountLabel.Visible = false; loginButton.Visible = false;
        }

        string Giocatore1 = "", Giocatore2 = "";
        string nomePlayerGiausato = "";
        private void loginButton_Click(object sender, EventArgs e)//quando viene cliccato il pulsante login
        {
            if (player1.Visible)
            {
                if(usernameTextBox.Text != "" || usernameTextBox.Text.Length > 3)
                {
                    nomePlayerGiausato = usernameTextBox.Text;
                    Giocatore1 = usernameTextBox.Text;
                    usernameTextBox.Clear();
                    player1.Visible = false;
                    player2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Devi inserire almeno 4 caratteri");
                }
            }
            else
            {
                if (usernameTextBox.Text == nomePlayerGiausato)
                {
                    MessageBox.Show("É già entrato un utente con questo identico nome, cambialo");
                    usernameTextBox.Clear();
                }
                else if(usernameTextBox.Text != "" || usernameTextBox.Text.Length > 3)
                {
                    Giocatore2 = usernameTextBox.Text;
                    usernameTextBox.Clear();
                    prePartita();
                }
                else
                {
                    MessageBox.Show("Devi inserire almeno 4 caratteri");
                }
            }
        }
    }
}
