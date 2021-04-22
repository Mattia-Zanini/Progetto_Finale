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
        //percorso dove creare i file con all'interno i nomi utenti e password degli account
        public static string playerStats = @"statisticheGiocatori.txt";
        public static string playerStatsFile = AppDomain.CurrentDomain.BaseDirectory + playerStats;
        public LoginForm()
        {
            InitializeComponent();

            if (!File.Exists(playerStatsFile)) { using (StreamWriter sw = File.CreateText(playerStatsFile)) { } }//cotrnolla se c'è il file nel percorso prestabilito
        }

        /// <summary>
        /// Pulsanti
        /// </summary>
        private void showPassword_CheckedChanged(object sender, EventArgs e)//serve per mostrare il contenuto della texture box (dove si inserisce la password)
        {
            if (showPassword.Checked)
            {
                passwordTextBox.PasswordChar = '\0';//per mostrare quello che vi è scritto nella textbox
            }
            else
            {
                passwordTextBox.PasswordChar = '*';//sostituisce i caratteri all'interno della texturebox con questo simbolo
            }
        }

        public bool playeresistente = false;
        private void playerLabel_Click(object sender, EventArgs e)
        {
            playeresistente = true;
            showLoginLayout();
        }

        //sono tutte funzioni che servono a mostrare cosa fanno le 3 opzioni per il login nella finsetra, con il semplice muovere del mouse
        private void playerLabel_MouseEnter(object sender, EventArgs e)
        {
            playerLabel2.Visible = true; playerLabel3.Visible = true;           
        }
        private void playerLabel_MouseLeave(object sender, EventArgs e)
        {
            playerLabel2.Visible = false; playerLabel3.Visible = false;           
        }

        private void newPlayerLabel_Click(object sender, EventArgs e)
        {
            showLoginLayout();
        }
        private void newPlayerLabel_MouseEnter(object sender, EventArgs e)
        {
            newPlayerLabel2.Visible = true;
        }
        private void newPlayerLabel_MouseLeave(object sender, EventArgs e)
        {
            newPlayerLabel2.Visible = false;
        }

        //per i giocatori a cui non si vuole salvare i progessi
        public bool pWOS = false; //playerWithOutScore
        private void playerWithOutScore_Click(object sender, EventArgs e)
        {
            pWOS = true;
            showLoginLayout();
            passwordLabel.Visible = false; passwordTextBox.Visible = false; showPassword.Visible = false;           
        }
        private void playerWithOutScore_MouseEnter(object sender, EventArgs e)
        {
            playerWithOutScoreLabel.Visible = true;
        }
        private void playerWithOutScore_MouseLeave(object sender, EventArgs e)
        {
            playerWithOutScoreLabel.Visible = false;
        }

        //per tornare indietro nelle schermate
        private void backLabel_Click(object sender, EventArgs e)
        {
            pWOS = false;
            player1.Visible = false; player2.Visible = false;           
            usernameLabel.Visible = false; usernameTextBox.Visible = false;           
            passwordLabel.Visible = false; passwordTextBox.Visible = false;
            showPassword.Visible = false;
            loginButton.Visible = false; loginAccountLabel.Visible = false;
            backLabel.Visible = false;
            alertLoginAccount.Visible = false;
            playerLabel.Visible = true; newPlayerLabel.Visible = true; playerWithOutScore.Visible = true; exitLoginButton.Visible = true;            
            if(giocatore >= 1)
            {
                giocatore--;
            }
        }
        private void exitLoginButton_Click(object sender, EventArgs e)//torna al primo form (schermata iniziale)
        {
            Schermata_Iniziale f1 = new Schermata_Iniziale();
            f1.Show();
            this.Close();//chiude il form, non lo nasconde
        }

        private void loginButton_Click(object sender, EventArgs e)//quando viene cliccato il pulsante login
        {
            if (!pWOS)
            {
                accountChecker();//funzione che controlla "nel file" se l'utente esiste, se sono corrette le credenziali, se non ha inserito nulla nelle texturebox, ecc....
            }
            else if(pWOS && giocatore == 0)
            {
                giocatore++;
                Giocatore1 = usernameTextBox.Text;
                usernameTextBox.Clear();
                player1.Visible = false; player2.Visible = true;               
            }
            else if(pWOS && giocatore == 1) //nel caso tutti e due i giocatori sono pronti
            {
                Giocatore2 = usernameTextBox.Text;
                if(Giocatore1 != Giocatore2)
                {
                    prePartita();
                }
                else
                {
                    //nel caso i 2 giocatori inseriscono lo stesso nome
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Non è possibile giocare con 2 player";
                    alertLoginAccount.Text += Environment.NewLine;
                    alertLoginAccount.Text += "con lo stesso nome";
                    alertLoginAccount.Text += Environment.NewLine;
                    alertLoginAccount.Text += "Cambia username";
                }
            }
        }

        private void yesStartMatch_Click(object sender, EventArgs e)
        {
            //comincia la partita
            Gameplay f3 = new Gameplay();
            f3.Show();
            this.Close();
        }

        private void noStartMatch_Click(object sender, EventArgs e)//reinizializza tutte le variabili per permettere agli utenti di rifare il login da capo
        {
            startMatchLabel.Visible = false;
            yesStartMatch.Visible = false;
            noStartMatch.Visible = false;
            startMatchLabel.Visible = false;
            MessageBox.Show("Dovrai riaccedere agli account");
            this.Height = 400; this.CenterToScreen(); giocatore = 0; Giocatore1 = ""; Giocatore2 = "";
            exitLoginButton.Visible = true; playerLabel.Visible = true; newPlayerLabel.Visible = true;
            playerWithOutScore.Visible = true;
        }

        /// <summary>
        /// Funzioni
        /// </summary>
        public void showLoginLayout()
        {
            player1.Visible = true;
            usernameLabel.Visible = true; usernameTextBox.Visible = true;
            passwordLabel.Visible = true; passwordTextBox.Visible = true;
            showPassword.Visible = true; loginButton.Visible = true; backLabel.Visible = true;
            loginAccountLabel.Visible = true;
            playerLabel.Visible = false;
            newPlayerLabel.Visible = false; playerWithOutScore.Visible = false; exitLoginButton.Visible = false;
        }

        public string Giocatore1, Giocatore2;
        public byte giocatore = 0;
        public void accountChecker()
        {
            //variabili che permettono il controllo delle credenziali
            bool correctPlayerName = false, correctPlayerPassword = false;
            string nomePlayerGiausato = "";
            alertLoginAccount.ForeColor = Color.Red;
            controlloGiocatore(ref correctPlayerName, ref correctPlayerPassword, ref nomePlayerGiausato);
            if (playeresistente == true)//nel caso esista già l'account a cui si sta provando ad accedere
            {
                if (usernameTextBox.Text == "")//texbox username vuota
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Inserire una nome utente valido";
                }
                else if (passwordTextBox.Text == "")//texbox della password vuota
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Inserire delle credenziali valide";
                }
                else if (correctPlayerName == true && correctPlayerPassword == false)//utente corretto, esistente, ma password errata
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Password Errata";
                    passwordTextBox.Clear();
                }
                else if (nomePlayerGiausato == usernameTextBox.Text)//nome utente uguale a quello già registrato nell'istanza della pre-lobby
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Sei già entrato con questo utente";
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                }
                else if (correctPlayerName == true && correctPlayerPassword == true)//nome utente e password corretti e non già loggati
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.ForeColor = Color.Lime;
                    alertLoginAccount.Text = "Utente trovato";
                    if (giocatore == 0)//per evitare l'accesso a più untenti della stessa pre-lobby
                    {
                        nomePlayerGiausato = usernameTextBox.Text;
                        usernameTextBox.Clear(); passwordTextBox.Clear();
                        player1.Visible = false; player2.Visible = true;                       
                        giocatore++;
                    }
                }
                else//utente non registrato
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Utente inesistente";
                    usernameTextBox.Clear(); passwordTextBox.Clear();                   
                }
            }
        }
        public void controlloGiocatore(ref bool correctPlayerName, ref bool correctPlayerPassword, ref string nomePlayerGiausato)
        {
            correctPlayerName = false;
            correctPlayerPassword = false;
            var giocatoriPresenti = File.ReadLines(playerStatsFile);//legge le credenziali slavate nel file .txt nel percorso prestabilito
            for (int i = 0; i < giocatoriPresenti.ToArray().Length; i++)//separa rispettivamente i nomi utente e le loro password
            {
                string[] elemento = giocatoriPresenti.ToArray()[i].Split(',');

                if (usernameTextBox.Text == elemento[0])
                {
                    correctPlayerName = true;
                }
                if (usernameTextBox.Text == elemento[1])
                {
                    correctPlayerPassword = true;
                }
            }
            if (correctPlayerName == true && playeresistente == false)//controlla se è già registrato un determinato utente
            {
                alertLoginAccount.Visible = true;
                alertLoginAccount.ForeColor = Color.Red;
                alertLoginAccount.Text = "Utente già esistente";
                usernameTextBox.Clear(); passwordTextBox.Clear();               
            }
            else if (usernameTextBox.Text == "" && playeresistente == false)//controlla se la texturebox è vuota
            {
                alertLoginAccount.Visible = true;
                alertLoginAccount.Text = "Inserire una nome utente valido";
            }
            else if (passwordTextBox.Text == "" && playeresistente == false)
            {
                alertLoginAccount.Visible = true;
                alertLoginAccount.Text = "Inserire delle credenziali valide";
            }
            else if (playeresistente == false)//nel caso non eista già un determinato utente, quindi è "nuovo"
            {
                string[] giocatoriFile = new string[giocatoriPresenti.ToArray().Length + 1];
                Array.Copy(giocatoriPresenti.ToArray(), giocatoriFile, giocatoriPresenti.ToArray().Length);
                giocatoriFile[giocatoriFile.Length - 1] = $"{usernameTextBox.Text},{passwordTextBox.Text}";
                File.WriteAllLines(playerStatsFile, giocatoriFile);
                alertLoginAccount.Visible = true;
                alertLoginAccount.ForeColor = Color.Green;
                alertLoginAccount.Text = "Nuovo utente registrato";
                usernameTextBox.Clear(); passwordTextBox.Clear();               
                if (giocatore == 0)//per evitare di accedere allo stesso account da parte di più utenti nella stessa pre-lobby
                {
                    nomePlayerGiausato = usernameTextBox.Text;
                    usernameTextBox.Clear(); passwordTextBox.Clear();                   
                    player1.Visible = false; player2.Visible = true;                   
                    giocatore++;
                }
            }
        }

        public void prePartita() //riduce il form ad una grandezza minimale mostrando ai giocatori una scelta
        {
            this.Height = 250; this.CenterToScreen();           
            startMatchLabel.Visible = true; yesStartMatch.Visible = true; noStartMatch.Visible = true;           
            backLabel.Visible = false;
            player2.Visible = false;
            usernameLabel.Visible = false; usernameTextBox.Visible = false;           
            passwordLabel.Visible = false; passwordTextBox.Visible = false;
            loginAccountLabel.Visible = false; loginButton.Visible = false;           
            showPassword.Visible = false;
        }
    }
}
