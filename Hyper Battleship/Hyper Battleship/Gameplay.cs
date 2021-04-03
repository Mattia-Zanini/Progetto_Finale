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
            //Gioco();
        }

        #region Griglie Di Gioco
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
        #endregion


        public static int scoreGiocatore1 = 0, scoreGiocatore2 = 0;
        int sottomarini, cacciatorpedinieri, naviDassalto;
        bool finePartita = false, disposizioneNaviPossibile = true;
        bool portaereiPosizionata, corazzataPosizionata, sottomarinoPosizionato1, sottomarinoPosizionato2, cacciatorpedinierePosizionato1, cacciatorpedinierePosizionato2, naveDassaltoPosizionata1, naveDassaltoPosizionata2, naveDassaltoPosizionata3;
        bool confirmButtonePressed = false, exitOperation = false;

        private void confermaButton_Click(object sender, EventArgs e)
        {
            confirmButtonePressed = true;
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            exitOperation = true;
        }


        #region Disposizione Navi
        string nave = "";
        bool moveUp, moveDown, moveLeft, moveRight, rotateLeft, rotateRight;
        bool portaereiImaggineGirata, corazzataImaggineGirata, sottomarinoImmagineGirata1, sottomarinoImmagineGirata2, cacciatorpediniereImmagineGirata1, cacciatorpediniereImmagineGirata2, naveDassaltoImmagineGirata1, naveDassaltoImmagineGirata2, naveDassaltoImmagineGirata3;
        private void moveShipEvent(object sender, EventArgs e)
        {
            switch (nave)
            {
                case "portaerei":
                    if (moveUp && portaereiGriglia10x10.Top > 40 && !confirmButtonePressed)
                    {
                        portaereiGriglia10x10.Top -= 63;
                    }
                    if (moveDown && portaereiGriglia10x10.Top < 607 && !confirmButtonePressed)
                    {
                        if (!portaereiImaggineGirata)
                        {
                            portaereiGriglia10x10.Top += 63;
                        }
                        else if (portaereiImaggineGirata && portaereiGriglia10x10.Top < 293)
                        {
                            portaereiGriglia10x10.Top += 63;
                        }
                    }
                    if (moveRight && portaereiGriglia10x10.Right < 675 && !confirmButtonePressed)
                    {
                        portaereiGriglia10x10.Left += 63;
                    }
                    if (moveLeft && portaereiGriglia10x10.Left > 45 && !confirmButtonePressed)
                    {
                        portaereiGriglia10x10.Left -= 63;
                    }
                    if (rotateLeft && !confirmButtonePressed)
                    {
                        if (!portaereiImaggineGirata)
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
                    if (rotateRight && !confirmButtonePressed)
                    {
                        if (portaereiImaggineGirata)
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
                    if (confirmButtonePressed)
                    {
                        portaereiPosizionata = true;
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonePressed = false;
                    }
                    if (exitOperation)
                    {
                        portaereiGriglia10x10.Visible = false;
                        quantitàPortaerei.Text = "1";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        exitOperation = false;
                    }
                    break;
                case "corazzata":
                    if (moveUp && corazzataGriglia10x10.Top > 40 && !confirmButtonePressed)
                    {
                        corazzataGriglia10x10.Top -= 63;
                    }
                    if (moveDown && corazzataGriglia10x10.Top < 607 && !confirmButtonePressed)
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
                    if (moveRight && corazzataGriglia10x10.Right < 675 && !confirmButtonePressed)
                    {
                        corazzataGriglia10x10.Left += 63;
                    }
                    if (moveLeft && corazzataGriglia10x10.Left > 45 && !confirmButtonePressed)
                    {
                        corazzataGriglia10x10.Left -= 63;
                    }
                    if (rotateLeft && !confirmButtonePressed)
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
                    if (rotateRight && !confirmButtonePressed)
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
                    if (confirmButtonePressed)
                    {
                        corazzataPosizionata = true;
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonePressed = false;
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
                            if (moveUp && sottomarino1Griglia10x10.Top > 40 && !confirmButtonePressed)
                            {
                                sottomarino1Griglia10x10.Top -= 63;
                            }
                            if (moveDown && sottomarino1Griglia10x10.Top < 607 && !confirmButtonePressed)
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
                            if (moveRight && sottomarino1Griglia10x10.Right < 675 && !confirmButtonePressed)
                            {
                                sottomarino1Griglia10x10.Left += 63;
                            }
                            if (moveLeft && sottomarino1Griglia10x10.Left > 45 && !confirmButtonePressed)
                            {
                                sottomarino1Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonePressed)
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
                            if (rotateRight && !confirmButtonePressed)
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
                            if (moveUp && sottomarino2Griglia10x10.Top > 40 && !confirmButtonePressed)
                            {
                                sottomarino2Griglia10x10.Top -= 63;
                            }
                            if (moveDown && sottomarino2Griglia10x10.Top < 607 && !confirmButtonePressed)
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
                            if (moveRight && sottomarino2Griglia10x10.Right < 675 && !confirmButtonePressed)
                            {
                                sottomarino2Griglia10x10.Left += 63;
                            }
                            if (moveLeft && sottomarino2Griglia10x10.Left > 45 && !confirmButtonePressed)
                            {
                                sottomarino2Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonePressed)
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
                            if (rotateRight && !confirmButtonePressed)
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
                    if (confirmButtonePressed)
                    {
                        if (sottomarini == 1)
                        {
                            sottomarinoPosizionato1 = true;
                        }
                        else if (sottomarini == 0)
                        {
                            sottomarinoPosizionato2 = true;
                        }
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonePressed = false;
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
                            if (moveUp && cacciatorpediniere1Griglia10x10.Top > 40 && !confirmButtonePressed)
                            {
                                cacciatorpediniere1Griglia10x10.Top -= 63;
                            }
                            if (moveDown && cacciatorpediniere1Griglia10x10.Top < 607 && !confirmButtonePressed)
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
                            if (moveRight && cacciatorpediniere1Griglia10x10.Right < 675 && !confirmButtonePressed)
                            {
                                cacciatorpediniere1Griglia10x10.Left += 63;
                            }
                            if (moveLeft && cacciatorpediniere1Griglia10x10.Left > 45 && !confirmButtonePressed)
                            {
                                cacciatorpediniere1Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonePressed)
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
                            if (rotateRight && !confirmButtonePressed)
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
                            if (moveUp && cacciatorpediniere2Griglia10x10.Top > 40 && !confirmButtonePressed)
                            {
                                cacciatorpediniere2Griglia10x10.Top -= 63;
                            }
                            if (moveDown && cacciatorpediniere2Griglia10x10.Top < 607 && !confirmButtonePressed)
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
                            if (moveRight && cacciatorpediniere2Griglia10x10.Right < 675 && !confirmButtonePressed)
                            {
                                cacciatorpediniere2Griglia10x10.Left += 63;
                            }
                            if (moveLeft && cacciatorpediniere2Griglia10x10.Left > 45 && !confirmButtonePressed)
                            {
                                cacciatorpediniere2Griglia10x10.Left -= 63;
                            }
                            if (rotateLeft && !confirmButtonePressed)
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
                            if (rotateRight && !confirmButtonePressed)
                            {
                                if (cacciatorpediniereImmagineGirata2)
                                {
                                    cacciatorpediniere2Griglia10x10.Width = 126; cacciatorpediniere2Griglia10x10.Height = 63;
                                    cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10;
                                    cacciatorpediniereImmagineGirata2 = false;
                                    if (sottomarino2Griglia10x10.Location.X > 549)
                                    {
                                        cacciatorpediniere2Griglia10x10.Location = new Point(549, cacciatorpediniere2Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;

                    }
                    if (confirmButtonePressed)
                    {
                        if(cacciatorpedinieri == 1)
                        {
                            cacciatorpedinierePosizionato1 = true;
                        }
                        else if(cacciatorpedinieri == 0)
                        {
                            cacciatorpedinierePosizionato2 = true;
                        }
                        nave = "";
                        annullaButton.Visible = false;
                        disposizioneNaviPossibile = true;
                        confirmButtonePressed = false;
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
        private void portaereiPictureBox10x10_Click(object sender, EventArgs e)
        {
            if (disposizioneNaviPossibile)
            {
                nave = "portaerei";
                quantitàPortaerei.Text = "0";
                disposizioneNaviPossibile = false;
                annullaButton.Visible = true;
                portaereiGriglia10x10.Location = new Point(297 - 63*2, 292);
                portaereiGriglia10x10.Visible = true;
            }
        }

        private void corazzataPcitureBox10x10_Click(object sender, EventArgs e)
        {
            if (disposizioneNaviPossibile)
            {
                nave = "corazzata";
                quantitàCorazzata.Text = "0";
                disposizioneNaviPossibile = false;
                annullaButton.Visible = true;
                corazzataGriglia10x10.Location = new Point(297 - 63, 292);
                corazzataGriglia10x10.Visible = true;
            }
        }

        private void sottomarinoPictureBox10x10_Click(object sender, EventArgs e)
        {
            if (disposizioneNaviPossibile)
            {
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
                else if(sottomarini == 0)
                {
                    sottomarino2Griglia10x10.Location = new Point(297 - 63, 292);
                    sottomarino2Griglia10x10.Visible = true;
                }
            }
        }

        private void cacciatorpedinierePictureBox10x10_Click(object sender, EventArgs e)
        {
            if (disposizioneNaviPossibile)
            {
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

        #endregion

        public void Gioco()
        {
            int turno = 0;
            Schermata_Iniziale f1 = new Schermata_Iniziale();
            byte quantitàRadar = 1, quantitàDoppioAssalto;//booster partita
            if (f1.modalitàAssign() == false)//controllo se l'utente/utenti ha/hanno scelto una partita normale o veloce
            {
                quantitàDoppioAssalto = 1;//veloce
            }
            else
            {
                quantitàDoppioAssalto = 2;//normale
            }

            do
            {
                turno++;
                if(turno > 100)
                {
                    break;
                }

            } while (finePartita == false);
        }
    }
}
