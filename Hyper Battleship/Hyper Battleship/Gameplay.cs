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
    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
        }
        private void Gameplay_FormClosed(object sender, FormClosedEventArgs e)//per chiudere il form
        {
            Application.Exit();
        }

        //Griglia 10 x 10 caselle. partita normale
        public static string[] StrutturaGriglia10 = new string[]  {"acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no" };
        //Griglia 6 x 6 caselle, partita veloce
        public static string[] StrutturaGriglia6 = new string[]   {"acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no" };

        #region Variabili Per il Fuzionamento dell Programma + Tasto "Conferma", "Annulla" e "Passa Turno"
        public static int scoreGiocatore1 = 0, scoreGiocatore2 = 0;
        int turni = 1;
        int naviPosizionate = 0;
        int sottomarini, cacciatorpedinieri, naviDassalto;
        bool finePartita = false, disposizioneNaviPossibile = true;
        bool portaereiPosizionata, corazzataPosizionata, sottomarinoPosizionato1, sottomarinoPosizionato2, cacciatorpedinierePosizionato1, cacciatorpedinierePosizionato2, naveDassaltoPosizionata1, naveDassaltoPosizionata2, naveDassaltoPosizionata3;
        bool confirmButtonPressed = false, exitOperation = false;
        private void confermaButton_Click(object sender, EventArgs e)
        {
            confirmButtonPressed = true;
            //quando sono state posizionate tutte le navi
            if(portaereiPosizionata && corazzataPosizionata && sottomarinoPosizionato1 && sottomarinoPosizionato2 && cacciatorpedinierePosizionato1 && cacciatorpedinierePosizionato2 && naveDassaltoPosizionata1 && naveDassaltoPosizionata2 && naveDassaltoPosizionata3)
            {
                passaTurnoButton.Visible = true;
                MessageBox.Show("Hai dispiegato in campo tutte le navi\nClicca il pulsante 'Passa il turno'");
                confermaButton.Visible = false;
                naviPosizionate = 0;
            }
            else if(naviPosizionate < 8)
            {
                confermaButton.Visible = false;
            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            exitOperation = true;
            confermaButton.Visible = false;
        }

        bool attacco1 = false;
        private void passaTurnoButton_Click(object sender, EventArgs e) //passa il turno, quindi riporta tutte le variabili al loro stato originale, per permettere al secondo giocatore di posizionare le sue navi
                                                                        //e di registrarle nella griglia
        {
            nave = "";
            portaereiGriglia10x10.Visible = false; portaereiImaggineGirata = false; quantitàPortaerei.Text = "1"; portaereiPosizionata = false;
            corazzataGriglia10x10.Visible = false; corazzataImaggineGirata = false; quantitàCorazzata.Text = "1"; corazzataPosizionata = false;
            sottomarino1Griglia10x10.Visible = false; sottomarino2Griglia10x10.Visible = false; sottomarinoImmagineGirata1 = false; sottomarinoImmagineGirata2 = false; quantitàSottomarini.Text = "2"; sottomarini = 2; sottomarinoPosizionato1 = false; sottomarinoPosizionato2 = false;
            cacciatorpediniere1Griglia10x10.Visible = false; cacciatorpediniere2Griglia10x10.Visible = false; cacciatorpediniereImmagineGirata1 = false; cacciatorpediniereImmagineGirata2 = false; quantitàCacciatorpediniere.Text = "2"; cacciatorpedinieri = 2; cacciatorpedinierePosizionato1 = false; cacciatorpedinierePosizionato2 = false;
            naveDassalto1Griglia10x10.Visible = false; naveDassalto2Griglia10x10.Visible = false; naveDassalto3Griglia10x10.Visible = false;  quantitàNaveDassalto.Text = "3"; naviDassalto = 3; naveDassaltoPosizionata1 = false; naveDassaltoPosizionata2 = false; naveDassaltoPosizionata3 = false;
            player1PictureBox.Visible = false; player2PictureBox.Visible = true; confirmButtonPressed = false;
            passaTurnoButton.Visible = false;
            if (!player2PictureBox.Visible)//nel caso entrambi i giocatori sono sicuri della loro decisione sull'allocare le navi nelle rispettive posizioni, comincia il gioco
            {
                movimentoDisposizioneNavi.Enabled = false;
                turnoLabel.Visible = true; contatoreTurni.Visible = true; contatoreTurni.Text = turni.ToString();
                quantitàPortaerei.Visible = false; quantitàCorazzata.Visible = false; quantitàSottomarini.Visible = false;
                quantitàCacciatorpediniere.Visible = false; quantitàNaveDassalto.Visible = false;
                portaereiPictureBox10x10.Visible = false; corazzataPcitureBox10x10.Visible = false; sottomarinoPictureBox10x10.Visible = false;
                cacciatorpedinierePictureBox10x10.Visible = false; naveDassaltoPictureBox10x10.Visible = false;
                passaTurnoButton.Location = new Point(1008, passaTurnoButton.Location.Y);
                this.Width = 1200;
                player1PictureBox.Visible = true; player2PictureBox.Visible = false;
                selezioneAttacco1.Location = new Point(297, 292); selezioneAttacco1.Visible = true;

            }
        }
        #endregion

        #region Disposizione Navi
        string nave = "";
        bool moveUp, moveDown, moveLeft, moveRight, rotateLeft, rotateRight;
        bool portaereiImaggineGirata, corazzataImaggineGirata, sottomarinoImmagineGirata1, sottomarinoImmagineGirata2, cacciatorpediniereImmagineGirata1, cacciatorpediniereImmagineGirata2;
        private void moveShipEvent(object sender, EventArgs e)//funzione ciclica che permettte di controllare i tasti che l'utente preme per spostare le navi che hanno selezionato
        {                                                    //in ogni "case" che sposta le navi con i rispettivi nomi identificativi, vengono effettuati anche dei controlli per evitare di posizionare
                                                             //una nave al di fuori della griglia, medesiam situazione anche per ruotarle
            switch (nave)
            {
                case "portaerei":
                    if (moveUp && portaereiGriglia10x10.Top > 40 && !confirmButtonPressed)//alto
                    {
                        portaereiGriglia10x10.Top -= 63;
                    }
                    if (moveDown && portaereiGriglia10x10.Top < 607 && !confirmButtonPressed)//basso
                    {
                        if (!portaereiImaggineGirata)
                        {
                            portaereiGriglia10x10.Top += 63;
                        }
                        else if (portaereiImaggineGirata && portaereiGriglia10x10.Top < 293)//basso, quando è girata
                        {
                            portaereiGriglia10x10.Top += 63;
                        }
                    }
                    if (moveRight && portaereiGriglia10x10.Right < 675 && !confirmButtonPressed)//destra
                    {
                        portaereiGriglia10x10.Left += 63;
                    }
                    if (moveLeft && portaereiGriglia10x10.Left > 45 && !confirmButtonPressed)//sinistra
                    {
                        portaereiGriglia10x10.Left -= 63;
                    }
                    if (rotateLeft && !confirmButtonPressed)//ruotare a sinistra -->  -90°
                    {
                        if (!portaereiImaggineGirata)//solo quando è orrizontale viene girata l'immagine
                        {
                            portaereiGriglia10x10.Width = 63; portaereiGriglia10x10.Height = 315;
                            portaereiGriglia10x10.Image = Properties.Resources.portaerei_Griglia10x10Verticale;
                            portaereiImaggineGirata = true;
                            if (portaereiGriglia10x10.Location.Y > 355)
                            {
                                portaereiGriglia10x10.Location = new Point(portaereiGriglia10x10.Location.X, 355);
                            }
                        }
                    }
                    if (rotateRight && !confirmButtonPressed)//ruotare a destra -->  +90°
                    {
                        if (portaereiImaggineGirata)//solo quando è verticale
                        {
                            portaereiGriglia10x10.Width = 315; portaereiGriglia10x10.Height = 63;
                            portaereiGriglia10x10.Image = Properties.Resources.portaerei_Griglia10x10;
                            portaereiImaggineGirata = false;
                            if (portaereiGriglia10x10.Location.X > 360)
                            {
                                portaereiGriglia10x10.Location = new Point(360, portaereiGriglia10x10.Location.Y);
                            }
                        }
                    }
                    if (confirmButtonPressed)//quando viene cliccato il pulsante "Conferma"
                    {
                        assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(portaereiGriglia10x10.Location.Y, portaereiGriglia10x10.Location.X);//assegna alla nave delle coordinate
                        posizioneNaveNellArray(5);//viene scritto in un array, dove la nave si trova
                        nave = "";//reinizializza la variabile
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonPressed = false;
                        naviPosizionate++;
                    }
                    if (exitOperation)//per annullare la posiziona attuale della nave
                    {
                        portaereiGriglia10x10.Visible = false;
                        quantitàPortaerei.Text = "1";//ovviamente ne riaumenta la quantità di navi di quel tipo, disponibile
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        exitOperation = false;
                    }
                    break;

//STESSA MEDESIMA COSA AVVIENE ANCHE PER LE ALTRE NAVI, CON CONTROLLI LEGGERMENTE DIVERSI SOLO PER LA FUNZIONE "posizioneNellArray"

                case "corazzata":
                    if (moveUp && corazzataGriglia10x10.Top > 40 && !confirmButtonPressed)
                    {
                        corazzataGriglia10x10.Top -= 63;
                    }
                    if (moveDown && corazzataGriglia10x10.Top < 607 && !confirmButtonPressed)
                    {
                        if (!corazzataImaggineGirata)
                        {
                            corazzataGriglia10x10.Top += 63;
                        }
                        else if (corazzataImaggineGirata && corazzataGriglia10x10.Top < 356)
                        {
                            corazzataGriglia10x10.Top += 63;
                        }
                    }
                    if (moveRight && corazzataGriglia10x10.Right < 675 && !confirmButtonPressed)
                    {
                        corazzataGriglia10x10.Left += 63;
                    }
                    if (moveLeft && corazzataGriglia10x10.Left > 45 && !confirmButtonPressed)
                    {
                        corazzataGriglia10x10.Left -= 63;
                    }
                    if (rotateLeft && !confirmButtonPressed)
                    {
                        if (!corazzataImaggineGirata)
                        {
                            corazzataGriglia10x10.Width = 63; corazzataGriglia10x10.Height = 252;
                            corazzataGriglia10x10.Image = Properties.Resources.corazzata_Griglia10x10Verticale;
                            corazzataImaggineGirata = true;
                            if (corazzataGriglia10x10.Location.Y > 418)
                            {
                                corazzataGriglia10x10.Location = new Point(corazzataGriglia10x10.Location.X, 418);
                            }
                        }
                    }
                    if (rotateRight && !confirmButtonPressed)
                    {
                        if (corazzataImaggineGirata)
                        {
                            corazzataGriglia10x10.Width = 252; corazzataGriglia10x10.Height = 63;
                            corazzataGriglia10x10.Image = Properties.Resources.corazzata_Griglia10x10;
                            corazzataImaggineGirata = false;
                            if (corazzataGriglia10x10.Location.X > 423)
                            {
                                corazzataGriglia10x10.Location = new Point(423, corazzataGriglia10x10.Location.Y);
                            }
                        }
                    }
                    if (confirmButtonPressed)
                    {
                        assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(corazzataGriglia10x10.Location.Y, corazzataGriglia10x10.Location.X);
                        posizioneNaveNellArray(4);
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonPressed = false;
                        naviPosizionate++;
                    }
                    if (exitOperation)
                    {
                        corazzataGriglia10x10.Visible = false;
                        quantitàCorazzata.Text = "1";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        exitOperation = false;
                    }
                    break;
                case "sottomarino":
                    switch (sottomarini)
                    {
                        case 1:
                            if (moveUp && sottomarino1Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                sottomarino1Griglia10x10.Top -= 63;
                            }
                            if (moveDown && sottomarino1Griglia10x10.Top < 607 && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata1)
                                {
                                    sottomarino1Griglia10x10.Top += 63;
                                }
                                else if (sottomarinoImmagineGirata1 && sottomarino1Griglia10x10.Top < 419)
                                {
                                    sottomarino1Griglia10x10.Top += 63;
                                }
                            }
                            if (moveRight && sottomarino1Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                sottomarino1Griglia10x10.Left += 63;
                            }
                            if (moveLeft && sottomarino1Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                sottomarino1Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata1)
                                {
                                    sottomarino1Griglia10x10.Width = 63; sottomarino1Griglia10x10.Height = 189;
                                    sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10Verticale;
                                    sottomarinoImmagineGirata1 = true;
                                    if (sottomarino1Griglia10x10.Location.Y > 481)
                                    {
                                        sottomarino1Griglia10x10.Location = new Point(sottomarino1Griglia10x10.Location.X, 481);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (sottomarinoImmagineGirata1)
                                {
                                    sottomarino1Griglia10x10.Width = 189; sottomarino1Griglia10x10.Height = 63;
                                    sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10;
                                    sottomarinoImmagineGirata1 = false;
                                    if (sottomarino1Griglia10x10.Location.X > 486)
                                    {
                                        sottomarino1Griglia10x10.Location = new Point(486, sottomarino1Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;
                        
                        case 0:
                            if (moveUp && sottomarino2Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                sottomarino2Griglia10x10.Top -= 63;
                            }
                            if (moveDown && sottomarino2Griglia10x10.Top < 607 && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata2)
                                {
                                    sottomarino2Griglia10x10.Top += 63;
                                }
                                else if (sottomarinoImmagineGirata2 && sottomarino2Griglia10x10.Top < 419)
                                {
                                    sottomarino2Griglia10x10.Top += 63;
                                }
                            }
                            if (moveRight && sottomarino2Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                sottomarino2Griglia10x10.Left += 63;
                            }
                            if (moveLeft && sottomarino2Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                sottomarino2Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata2)
                                {
                                    sottomarino2Griglia10x10.Width = 63; sottomarino2Griglia10x10.Height = 189;
                                    sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10Verticale;
                                    sottomarinoImmagineGirata2 = true;
                                    if (sottomarino2Griglia10x10.Location.Y > 481)
                                    {
                                        sottomarino2Griglia10x10.Location = new Point(sottomarino2Griglia10x10.Location.X, 481);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (sottomarinoImmagineGirata2)
                                {
                                    sottomarino2Griglia10x10.Width = 189; sottomarino2Griglia10x10.Height = 63;
                                    sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10;
                                    sottomarinoImmagineGirata2 = false;
                                    if (sottomarino2Griglia10x10.Location.X > 486)
                                    {
                                        sottomarino2Griglia10x10.Location = new Point(486, sottomarino2Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;

                    }
                    if (confirmButtonPressed)
                    {
                        if (sottomarini == 1)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(sottomarino1Griglia10x10.Location.Y, sottomarino1Griglia10x10.Location.X);
                            posizioneNaveNellArray(3);
                        }
                        else if (sottomarini == 0)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(sottomarino2Griglia10x10.Location.Y, sottomarino2Griglia10x10.Location.X);
                            posizioneNaveNellArray(3);
                        }
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonPressed = false;
                        naviPosizionate++;
                    }
                    if (exitOperation)
                    {
                        if (sottomarini == 1)
                        {
                            sottomarino1Griglia10x10.Visible = false;
                        }
                        else if (sottomarini == 0)
                        {
                            sottomarino2Griglia10x10.Visible = false;
                        }
                        sottomarini++;
                        quantitàSottomarini.Text = sottomarini.ToString();
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        exitOperation = false;
                    }
                    break;

                case "cacciatorpediniere":
                    switch (cacciatorpedinieri)
                    {
                        case 1:
                            if (moveUp && cacciatorpediniere1Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                cacciatorpediniere1Griglia10x10.Top -= 63;
                            }
                            if (moveDown && cacciatorpediniere1Griglia10x10.Top < 607 && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata1)
                                {
                                    cacciatorpediniere1Griglia10x10.Top += 63;
                                }
                                else if (cacciatorpediniereImmagineGirata1 && cacciatorpediniere1Griglia10x10.Top < 482)
                                {
                                    cacciatorpediniere1Griglia10x10.Top += 63;
                                }
                            }
                            if (moveRight && cacciatorpediniere1Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                cacciatorpediniere1Griglia10x10.Left += 63;
                            }
                            if (moveLeft && cacciatorpediniere1Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                cacciatorpediniere1Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata1)
                                {
                                    cacciatorpediniere1Griglia10x10.Width = 63; cacciatorpediniere1Griglia10x10.Height = 126;
                                    cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10Verticale;
                                    cacciatorpediniereImmagineGirata1 = true;
                                    if (cacciatorpediniere1Griglia10x10.Location.Y > 544)
                                    {
                                        cacciatorpediniere1Griglia10x10.Location = new Point(cacciatorpediniere1Griglia10x10.Location.X, 544);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (cacciatorpediniereImmagineGirata1)
                                {
                                    cacciatorpediniere1Griglia10x10.Width = 126; cacciatorpediniere1Griglia10x10.Height = 63;
                                    cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10;
                                    cacciatorpediniereImmagineGirata1 = false;
                                    if (cacciatorpediniere1Griglia10x10.Location.X > 549)
                                    {
                                        cacciatorpediniere1Griglia10x10.Location = new Point(549, cacciatorpediniere1Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;

                        case 0:
                            if (moveUp && cacciatorpediniere2Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                cacciatorpediniere2Griglia10x10.Top -= 63;
                            }
                            if (moveDown && cacciatorpediniere2Griglia10x10.Top < 607 && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata2)
                                {
                                    cacciatorpediniere2Griglia10x10.Top += 63;
                                }
                                else if (cacciatorpediniereImmagineGirata2 && cacciatorpediniere2Griglia10x10.Top < 482)
                                {
                                    cacciatorpediniere2Griglia10x10.Top += 63;
                                }
                            }
                            if (moveRight && cacciatorpediniere2Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                cacciatorpediniere2Griglia10x10.Left += 63;
                            }
                            if (moveLeft && cacciatorpediniere2Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                cacciatorpediniere2Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata2)
                                {
                                    cacciatorpediniere2Griglia10x10.Width = 63; cacciatorpediniere2Griglia10x10.Height = 126;
                                    cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10Verticale;
                                    cacciatorpediniereImmagineGirata2 = true;
                                    if (cacciatorpediniere2Griglia10x10.Location.Y > 544)
                                    {
                                        cacciatorpediniere2Griglia10x10.Location = new Point(cacciatorpediniere2Griglia10x10.Location.X, 544);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (cacciatorpediniereImmagineGirata2)
                                {
                                    cacciatorpediniere2Griglia10x10.Width = 126; cacciatorpediniere2Griglia10x10.Height = 63;
                                    cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10;
                                    cacciatorpediniereImmagineGirata2 = false;
                                    if (cacciatorpediniere2Griglia10x10.Location.X > 549)
                                    {
                                        cacciatorpediniere2Griglia10x10.Location = new Point(549, cacciatorpediniere2Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;

                    }
                    if (confirmButtonPressed)
                    {
                        if(cacciatorpedinieri == 1)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(cacciatorpediniere1Griglia10x10.Location.Y, cacciatorpediniere1Griglia10x10.Location.X);
                            posizioneNaveNellArray(2);
                        }
                        else if(cacciatorpedinieri == 0)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(cacciatorpediniere2Griglia10x10.Location.Y, cacciatorpediniere2Griglia10x10.Location.X);
                            posizioneNaveNellArray(2);
                        }
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonPressed = false;
                        naviPosizionate++;
                    }
                    if (exitOperation)
                    {
                        if (cacciatorpedinieri == 1)
                        {
                            cacciatorpediniere1Griglia10x10.Visible = false;
                        }
                        else if (cacciatorpedinieri == 0)
                        {
                            cacciatorpediniere2Griglia10x10.Visible = false;
                        }
                        cacciatorpedinieri++;
                        quantitàCacciatorpediniere.Text = cacciatorpedinieri.ToString();
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        exitOperation = false;
                    }
                    break;

                case "nave d'assalto":
                    switch (naviDassalto)
                    {
                        case 2:
                            if (moveUp && naveDassalto1Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                naveDassalto1Griglia10x10.Top -= 63;
                            }
                            if (moveDown && naveDassalto1Griglia10x10.Top < 607 && !confirmButtonPressed)
                            {
                                naveDassalto1Griglia10x10.Top += 63;
                            }
                            if (moveRight && naveDassalto1Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                naveDassalto1Griglia10x10.Left += 63;
                            }
                            if (moveLeft && naveDassalto1Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                naveDassalto1Griglia10x10.Left -= 63;
                            }
                            break;

                        case 1:
                            if (moveUp && naveDassalto2Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Top -= 63;
                            }
                            if (moveDown && naveDassalto2Griglia10x10.Top < 607 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Top += 63;
                            }
                            if (moveRight && naveDassalto2Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Left += 63;
                            }
                            if (moveLeft && naveDassalto2Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Left -= 63;
                            }
                            break;

                        case 0:
                            if (moveUp && naveDassalto3Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Top -= 63;
                            }
                            if (moveDown && naveDassalto3Griglia10x10.Top < 607 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Top += 63;
                            }
                            if (moveRight && naveDassalto3Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Left += 63;
                            }
                            if (moveLeft && naveDassalto3Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Left -= 63;
                            }
                            break;

                    }
                    if (confirmButtonPressed)
                    {
                        if (naviDassalto == 2)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(naveDassalto1Griglia10x10.Location.Y, naveDassalto1Griglia10x10.Location.X);
                            posizioneNaveNellArray(1);
                        }
                        else if (naviDassalto == 1)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(naveDassalto2Griglia10x10.Location.Y, naveDassalto2Griglia10x10.Location.X);
                            posizioneNaveNellArray(1);
                        }
                        else if (naviDassalto == 0)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(naveDassalto3Griglia10x10.Location.Y, naveDassalto3Griglia10x10.Location.X);
                            posizioneNaveNellArray(1);
                        }
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonPressed = false;
                        naviPosizionate++;
                    }
                    if (exitOperation)
                    {
                        if (naviDassalto == 2)
                        {
                            naveDassalto1Griglia10x10.Visible = false;
                        }
                        else if (naviDassalto == 1)
                        {
                            naveDassalto2Griglia10x10.Visible = false;
                        }
                        else if (naviDassalto == 0)
                        {
                            naveDassalto3Griglia10x10.Visible = false;
                        }
                        naviDassalto++;
                        quantitàNaveDassalto.Text = naviDassalto.ToString();
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        exitOperation = false;
                    }
                    break;
            }

            if (attacco1)
            {
                if (moveUp && selezioneAttacco1.Top > 40 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Top -= 63;
                }
                if (moveDown && selezioneAttacco1.Top < 607 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Top += 63;
                }
                if (moveRight && selezioneAttacco1.Right < 675 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Left += 63;
                }
                if (moveLeft && selezioneAttacco1.Left > 45 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Left -= 63;
                }
            }
        }

        private void Gameplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { moveUp = true; }
            if (e.KeyCode == Keys.S) { moveDown = true; }
            if (e.KeyCode == Keys.A) { moveLeft = true; }
            if (e.KeyCode == Keys.D) { moveRight = true; }
            if (e.KeyCode == Keys.E) { rotateRight = true; }
            if (e.KeyCode == Keys.Q) { rotateLeft = true; }
        }

        private void Gameplay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { moveUp = false; }
            if (e.KeyCode == Keys.S) { moveDown = false; }
            if (e.KeyCode == Keys.A) { moveLeft = false; }
            if (e.KeyCode == Keys.D) { moveRight = false; }
            if (e.KeyCode == Keys.E) { rotateRight = false; }
            if (e.KeyCode == Keys.Q) { rotateLeft = false; }
        }
        #endregion

        #region Tasti Delle Navi

        //quando l'utente clicca una picturebox, parte un controllo per vedere se non ci sono altre navi selezionate, poi assegna alla variabile "navi" il tipo di
        //vascello che è stata selezionata e con la funzione cliclica "moveShipEvent" la nave viene spostata nella direzione che l'utente vuole, con la riduzione nel numero di disponibilità di navi di quel tipo
        //inoltre la picturebox della nave selezionata viene spostata al centro della griglia
        private void portaereiPictureBox10x10_Click(object sender, EventArgs e)
        {
            if (!portaereiPosizionata)
            {
                if (disposizioneNaviPossibile)
                {
                    confirmButtonPressed = false; //per evitare errori nel posizionamento delle navi
                    confermaButton.Visible = true;
                    nave = "portaerei";
                    quantitàPortaerei.Text = "0";
                    disposizioneNaviPossibile = false;
                    annullaButton.Visible = true;
                    portaereiGriglia10x10.Location = new Point(297 - 63 * 2, 292);
                    portaereiGriglia10x10.Visible = true;
                }
            }
        }

        private void corazzataPcitureBox10x10_Click(object sender, EventArgs e)
        {
            if (!corazzataPosizionata)
            {
                if (disposizioneNaviPossibile)
                {
                    confirmButtonPressed = false;
                    confermaButton.Visible = true;
                    nave = "corazzata";
                    quantitàCorazzata.Text = "0";
                    disposizioneNaviPossibile = false;
                    annullaButton.Visible = true;
                    corazzataGriglia10x10.Location = new Point(297 - 63, 292);
                    corazzataGriglia10x10.Visible = true;
                }
            }
        }

        private void sottomarinoPictureBox10x10_Click(object sender, EventArgs e)
        {
            if(!sottomarinoPosizionato1 && !sottomarinoPosizionato2 || sottomarinoPosizionato1 && !sottomarinoPosizionato2)
            {
                if (disposizioneNaviPossibile)
                {
                    confirmButtonPressed = false;
                    confermaButton.Visible = true;
                    nave = "sottomarino";
                    sottomarini = Convert.ToInt32(quantitàSottomarini.Text);
                    sottomarini--;
                    quantitàSottomarini.Text = sottomarini.ToString();
                    disposizioneNaviPossibile = false;
                    annullaButton.Visible = true;
                    if (sottomarini == 1)
                    {
                        sottomarino1Griglia10x10.Location = new Point(297 - 63, 292);
                        sottomarino1Griglia10x10.Visible = true;
                    }
                    else if (sottomarini == 0)
                    {
                        sottomarino2Griglia10x10.Location = new Point(297 - 63, 292);
                        sottomarino2Griglia10x10.Visible = true;
                    }
                }
            }
        }

        private void cacciatorpedinierePictureBox10x10_Click(object sender, EventArgs e)
        {
            if (!cacciatorpedinierePosizionato1 && !cacciatorpedinierePosizionato2 || cacciatorpedinierePosizionato1 && !cacciatorpedinierePosizionato2)
            {
                if (disposizioneNaviPossibile)
                {
                    confirmButtonPressed = false;
                    confermaButton.Visible = true;
                    nave = "cacciatorpediniere";
                    cacciatorpedinieri = Convert.ToInt32(quantitàCacciatorpediniere.Text);
                    cacciatorpedinieri--;
                    quantitàCacciatorpediniere.Text = cacciatorpedinieri.ToString();
                    disposizioneNaviPossibile = false;
                    annullaButton.Visible = true;
                    if (cacciatorpedinieri == 1)
                    {
                        cacciatorpediniere1Griglia10x10.Location = new Point(297, 292);
                        cacciatorpediniere1Griglia10x10.Visible = true;
                    }
                    else if (cacciatorpedinieri == 0)
                    {
                        cacciatorpediniere2Griglia10x10.Location = new Point(297, 292);
                        cacciatorpediniere2Griglia10x10.Visible = true;
                    }
                }
            }
        }

        private void naveDassaltoPictureBox10x10_Click(object sender, EventArgs e)
        {
            if(!naveDassaltoPosizionata1 && !naveDassaltoPosizionata2 && !naveDassaltoPosizionata3 || naveDassaltoPosizionata1 && !naveDassaltoPosizionata2 && !naveDassaltoPosizionata3 || naveDassaltoPosizionata1 && naveDassaltoPosizionata2 && !naveDassaltoPosizionata3)
            {
                if (disposizioneNaviPossibile)
                {
                    confirmButtonPressed = false;
                    confermaButton.Visible = true;
                    nave = "nave d'assalto";
                    naviDassalto = Convert.ToInt32(quantitàNaveDassalto.Text);
                    naviDassalto--;
                    quantitàNaveDassalto.Text = naviDassalto.ToString();
                    disposizioneNaviPossibile = false;
                    annullaButton.Visible = true;
                    if (naviDassalto == 2)
                    {
                        naveDassalto1Griglia10x10.Location = new Point(297, 292);
                        naveDassalto1Griglia10x10.Visible = true;
                    }
                    else if (naviDassalto == 1)
                    {
                        naveDassalto2Griglia10x10.Location = new Point(297, 292);
                        naveDassalto2Griglia10x10.Visible = true;
                    }
                    else if (naviDassalto == 0)
                    {
                        naveDassalto3Griglia10x10.Location = new Point(297, 292);
                        naveDassalto3Griglia10x10.Visible = true;
                    }
                }
            }
        }

        #endregion

        #region Posizione X Y Delle Navi Sulla Griglia Di Gioco 10 x 10
        string coordinateNave = "";
        public void assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(int posY, int posX) //posizione del primo blocco della nave -->  primo blocco = poppa della nave
        {
            switch (posY) //es: casella A6 --> A = -1, 6 = 6 ---> A+6 = -1 + 6 = 5 (posizione nell'array)
                          //es: casella G3 --> G = 59, 3 = 3 ---> G+3 = 59 + 3 = 62 (posizione nell'array)
            {
                case 40:
                    coordinateNave = "-1,"; break; //casella A
                case 103:
                    coordinateNave = "9,"; break; //casella B
                case 166:
                    coordinateNave = "19,"; break; //casella C
                case 229:
                    coordinateNave = "29,"; break; //casella D
                case 292:
                    coordinateNave = "39,"; break; //casella E
                case 355:
                    coordinateNave = "49,"; break; //casella F
                case 418:
                    coordinateNave = "59,"; break; //casella G
                case 481:
                    coordinateNave = "69,"; break; //casella H
                case 544:
                    coordinateNave = "79,"; break; //casella I
                case 607:
                    coordinateNave = "89,"; break; //casella L
            }
            switch (posX)
            {
                case 45:
                    coordinateNave += "1"; break;
                case 108:
                    coordinateNave += "2"; break;
                case 171:
                    coordinateNave += "3"; break;
                case 234:
                    coordinateNave += "4"; break;
                case 297:
                    coordinateNave += "5"; break;
                case 360:
                    coordinateNave += "6"; break;
                case 423:
                    coordinateNave += "7"; break;
                case 486:
                    coordinateNave += "8"; break;
                case 549:
                    coordinateNave += "9"; break;
                case 612:
                    coordinateNave += "10"; break;
            }
        }

        private void posizioneNaveNellArray(int lunghezzaNave)
        {
            //viene localizzato in valore numerico la posizione della nave nella griglia, per poterla salvare nell'array
            string[] coordXY = coordinateNave.Split(',');
            int coordinateNaveSuGrigliaArray = Convert.ToInt32(coordXY[0]) + Convert.ToInt32(coordXY[1]);
            locazioneNaviSuGriglia(ref lunghezzaNave, ref coordinateNaveSuGrigliaArray);
        }

        private void locazioneNaviSuGriglia(ref int lunghezzaNave, ref int coordinateNaveSuGrigliaArray)
        {
            switch (lunghezzaNave)
            {
                case 5:
                    if (!portaereiImaggineGirata)
                    {
                        int[] posizioniDaControllare = new int[] { -10, -9, -8, -7, -6, -1, 0, 1, 2, 3, 4, 5, 10, 11, 12, 13, 14 };//posizioni dei blocchi, in valore numerico per l'array da
                                                                                                                                   //controllare quando la nave è in posizione orrizontale
                        controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, false);//funzione che permette di determinare se lave si trova ai lembi della griglia, evitando di controllare
                                                                                                                                                 //in posizioni che non conformerebbero alle regole del gioco
                        bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);//controlla se nelle vicinanze ci sono navi, utilizzando
                                                                                                                                                                          //l'array eventualemnte modificato dalla precedente funzione
                        if (!nessunaNaveNelleVicinanze)//nel caso non ci siano navi nei blocchi circostanti
                        {
                            for (int i = 0; i < 5; i++)//scrive nell'array la posizione della nave, in stringa
                            {
                                string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + i].Split(',');
                                if (player1PictureBox.Visible)
                                {
                                    grigliaArray[0] = "portaerei";
                                }
                                else
                                {
                                    grigliaArray[1] = "portaerei";
                                }
                                StrutturaGriglia10[coordinateNaveSuGrigliaArray + i] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                            }
                            portaereiPosizionata = true;//variabile che impedisce di ricollocare un altra nave dello stesso tipo, quando invece è già stata piazzata
                        }
                    }
                    else
                    {
                        //medesima cosa ma in verticale
                        int[] posizioniDaControllare = new int[] { -10, -1, 0, 1, 9, 10, 11, 19, 20, 21, 29, 30, 31, 39, 40, 41, 50 };//verticale
                        controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, true);
                        bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                        if (!nessunaNaveNelleVicinanze)
                        {
                            int x = 0;//per salvare la posizione in verticale
                            for (int i = 0; i < 5; i++)//a differenza del precedente viene usata una variabile che aumenta di 10 ad ogni ciclo per permettere di salvare la nave in modo corretto nell'array
                            {
                                string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + x].Split(',');
                                if (player1PictureBox.Visible)
                                {
                                    grigliaArray[0] = "portaerei";
                                }
                                else
                                {
                                    grigliaArray[1] = "portaerei";
                                }
                                StrutturaGriglia10[coordinateNaveSuGrigliaArray + x] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                x += 10;
                            }
                            portaereiPosizionata = true;
                        }
                    }
                    break;

//STESSA COSA PER TUTTI GLI ALTRI, MA NELLE NAVI D'ASSALTO NON VIENE EFFETTUATO IL CONTROLLO DELLA VERTICALITÀ DELLE NAVI

                case 4:
                    if (!corazzataImaggineGirata)
                    {
                        int[] posizioniDaControllare = new int[] { -10, -9, -8, -7, -1, 0, 1, 2, 3, 4, 10, 11, 12, 13 };//orrizontale
                        controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, false);
                        bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                        if (!nessunaNaveNelleVicinanze)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + i].Split(',');
                                if (player1PictureBox.Visible)
                                {
                                    grigliaArray[0] = "corazzata";
                                }
                                else
                                {
                                    grigliaArray[1] = "corazzata";
                                }
                                StrutturaGriglia10[coordinateNaveSuGrigliaArray + i] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                            }
                            corazzataPosizionata = true;
                        }
                    }
                    else
                    {
                        int[] posizioniDaControllare = new int[] { -10, -1, 0, 1, 9, 10, 11, 19, 20, 21, 29, 30, 31, 40 };//verticale
                        controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, true);
                        bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                        if (!nessunaNaveNelleVicinanze)
                        {
                            int x = 0;
                            for (int i = 0; i < 4; i++)
                            {
                                string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + x].Split(',');
                                if (player1PictureBox.Visible)
                                {
                                    grigliaArray[0] = "corazzata";
                                }
                                else
                                {
                                    grigliaArray[1] = "corazzata";
                                }
                                StrutturaGriglia10[coordinateNaveSuGrigliaArray + x] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                x += 10;
                            }
                            corazzataPosizionata = true;
                        }
                    }
                    break;
                case 3:
                    switch (sottomarini)
                    {
                        case 1:
                            if (!sottomarinoImmagineGirata1)
                            {
                                int[] posizioniDaControllare = new int[] { -10, -9, -8, -1, 0, 1, 2, 3, 10, 11, 12 };//orrizontale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, false);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    for (int i = 0; i < 3; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + i].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "sottomarino1";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "sottomarino1";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + i] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                    }
                                    sottomarinoPosizionato1 = true;
                                }
                            }
                            else
                            {
                                int[] posizioniDaControllare = new int[] { -10, -1, 0, 1, 9, 10, 11, 19, 20, 21, 30 };//verticale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, true);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    int x = 0;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + x].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "sottomarino1";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "sottomarino1";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + x] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                        x += 10;
                                    }
                                    sottomarinoPosizionato1 = true;
                                }
                            }
                            break;
                        case 0:
                            if (!sottomarinoImmagineGirata2)
                            {
                                int[] posizioniDaControllare = new int[] { -10, -9, -8, -1, 0, 1, 2, 3, 10, 11, 12 };//verticale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, false);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    for (int i = 0; i < 3; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + i].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "sottomarino2";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "sottomarino2";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + i] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                    }
                                    sottomarinoPosizionato2 = true;
                                }

                            }
                            else
                            {
                                int[] posizioniDaControllare = new int[] { -10, -1, 0, 1, 9, 10, 11, 19, 20, 21, 30 };//orrizontale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, true);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    int x = 0;
                                    for (int i = 0; i < 3; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + x].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "sottomarino2";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "sottomarino2";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + x] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                        x += 10;
                                    }
                                    sottomarinoPosizionato2 = true;
                                }

                            }
                            break;
                    }
                    break;

                case 2:
                    switch (cacciatorpedinieri)
                    {
                        case 1:
                            if (!cacciatorpediniereImmagineGirata1)
                            {
                                int[] posizioniDaControllare = new int[] { -10, -9, -1, 0, 1, 2, 10, 11 };//orrizontale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, false);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + i].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "cacciatorpediniere1";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "cacciatorpediniere1";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + i] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                    }
                                    cacciatorpedinierePosizionato1 = true;
                                }
                            }
                            else
                            {
                                int[] posizioniDaControllare = new int[] { -10, -1, 0, 1, 9, 10, 11, 20 };//verticale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, true);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    int x = 0;
                                    for (int i = 0; i < 2; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + x].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "cacciatorpediniere1";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "cacciatorpediniere1";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + x] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                        x += 10;
                                    }
                                    cacciatorpedinierePosizionato1 = true;
                                }
                            }
                            break;

                        case 0:
                            if (!cacciatorpediniereImmagineGirata2)
                            {
                                int[] posizioniDaControllare = new int[] { -10, -9, -1, 0, 1, 2, 10, 11 };//orrizontale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, false);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + i].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "cacciatorpediniere2";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "cacciatorpediniere2";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + i] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                    }
                                    cacciatorpedinierePosizionato2 = true;
                                }
                            }
                            else
                            {
                                int[] posizioniDaControllare = new int[] { -10, -1, 0, 1, 9, 10, 11, 20 };//verticale
                                controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare, lunghezzaNave, true);
                                bool nessunaNaveNelleVicinanze = controlloNaviNelleVicinanze(posizioniDaControllare, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                                if (!nessunaNaveNelleVicinanze)
                                {
                                    int x = 0;
                                    for (int i = 0; i < 2; i++)
                                    {
                                        string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + x].Split(',');
                                        if (player1PictureBox.Visible)
                                        {
                                            grigliaArray[0] = "cacciatorpediniere2";
                                        }
                                        else
                                        {
                                            grigliaArray[1] = "cacciatorpediniere2";
                                        }
                                        StrutturaGriglia10[coordinateNaveSuGrigliaArray + x] = $"{grigliaArray[0]},{grigliaArray[1]},{grigliaArray[2]},{grigliaArray[3]}";
                                        x += 10;
                                    }
                                    cacciatorpedinierePosizionato2 = true;
                                }
                            }
                            break;
                    }
                    break;

                case 1:
                    string[] grigliaArray2 = StrutturaGriglia10[coordinateNaveSuGrigliaArray].Split(',');//per non influenzare i controlli delle altre navi
                    //NA = nave d'assalto
                    int[] posizioniDaControllare_NA = new int[] { -10, -1, 0, 1, 10};
                    controlloLatiDellaNaveEstremiGriglia(ref coordinateNaveSuGrigliaArray, ref posizioniDaControllare_NA, lunghezzaNave, false);
                    bool nessunaNaveNelleVicinanze_NA = controlloNaviNelleVicinanze(posizioniDaControllare_NA, player1PictureBox.Visible, ref coordinateNaveSuGrigliaArray);
                    if (!nessunaNaveNelleVicinanze_NA)
                    {
                        switch (naviDassalto)
                        {
                            case 2:
                                if (player1PictureBox.Visible)
                                {
                                    grigliaArray2[0] = "nave d'assalto1";
                                }
                                else
                                {
                                    grigliaArray2[1] = "nave d'assalto1";
                                }
                                StrutturaGriglia10[coordinateNaveSuGrigliaArray] = $"{grigliaArray2[0]},{grigliaArray2[1]},{grigliaArray2[2]},{grigliaArray2[3]}";
                                naveDassaltoPosizionata1 = true;
                                break;

                            case 1:
                                if (player1PictureBox.Visible)
                                {
                                    grigliaArray2[0] = "nave d'assalto2";
                                }
                                else
                                {
                                    grigliaArray2[1] = "nave d'assalto2";
                                }
                                StrutturaGriglia10[coordinateNaveSuGrigliaArray] = $"{grigliaArray2[0]},{grigliaArray2[1]},{grigliaArray2[2]},{grigliaArray2[3]}";
                                naveDassaltoPosizionata2 = true;
                                break;

                            case 0:
                                if (player1PictureBox.Visible)
                                {
                                    grigliaArray2[0] = "nave d'assalto3";
                                }
                                else
                                {
                                    grigliaArray2[1] = "nave d'assalto3";
                                }
                                StrutturaGriglia10[coordinateNaveSuGrigliaArray] = $"{grigliaArray2[0]},{grigliaArray2[1]},{grigliaArray2[2]},{grigliaArray2[3]}";
                                naveDassaltoPosizionata3 = true;
                                break;
                        }
                    }
                    break;
            }
        }

        private bool controlloNaviNelleVicinanze(int[] posizioniDaControllare, bool player, ref int coordinateNaveSuGrigliaArray)
        {
            bool naveNelleVicinanze = false;
            switch (player)
            {
                case true: //player 1
                    for (int i = 0; i < posizioniDaControllare.Length; i++)
                    {
                        //filtro che verifica se il blocco da controllare appartiene alla griglia --->   (0 <= valore valido <= 99)
                        if(coordinateNaveSuGrigliaArray + posizioniDaControllare[i] >= 0 && coordinateNaveSuGrigliaArray + posizioniDaControllare[i] < 100)
                        {
                            string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + posizioniDaControllare[i]].Split(',');
                            if (grigliaArray[0] != "acqua1")
                            {
                                confirmButtonPressed = false;
                                annullaButton.Visible = false;
                                disposizioneNaviPossibile = true;
                                exitOperation = true;
                                naveNelleVicinanze = true;
                                MessageBox.Show("Non puoi posizionare qui la nave");
                                break;
                            }
                        }
                    }
                    break;

                case false: //player 2
                    for (int i = 0; i < posizioniDaControllare.Length; i++)
                    {
                        if (coordinateNaveSuGrigliaArray + posizioniDaControllare[i] >= 0 && coordinateNaveSuGrigliaArray + posizioniDaControllare[i] < 100)
                        {
                            string[] grigliaArray = StrutturaGriglia10[coordinateNaveSuGrigliaArray + posizioniDaControllare[i]].Split(',');
                            if (grigliaArray[1] != "acqua2")
                            {
                                confirmButtonPressed = false;
                                nave = "";
                                annullaButton.Visible = false;
                                disposizioneNaviPossibile = true;
                                exitOperation = true;
                                naveNelleVicinanze = true;
                                MessageBox.Show("Non puoi posizionare qui la nave");
                                break;
                            }
                        }
                    }
                    break;
            }
            return naveNelleVicinanze; //nel caso ci siano anche solo un blocco di una nave vicino, il programma avvertirà l'utente che non si può posizionare la nave in quella parte di griglia
        }

        private void controlloLatiDellaNaveEstremiGriglia(ref int coordinateNaveSuGrigliaArray, ref int[] posizioniDaControllare,int indexToRemove, bool immagineGirata)//controlla che la nave non sia posizionte al limite a destra della griglia per evitare dei falsi check di navi vicine
        {
            int[] latoDestroGrigliaVerticale = new int[] { 1, 11, 21, 31, 41 };
            int[] latoSinistroGrigliaVerticale = new int[] { -1, 9, 19, 29, 39 };
            int[] latoSinistroGrigliaOrrizontale = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90};
            int[] latoDestroGrigliaOrrizontale = new int[] { 9, 19, 29, 39, 49, 59, 69, 79, 89 };
            for (int i = 0; i < 9; i++)//per rimuovere il controllo in eccesso, in quanto si trova agli estremi della griglia
            {
                if (coordinateNaveSuGrigliaArray == latoSinistroGrigliaOrrizontale[i])
                {
                    if (!immagineGirata)
                    {
                        posizioniDaControllare = posizioniDaControllare.RemoveFromArray(-1);
                    }
                    else
                    {
                        for(int j = 0; j < latoSinistroGrigliaVerticale.Length; j++)//quando l'immagine è verticale, verranno eliminati i blocchi da controllare prestabili (universali per tutte le navi)
                        {
                            posizioniDaControllare = posizioniDaControllare.RemoveFromArray(latoSinistroGrigliaVerticale[j]);
                        }
                    }

                    break;
                }
                if(coordinateNaveSuGrigliaArray + indexToRemove - 1 == latoDestroGrigliaOrrizontale[i] || coordinateNaveSuGrigliaArray == latoDestroGrigliaOrrizontale[i])
                {
                    if (!immagineGirata)
                    {
                        posizioniDaControllare = posizioniDaControllare.RemoveFromArray(indexToRemove);
                    }
                    else
                    {
                        for (int j = 0; j < latoDestroGrigliaVerticale.Length; j++)
                        {
                            posizioniDaControllare = posizioniDaControllare.RemoveFromArray(latoDestroGrigliaVerticale[j]);
                        }
                    }
                    break;
                }
            }
        }
        #endregion

    }
}
