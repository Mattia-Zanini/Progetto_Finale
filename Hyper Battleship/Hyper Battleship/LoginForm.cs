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
        public static string playerStats = @"statisticheGiocatori.txt";
        public static string playerStatsFile = AppDomain.CurrentDomain.BaseDirectory + playerStats;
        public LoginForm()
        {
            InitializeComponent();

            if (!File.Exists(playerStatsFile)) { using (StreamWriter sw = File.CreateText(playerStatsFile)) { } }
        }

        /// <summary>
        /// Pulsanti
        /// </summary>
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTextBox.PasswordChar = '\0';//per mostrare quello che vi è scritto nella textbox
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        public bool playeresistente = false;
        private void playerLabel_Click(object sender, EventArgs e)
        {
            playeresistente = true;
            showLoginLayout();
        }
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

        private void backLabel_Click(object sender, EventArgs e)
        {
            pWOS = false;
            player1.Visible = false; player2.Visible = false;           
            usernameLabel.Visible = false; usernameTextBox.Visible = false;           
            passwordLabel.Visible = false; passwordTextBox.Visible = false;
            showPassword.Visible = false;
            loginButton.Visible = false; loginAccountLabel.Visible = false;
            backLabel.Visible = false;           
            playerLabel.Visible = true; newPlayerLabel.Visible = true; playerWithOutScore.Visible = true; exitLoginButton.Visible = true;            
            if(giocatore >= 1)
            {
                giocatore--;
            }
        }
        private void exitLoginButton_Click(object sender, EventArgs e)
        {
            Schermata_Iniziale f1 = new Schermata_Iniziale();
            f1.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!pWOS)
            {
                accountChecker();
            }
            else if(pWOS && giocatore == 0)
            {
                giocatore++;
                Giocatore1 = usernameTextBox.Text;
                usernameTextBox.Clear();
                player1.Visible = false; player2.Visible = true;               
            }
            else if(pWOS && giocatore == 1)
            {
                Giocatore2 = usernameTextBox.Text;
                prePartita();
            }
        }

        private void yesStartMatch_Click(object sender, EventArgs e)
        {
            //comincia la partita
            Gameplay f3 = new Gameplay();
            f3.Show();
            this.Close();
        }

        private void noStartMatch_Click(object sender, EventArgs e)
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
            bool correctPlayerName = false, correctPlayerPassword = false;
            string nomePlayerGiausato = "";
            alertLoginAccount.ForeColor = Color.Red;
            controlloGiocatore(ref correctPlayerName, ref correctPlayerPassword, ref nomePlayerGiausato);
            if (playeresistente == true)
            {
                if (usernameTextBox.Text == "")
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Inserire una nome utente valido";
                }
                else if (passwordTextBox.Text == "")
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Inserire delle credenziali valide";
                }
                else if (correctPlayerName == true && correctPlayerPassword == false)
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Password Errata";
                    passwordTextBox.Clear();
                }
                else if (nomePlayerGiausato == usernameTextBox.Text)
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.Text = "Sei già entrato con questo utente";
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                }
                else if (correctPlayerName == true && correctPlayerPassword == true)
                {
                    alertLoginAccount.Visible = true;
                    alertLoginAccount.ForeColor = Color.Lime;
                    alertLoginAccount.Text = "Utente trovato";
                    if (giocatore == 0)
                    {
                        nomePlayerGiausato = usernameTextBox.Text;
                        usernameTextBox.Clear(); passwordTextBox.Clear();
                        player1.Visible = false; player2.Visible = true;                       
                        giocatore++;
                    }
                    else if (giocatore == 1)//nel caso tutti e due i giocatori sono pronti
                    {
                    }
                }
                else
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
            var giocatoriPresenti = File.ReadLines(playerStatsFile);
            for (int i = 0; i < giocatoriPresenti.ToArray().Length; i++)
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
            if (correctPlayerName == true && playeresistente == false)
            {
                alertLoginAccount.Visible = true;
                alertLoginAccount.ForeColor = Color.Red;
                alertLoginAccount.Text = "Utente già esistente";
                usernameTextBox.Clear(); passwordTextBox.Clear();               
            }
            else if (usernameTextBox.Text == "" && playeresistente == false)
            {
                alertLoginAccount.Visible = true;
                alertLoginAccount.Text = "Inserire una nome utente valido";
            }
            else if (passwordTextBox.Text == "" && playeresistente == false)
            {
                alertLoginAccount.Visible = true;
                alertLoginAccount.Text = "Inserire delle credenziali valide";
            }
            else if (playeresistente == false)
            {
                string[] giocatoriFile = new string[giocatoriPresenti.ToArray().Length + 1];
                Array.Copy(giocatoriPresenti.ToArray(), giocatoriFile, giocatoriPresenti.ToArray().Length);
                giocatoriFile[giocatoriFile.Length - 1] = $"{usernameTextBox.Text},{passwordTextBox.Text}";
                File.WriteAllLines(playerStatsFile, giocatoriFile);
                alertLoginAccount.Visible = true;
                alertLoginAccount.ForeColor = Color.Green;
                alertLoginAccount.Text = "Nuovo utente registrato";
                usernameTextBox.Clear(); passwordTextBox.Clear();               
                if (giocatore == 0)
                {
                    nomePlayerGiausato = usernameTextBox.Text;
                    usernameTextBox.Clear(); passwordTextBox.Clear();                   
                    player1.Visible = false; player2.Visible = true;                   
                    giocatore++;
                }
                else if (giocatore == 1)//nel caso tutti e due i giocatori sono pronti
                {
                }
            }
        }

        public void prePartita()
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
