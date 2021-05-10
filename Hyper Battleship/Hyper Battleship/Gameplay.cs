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
            if (Program.modalità == false)//nel caso la partita sia sulla modalità "Partita Veloce" il layout della schermata cambia
            {
                grigliaDiGiocoGrande.Image = Properties.Resources.Griglia6x6;
                grigliaDiGiocoPiccola.Image = Properties.Resources.griglia_Piccola_6x6;
                g_GrigliaGrande10.Visible = false; g_GrigliaPiccola10.Visible = false;
                h_GrigliaGrande10.Visible = false; h_GrigliaPiccola10.Visible = false;
                i_GrigliaGrande10.Visible = false; i_GrigliaPiccola10.Visible = false;
                l_GrigliaGrande10.Visible = false; l_GrigliaPiccola10.Visible = false;
                GrigliaGrade10_7.Visible = false; GrigliaPiccola10_7.Visible = false;
                GrigliaGrade10_8.Visible = false; GrigliaPiccola10_8.Visible = false;
                GrigliaGrade10_9.Visible = false; GrigliaPiccola10_9.Visible = false;
                GrigliaGrade10_10.Visible = false; GrigliaPiccola10_10.Visible = false;
                GrigliaGrade10_1.Location = new Point(81, GrigliaGrade10_1.Location.Y);
                GrigliaGrade10_2.Location = new Point(189, GrigliaGrade10_1.Location.Y);
                GrigliaGrade10_3.Location = new Point(293, GrigliaGrade10_1.Location.Y);
                GrigliaGrade10_4.Location = new Point(400, GrigliaGrade10_1.Location.Y);
                GrigliaGrade10_5.Location = new Point(503, GrigliaGrade10_1.Location.Y);
                GrigliaGrade10_6.Location = new Point(607, GrigliaGrade10_1.Location.Y);
                a_GrigliaGrande10.Location = new Point(a_GrigliaGrande10.Location.X, 74);
                b_GrigliaGrande10.Location = new Point(a_GrigliaGrande10.Location.X, 179);
                c_GrigliaGrande10.Location = new Point(a_GrigliaGrande10.Location.X, 284);
                d_GrigliaGrande10.Location = new Point(a_GrigliaGrande10.Location.X, 397);
                e_GrigliaGrande10.Location = new Point(a_GrigliaGrande10.Location.X, 498);
                f_GrigliaGrande10.Location = new Point(a_GrigliaGrande10.Location.X, 604);
                sottomarinoPictureBox10x10.Image = Properties.Resources.sottomarino_Box6x6; sottomarinoPictureBox10x10.Location = new Point(sottomarinoPictureBox10x10.Location.X, 40);
                cacciatorpedinierePictureBox10x10.Image = Properties.Resources.cacciatorpediniere_Box6x6; cacciatorpedinierePictureBox10x10.Location = new Point(sottomarinoPictureBox10x10.Location.X, 116);
                naveDassaltoPictureBox10x10.Image = Properties.Resources.Nave_D_Assalto_Box6x6; naveDassaltoPictureBox10x10.Location = new Point(sottomarinoPictureBox10x10.Location.X, 216);
                portaereiPictureBox10x10.Visible = false; quantitàPortaerei.Visible = false;
                corazzataPcitureBox10x10.Visible = false; quantitàCorazzata.Visible = false;
                GrigliaPiccola10_2.Location = new Point(819, GrigliaPiccola10_2.Location.Y);
                GrigliaPiccola10_3.Location = new Point(898, GrigliaPiccola10_2.Location.Y);
                GrigliaPiccola10_4.Location = new Point(974, GrigliaPiccola10_2.Location.Y);
                GrigliaPiccola10_5.Location = new Point(1049, GrigliaPiccola10_2.Location.Y);
                GrigliaPiccola10_6.Location = new Point(1125, GrigliaPiccola10_2.Location.Y);
                a_GrigliaPiccola10.Location = new Point(a_GrigliaPiccola10.Location.X, 63);
                b_GrigliaPiccola10.Location = new Point(a_GrigliaPiccola10.Location.X, 140);
                c_GrigliaPiccola10.Location = new Point(a_GrigliaPiccola10.Location.X, 225);
                d_GrigliaPiccola10.Location = new Point(a_GrigliaPiccola10.Location.X, 287);
                e_GrigliaPiccola10.Location = new Point(a_GrigliaPiccola10.Location.X, 360);
                f_GrigliaPiccola10.Location = new Point(a_GrigliaPiccola10.Location.X, 440);
                naveDassalto1Griglia10x10.Height = 105; naveDassalto1Griglia10x10.Width = 105;
                naveDassalto2Griglia10x10.Height = 105; naveDassalto2Griglia10x10.Width = 105;
                naveDassalto3Griglia10x10.Height = 105; naveDassalto3Griglia10x10.Width = 105;
            }
            for (int i = 0; i < 88; i++)//inizializza le picturebox
            {
                attaccoMancatoGiocatore1[i] = pictureDaCopiare;
                attaccoMancatoGiocatore1[i].Visible = false;
                attaccoMancatoGiocatore1[i].Image = Properties.Resources.attaccoNaveMancata10x10;
                if (Program.multigiocatore)//nel caso il gioco sia impostato su multigiocatore
                {
                    attaccoMancatoGiocatore2[i] = pictureDaCopiare;
                    attaccoMancatoGiocatore2[i].Visible = false;
                    attaccoMancatoGiocatore2[i].Image = Properties.Resources.attaccoNaveMancata10x10;
                }
            }
            for (int i = 0; i < 22; i++)
            {
                attaccoColpitoGiocatore1[i] = pictureDaCopiare;
                attaccoColpitoGiocatore1[i].Visible = false;
                attaccoColpitoGiocatore1[i].Image = Properties.Resources.attaccoNaveAffondata10x10;
                if (Program.multigiocatore)
                {
                    attaccoColpitoGiocatore2[i] = pictureDaCopiare;
                    attaccoColpitoGiocatore2[i].Visible = false;
                    attaccoColpitoGiocatore2[i].Image = Properties.Resources.attaccoNaveAffondata10x10;
                }
            }
            selezioneAttacco1.Image = Properties.Resources.selezione_Attacco_Griglia10x10;
            selezioneAttacco2.Image = Properties.Resources.selezione_Attacco2_Griglia10x10;
        }
        private void Gameplay_FormClosed(object sender, FormClosedEventArgs e)//per chiudere il form
        {
            Application.Exit();
        }

        //Griglia 10 x 10 caselle. partita normale
        private static string[] StrutturaGriglia10 = new string[] {"acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
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
        private static string[] StrutturaGriglia6 = new string[]  {"acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no",
                                                                   "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no", "acqua1,acqua2,G1_no,G2_no" };

        //picturebox che servono per indicare ai giocatori se colpiscono o meno le navi nemiche
        int naviColpiteGiocatore1 = 0, naviColpiteGiocatore2 = 0;
        int naviMancateGiocatore1 = 0, naviMancateGiocatore2 = 0;
        PictureBox[] attaccoMancatoGiocatore1 = new PictureBox[88];
        PictureBox[] attaccoColpitoGiocatore1 = new PictureBox[22];
        PictureBox[] attaccoMancatoGiocatore2 = new PictureBox[88];
        PictureBox[] attaccoColpitoGiocatore2 = new PictureBox[22];

        #region Variabili Per il Fuzionamento dell Programma + Tasto "Conferma", "Annulla" e "Passa Turno"
        int nTurno = -1, nTimerRadar;
        int naviPosizionate = 0;
        int sottomarini, cacciatorpedinieri, naviDassalto;
        bool disposizioneNaviPossibile = true;
        bool portaereiPosizionata, corazzataPosizionata, sottomarinoPosizionato1, sottomarinoPosizionato2, cacciatorpedinierePosizionato1, cacciatorpedinierePosizionato2, naveDassaltoPosizionata1, naveDassaltoPosizionata2, naveDassaltoPosizionata3;
        bool confirmButtonPressed = false, exitOperation = false;
        private void confermaButton_Click(object sender, EventArgs e)
        {
            confirmButtonPressed = true;
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            exitOperation = true;
            confermaButton.Visible = false;
        }

        bool attacco1 = false, attacco2 = false;
        private void passaTurnoButton_Click(object sender, EventArgs e) //passa il turno, quindi riporta tutte le variabili al loro stato originale, 
                                                                        //per permettere al secondo giocatore di posizionare le sue navi e di registrarle nella griglia (array)
        {
            nTurno++; nave = "";
            contatoreTurni.Text = nTurno.ToString();
            confirmButtonPressed = false;
            passaTurnoButton.Visible = false;
            if(nTurno < 1)
            {
                messaggioGiaMostrato = false;
            }
            if(nTurno > 0)
            {
                naveColpitaDimostrativo.Visible = true;
                naveMancataDimostrativo.Visible = true;
                colpitoDimostrativo.Visible = true;
                mancatoDimostrativo.Visible = true;
            }
            if (nTurno == 0)//riporta le navi invisibili, permettendo al secondo giocatore di poterle piazzare
            {
                portaereiGriglia10x10.Visible = false; portaereiImaggineGirata = false; quantitàPortaerei.Text = "1"; portaereiPosizionata = false; portaereiGriglia10x10.Width = 315; portaereiGriglia10x10.Height = 63; portaereiGriglia10x10.Image = Properties.Resources.portaerei_Griglia10x10;

                corazzataGriglia10x10.Visible = false; corazzataImaggineGirata = false; quantitàCorazzata.Text = "1"; corazzataPosizionata = false; corazzataGriglia10x10.Width = 252; corazzataGriglia10x10.Height = 63; corazzataGriglia10x10.Image = Properties.Resources.corazzata_Griglia10x10;

                sottomarino1Griglia10x10.Visible = false; sottomarino2Griglia10x10.Visible = false; sottomarinoImmagineGirata1 = false; sottomarinoImmagineGirata2 = false; quantitàSottomarini.Text = "2"; sottomarini = 2; sottomarinoPosizionato1 = false; sottomarinoPosizionato2 = false;
                sottomarino1Griglia10x10.Width = 189; sottomarino1Griglia10x10.Height = 63; sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10; sottomarino2Griglia10x10.Width = 189; sottomarino2Griglia10x10.Height = 63; sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10;

                cacciatorpediniere1Griglia10x10.Visible = false; cacciatorpediniere2Griglia10x10.Visible = false; cacciatorpediniereImmagineGirata1 = false; cacciatorpediniereImmagineGirata2 = false; quantitàCacciatorpediniere.Text = "2"; cacciatorpedinieri = 2; cacciatorpedinierePosizionato1 = false; cacciatorpedinierePosizionato2 = false;
                cacciatorpediniere1Griglia10x10.Width = 126; cacciatorpediniere1Griglia10x10.Height = 63; cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10; cacciatorpediniere2Griglia10x10.Width = 126; cacciatorpediniere2Griglia10x10.Height = 63; cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10;

                naveDassalto1Griglia10x10.Visible = false; naveDassalto2Griglia10x10.Visible = false; naveDassalto3Griglia10x10.Visible = false; quantitàNaveDassalto.Text = "3"; naviDassalto = 3; naveDassaltoPosizionata1 = false; naveDassaltoPosizionata2 = false; naveDassaltoPosizionata3 = false;

                player1PictureBox.Visible = false;
                player2PictureBox.Visible = true;
            }
            else if (nTurno == 1)//nel caso entrambi i giocatori sono sicuri della loro decisione sull'allocare le navi nelle rispettive posizioni, comincia il gioco
            {
                IstruzioniAttacco f5 = new IstruzioniAttacco();
                f5.Show();//per mostrare le istruzioni di come attaccare

                player1PictureBox.Visible = true;
                player2PictureBox.Visible = false;

                mostraNavi(posizioneNaviGiocatore1);

                turnoLabel.Visible = true; contatoreTurni.Visible = true; contatoreTurni.Text = nTurno.ToString();
                quantitàPortaerei.Visible = false; quantitàCorazzata.Visible = false; quantitàSottomarini.Visible = false;
                quantitàCacciatorpediniere.Visible = false; quantitàNaveDassalto.Visible = false;
                portaereiPictureBox10x10.Visible = false; corazzataPcitureBox10x10.Visible = false; sottomarinoPictureBox10x10.Visible = false;
                cacciatorpedinierePictureBox10x10.Visible = false; naveDassaltoPictureBox10x10.Visible = false;
                grigliaDiGiocoPiccola.Visible = true;
                movimentoDisposizioneNavi.Enabled = true;
                attacco1 = true; selezioneAttacco1.Visible = true;
                confermaButton.Visible = true;
                radarPcitureBox.Visible = true; countdownRadar.Visible = true; nTimerRadar = Convert.ToInt32(countdownRadar.Text); nTimerRadar--; countdownRadar.Text = nTimerRadar.ToString();
                doppioAssaltoPictureBox.Visible = true; quantitàAssaltoDoppio.Visible = true;
            }
            else if(nTurno % 2 == 1)//round giocatore 1
            {
                player1PictureBox.Visible = true; player2PictureBox.Visible = false;
                quantitàAssaltoDoppio.Text = Program.quantitàAssaltoDoppioGiocatore1.ToString();
                mostraNavi(posizioneNaviGiocatore1);
                selezioneAttacco1.Visible = true;
                selezioneAttacco1.Location = new Point(899, 221);
                attacco1 = true; attacco2 = false;
                confermaButton.Visible = true;
                if(Program.quantitàAssaltoDoppioGiocatore1 == 0)
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssaltoScalaGrigio;
                }
                else
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssalto;
                }
                //mostra le navi del giocatore 1
                for(int i = 0; i < naviColpiteGiocatore1; i++)
                {
                    attaccoColpitoGiocatore1[i].Visible = true;
                }
                for (int i = 0; i < naviMancateGiocatore1; i++)
                {
                    attaccoMancatoGiocatore1[i].Visible = true;
                }
                //nasconde le navi del giocatore 2
                for (int i = 0; i < naviColpiteGiocatore2; i++)
                {
                    attaccoColpitoGiocatore2[i].Visible = false;
                }
                for (int i = 0; i < naviMancateGiocatore2; i++)
                {
                    attaccoMancatoGiocatore2[i].Visible = false;
                }
            }
            else if(nTurno % 2 == 0)//round giocatore 2
            {
                player1PictureBox.Visible = false; player2PictureBox.Visible = true;
                quantitàAssaltoDoppio.Text = Program.quantitàAssaltoDoppioGiocatore2.ToString();
                mostraNavi(posizioneNaviGiocatore2);
                selezioneAttacco1.Location = new Point(899, 221);
                attacco1 = true; attacco2 = false;
                confermaButton.Visible = true;
                if (Program.quantitàAssaltoDoppioGiocatore2 == 0)
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssaltoScalaGrigio;
                }
                else
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssalto;
                }
                //nasconde le navi del giocatore 1
                for (int i = 0; i < naviColpiteGiocatore1; i++)
                {
                    attaccoColpitoGiocatore1[i].Visible = false;
                }
                for (int i = 0; i < naviMancateGiocatore1; i++)
                {
                    attaccoMancatoGiocatore1[i].Visible = false;
                }
                //mostra le navi del giocatore 2
                for (int i = 0; i < naviColpiteGiocatore2; i++)
                {
                    attaccoColpitoGiocatore2[i].Visible = true;
                }
                for (int i = 0; i < naviMancateGiocatore2; i++)
                {
                    attaccoMancatoGiocatore2[i].Visible = true;
                }
            }
        }

        private void doppioAssaltoPictureBox_Click(object sender, EventArgs e)
        {
            if (player1PictureBox.Visible)
            {
                if(Program.quantitàAssaltoDoppioGiocatore1 > 0)
                {
                    doppioAssaltoEventi();
                }
            }
            else
            {
                if (Program.quantitàAssaltoDoppioGiocatore2 > 0)
                {
                    doppioAssaltoEventi();
                }
            }
        }

        private void doppioAssaltoEventi()
        {
            if (attacco1)
            {
                MessageBox.Show("Prima devi confermare il primo attacco");
            }
            else
            {
                if (!attacco2)
                {
                    attacco2 = true;
                    selezioneAttacco2.Visible = true;
                    confermaButton.Visible = true; annullaButton.Visible = true;
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssaltoScalaGrigio;
                    if (player1PictureBox.Visible)
                    {
                        quantitàAssaltoDoppio.Text = (Program.quantitàAssaltoDoppioGiocatore1 - 1).ToString();
                    }
                    else
                    {
                        quantitàAssaltoDoppio.Text = (Program.quantitàAssaltoDoppioGiocatore1 - 1).ToString();
                    }
                }
            }
        }

        #endregion

        //per salvare la posizione di tutte le navi per poi mostrare a schermo le rispettive navi di ogni giocatore
        string[] posizioneNaviGiocatore1 = new string[9]; int naviPosizionateGiocatore1 = 0;
        string[] posizioneNaviGiocatore2 = new string[9]; int naviPosizionateGiocatore2 = 0;
        private void locazioneNavi(string imbarcazione, bool immagineGirata, int posX, int posY)
        {
            if (player1PictureBox.Visible)
            {
                posizioneNaviGiocatore1[naviPosizionateGiocatore1] = ($"{imbarcazione},{posX},{posY},{immagineGirata}");
                naviPosizionateGiocatore1++;
            }
            else
            {
                posizioneNaviGiocatore2[naviPosizionateGiocatore2] = ($"{imbarcazione},{posX},{posY},{immagineGirata}");
                naviPosizionateGiocatore2++;
            }
        }
        private void mostraNavi(string[] dettagliNavi)
        {
            for(int i = 0; i < dettagliNavi.Length; i++)
            {
                string[] caratteristicheImbarcazione = dettagliNavi[i].Split(',');
                switch (caratteristicheImbarcazione[0])
                {
                    case "portaerei":
                        portaereiGriglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        if (Convert.ToBoolean(caratteristicheImbarcazione[3]))
                        {
                            portaereiGriglia10x10.Width = 63; portaereiGriglia10x10.Height = 315;
                            portaereiGriglia10x10.Image = Properties.Resources.portaerei_Griglia10x10Verticale;
                        }
                        else
                        {
                            portaereiGriglia10x10.Width = 315; portaereiGriglia10x10.Height = 63;
                            portaereiGriglia10x10.Image = Properties.Resources.portaerei_Griglia10x10;
                        }
                        break;
                    case "corazzata":
                        corazzataGriglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        if (Convert.ToBoolean(caratteristicheImbarcazione[3]))
                        {
                            corazzataGriglia10x10.Width = 63; corazzataGriglia10x10.Height = 252;
                            corazzataGriglia10x10.Image = Properties.Resources.corazzata_Griglia10x10Verticale;
                        }
                        else
                        {
                            corazzataGriglia10x10.Width = 252; corazzataGriglia10x10.Height = 63;
                            corazzataGriglia10x10.Image = Properties.Resources.corazzata_Griglia10x10;
                        }
                        break;
                    case "sottomarino1":
                        sottomarino1Griglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        if (Convert.ToBoolean(caratteristicheImbarcazione[3]))
                        {
                            sottomarino1Griglia10x10.Width = 63; sottomarino1Griglia10x10.Height = 189;
                            sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10Verticale;
                        }
                        else
                        {
                            sottomarino1Griglia10x10.Width = 189; sottomarino1Griglia10x10.Height = 63;
                            sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10;
                        }
                        break;
                    case "sottomarino2":
                        sottomarino2Griglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        if (Convert.ToBoolean(caratteristicheImbarcazione[3]))
                        {
                            sottomarino2Griglia10x10.Width = 63; sottomarino2Griglia10x10.Height = 189;
                            sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10Verticale;
                        }
                        else
                        {
                            sottomarino2Griglia10x10.Width = 189; sottomarino2Griglia10x10.Height = 63;
                            sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia10x10;
                        }
                        break;
                    case "cacciatorpediniere1":
                        cacciatorpediniere1Griglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        if (Convert.ToBoolean(caratteristicheImbarcazione[3]))
                        {
                            cacciatorpediniere1Griglia10x10.Width = 63; cacciatorpediniere1Griglia10x10.Height = 126;
                            cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10Verticale;
                        }
                        else
                        {
                            cacciatorpediniere1Griglia10x10.Width = 126; cacciatorpediniere1Griglia10x10.Height = 63;
                            cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10;
                        }
                        break;
                    case "cacciatorpediniere2":
                        cacciatorpediniere2Griglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        if (Convert.ToBoolean(caratteristicheImbarcazione[3]))
                        {
                            cacciatorpediniere2Griglia10x10.Width = 63; cacciatorpediniere2Griglia10x10.Height = 126;
                            cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10Verticale;
                        }
                        else
                        {
                            cacciatorpediniere2Griglia10x10.Width = 126; cacciatorpediniere2Griglia10x10.Height = 63;
                            cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia10x10;
                        }
                        break;
                    case "nave d'assalto1":
                        naveDassalto1Griglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        break;
                    case "nave d'assalto2":
                        naveDassalto2Griglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        break;
                    case "nave d'assalto3":
                        naveDassalto3Griglia10x10.Location = new Point(Convert.ToInt32(caratteristicheImbarcazione[1]), Convert.ToInt32(caratteristicheImbarcazione[2]));
                        break;
                }
            }
        }

        #region Disposizione Navi
        string nave = ""; bool messaggioGiaMostrato = false;
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
                        confermaButton.Visible = false;
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
                        confermaButton.Visible = false;
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
                        confermaButton.Visible = false;
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
                        confermaButton.Visible = false;
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
                        confermaButton.Visible = false;
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
            //quando tutte le navi di un giocatore sono pisizionate
            if (portaereiPosizionata && corazzataPosizionata && sottomarinoPosizionato1 && sottomarinoPosizionato2 && cacciatorpedinierePosizionato1 && cacciatorpedinierePosizionato2 && naveDassaltoPosizionata1 && naveDassaltoPosizionata2 && naveDassaltoPosizionata3 && messaggioGiaMostrato == false)
            {
                passaTurnoButton.Visible = true;
                confermaButton.Visible = false;
                naviPosizionate = 0;
                messaggioGiaMostrato = true;
                MessageBox.Show("Hai dispiegato in campo tutte le navi\nClicca il pulsante 'Passa il turno'");
            }
            //funzioni che si occupano dell'attacco delle navi nemiche
            if (attacco1)
            {
                if (moveUp && selezioneAttacco1.Top > 85 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Top -= 45;
                }
                if (moveDown && selezioneAttacco1.Top < 445 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Top += 45;
                }
                if (moveRight && selezioneAttacco1.Right < 1168 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Left += 45;
                }
                if (moveLeft && selezioneAttacco1.Left > 763 && !confirmButtonPressed)
                {
                    selezioneAttacco1.Left -= 45;
                }
                if (confirmButtonPressed)
                {
                    int coordinateAttacco = assegnazionePosizioneAttacco(selezioneAttacco1.Location.X, selezioneAttacco1.Location.Y);//trova la casella su cui è al momento la selezione dell'attacco del giocatore 1
                    bool attaccoValido = controlloAttacco(ref coordinateAttacco);
                    if (attaccoValido)
                    {
                        string[] confermaAttacco = StrutturaGriglia10[coordinateAttacco].Split(',');
                        if (player1PictureBox.Visible)
                        {
                            confermaAttacco[2] = "G1_attacco";
                        }
                        else
                        {
                            confermaAttacco[3] = "G2_attacco";
                        }
                        StrutturaGriglia10[coordinateAttacco] = $"{confermaAttacco[0]},{confermaAttacco[1]},{confermaAttacco[2]},{confermaAttacco[3]}";
                        attacco1 = false;//permette l'eventuale secondo attacco
                        confirmButtonPressed = false;
                        annullaButton.Visible = false;
                        confermaButton.Visible = false;
                        passaTurnoButton.Visible = true;
                        attaccoAlleNavi(confermaAttacco, selezioneAttacco1);
                    }
                }
            }

            if (attacco2)//eventuale doppio assalto
            {
                if (moveUp && selezioneAttacco2.Top > 85 && !confirmButtonPressed)
                {
                    selezioneAttacco2.Top -= 45;
                }
                if (moveDown && selezioneAttacco2.Top < 445 && !confirmButtonPressed)
                {
                    selezioneAttacco2.Top += 45;
                }
                if (moveRight && selezioneAttacco2.Right < 1168 && !confirmButtonPressed)
                {
                    selezioneAttacco2.Left += 45;
                }
                if (moveLeft && selezioneAttacco2.Left > 763 && !confirmButtonPressed)
                {
                    selezioneAttacco2.Left -= 45;
                }
                if (confirmButtonPressed)
                {
                    int coordinateAttacco2 = assegnazionePosizioneAttacco(selezioneAttacco2.Location.X, selezioneAttacco2.Location.Y);
                    bool attaccoValido = controlloAttacco(ref coordinateAttacco2);
                    if (attaccoValido)
                    {
                        string[] confermaAttacco = StrutturaGriglia10[coordinateAttacco2].Split(',');
                        if (player1PictureBox.Visible)
                        {
                            confermaAttacco[2] = "G1_attacco";
                        }
                        else
                        {
                            confermaAttacco[3] = "G2_attacco";
                        }
                        StrutturaGriglia10[coordinateAttacco2] = $"{confermaAttacco[0]},{confermaAttacco[1]},{confermaAttacco[2]},{confermaAttacco[3]}";
                        confermaButton.Visible = false;
                        confirmButtonPressed = false;
                        annullaButton.Visible = false;
                        passaTurnoButton.Visible = true;
                        attaccoAlleNavi(confermaAttacco, selezioneAttacco2);
                    }
                    else
                    {
                        MessageBox.Show("Non puoi selezionare una casella precedentemente attaccata");
                    }
                }
                if (exitOperation)
                {
                    selezioneAttacco2.Visible = false;
                    attacco2 = false;
                    exitOperation = false;
                    annullaButton.Visible = false;
                    confermaButton.Visible = false;
                    quantitàAssaltoDoppio.Text = (Convert.ToInt32(quantitàAssaltoDoppio.Text) + 1).ToString();
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssalto;
                }
            }
        }

        private void attaccoAlleNavi(string[] nave, PictureBox attacco)//controlla se un giocatore colpisce o manca una nave
        {
            if (player1PictureBox.Visible)
            {
                if(nave[0] != "acqua1")
                {
                    attaccoColpitoGiocatore1[naviColpiteGiocatore1].Location = new Point(attacco.Location.X, attacco.Location.Y);
                    attaccoColpitoGiocatore1[naviColpiteGiocatore1].Visible = true;
                    naviColpiteGiocatore1++;
                }
                else
                {
                    attaccoMancatoGiocatore1[naviMancateGiocatore1].Location = new Point(attacco.Location.X, attacco.Location.Y);
                    attaccoMancatoGiocatore1[naviMancateGiocatore1].Visible = true;
                    naviMancateGiocatore1++;
                }
            }
            else
            {
                if (nave[1] != "acqua2")
                {
                    attaccoColpitoGiocatore2[naviColpiteGiocatore2].Location = new Point(attacco.Location.X, attacco.Location.Y);
                    attaccoColpitoGiocatore2[naviColpiteGiocatore2].Visible = true;
                    naviColpiteGiocatore2++;
                }
                else
                {
                    attaccoMancatoGiocatore2[naviMancateGiocatore2].Location = new Point(attacco.Location.X, attacco.Location.Y);
                    attaccoMancatoGiocatore2[naviMancateGiocatore2].Visible = true;
                    naviMancateGiocatore2++;
                }
            }
        }

        //funzioni che si occupano di rilevare l'input dei tasti da parte dell'utente
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

        #region Controllo Degli Attacchi
        private int assegnazionePosizioneAttacco(int posX, int posY)//come per la navi, viene assegnato un valore numerico nell'array per l'attacco
        {
            int coordAtt_XY = 0;
            string[] coord_XY_Codifica = new string[2];

            switch (posY)
            {
                case 41:
                    coord_XY_Codifica[0] = "-1"; break; //casella A
                case 86:
                    coord_XY_Codifica[0] = "9"; break; //casella B
                case 131:
                    coord_XY_Codifica[0] = "19"; break; //casella C
                case 176:
                    coord_XY_Codifica[0] = "29"; break; //casella D
                case 221:
                    coord_XY_Codifica[0] = "39"; break; //casella E
                case 266:
                    coord_XY_Codifica[0] = "49"; break; //casella F
                case 311:
                    coord_XY_Codifica[0] = "59"; break; //casella G
                case 356:
                    coord_XY_Codifica[0] = "69"; break; //casella H
                case 401:
                    coord_XY_Codifica[0] = "79"; break; //casella I
                case 446:
                    coord_XY_Codifica[0] = "89"; break; //casella L
            }

            switch (posX)
            {
                case 719:
                    coord_XY_Codifica[1] = "1"; break;
                case 764:
                    coord_XY_Codifica[1] = "2"; break;
                case 809:
                    coord_XY_Codifica[1] = "3"; break;
                case 854:
                    coord_XY_Codifica[1] = "4"; break;
                case 899:
                    coord_XY_Codifica[1] = "5"; break;
                case 944:
                    coord_XY_Codifica[1] = "6"; break;
                case 989:
                    coord_XY_Codifica[1] = "7"; break;
                case 1034:
                    coord_XY_Codifica[1] = "8"; break;
                case 1079:
                    coord_XY_Codifica[1] = "9"; break;
                case 1124:
                    coord_XY_Codifica[1] = "10"; break;
            }

            coordAtt_XY = Convert.ToInt32(coord_XY_Codifica[0]) + Convert.ToInt32(coord_XY_Codifica[1]);

            return coordAtt_XY;
        } 

        private bool controlloAttacco(ref int coordinateAttacco)//controlla se in una determinata casella non si già stato effettuato un attacco
        {
            bool validitàDellAttacco = false;

            string[] checkAttack = StrutturaGriglia10[coordinateAttacco].Split(',');
            if (player1PictureBox.Visible)
            {
                if(checkAttack[2] == "G1_no")
                {
                    validitàDellAttacco = true;
                }
            }
            else
            {
                if (checkAttack[3] == "G2_no")
                {
                    validitàDellAttacco = true;
                }
            }

            return validitàDellAttacco;
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
                            locazioneNavi("portaerei", portaereiImaggineGirata, portaereiGriglia10x10.Location.X, portaereiGriglia10x10.Location.Y);
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
                            locazioneNavi("portaerei", portaereiImaggineGirata, portaereiGriglia10x10.Location.X, portaereiGriglia10x10.Location.Y);
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
                            locazioneNavi("corazzata", corazzataImaggineGirata, corazzataGriglia10x10.Location.X, corazzataGriglia10x10.Location.Y);
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
                            locazioneNavi("corazzata", corazzataImaggineGirata, corazzataGriglia10x10.Location.X, corazzataGriglia10x10.Location.Y);
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
                                    locazioneNavi("sottomarino1", sottomarinoImmagineGirata1, sottomarino1Griglia10x10.Location.X, sottomarino1Griglia10x10.Location.Y);
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
                                    locazioneNavi("sottomarino1", sottomarinoImmagineGirata1, sottomarino1Griglia10x10.Location.X, sottomarino1Griglia10x10.Location.Y);
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
                                    locazioneNavi("sottomarino2", sottomarinoImmagineGirata2, sottomarino2Griglia10x10.Location.X, sottomarino2Griglia10x10.Location.Y);
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
                                    locazioneNavi("sottomarino2", sottomarinoImmagineGirata2, sottomarino2Griglia10x10.Location.X, sottomarino2Griglia10x10.Location.Y);
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
                                    locazioneNavi("cacciatorpediniere1", cacciatorpediniereImmagineGirata1, cacciatorpediniere1Griglia10x10.Location.X, cacciatorpediniere1Griglia10x10.Location.Y);
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
                                    locazioneNavi("cacciatorpediniere1", cacciatorpediniereImmagineGirata1, cacciatorpediniere1Griglia10x10.Location.X, cacciatorpediniere1Griglia10x10.Location.Y);
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
                                    locazioneNavi("cacciatorpediniere2", cacciatorpediniereImmagineGirata2, cacciatorpediniere2Griglia10x10.Location.X, cacciatorpediniere2Griglia10x10.Location.Y);
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
                                    locazioneNavi("cacciatorpediniere2", cacciatorpediniereImmagineGirata2, cacciatorpediniere2Griglia10x10.Location.X, cacciatorpediniere2Griglia10x10.Location.Y);
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
                                locazioneNavi("nave d'assalto1", false, naveDassalto1Griglia10x10.Location.X, naveDassalto1Griglia10x10.Location.Y);
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
                                locazioneNavi("nave d'assalto2", false, naveDassalto2Griglia10x10.Location.X, naveDassalto2Griglia10x10.Location.Y);
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
                                locazioneNavi("nave d'assalto3", false, naveDassalto3Griglia10x10.Location.X, naveDassalto3Griglia10x10.Location.Y);
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
            int[] controlloLatoDestroNave = new int[] { 1, 11, 21, 31, 41 };
            int[] controlloLatoSinistroNave = new int[] { -1, 9, 19, 29, 39 };
            int[] latoSinistroGriglia = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90};
            int[] latoDestroGriglia = new int[] { 9, 19, 29, 39, 49, 59, 69, 79, 89 };
            for (int i = 0; i < 9; i++)//per rimuovere il controllo in eccesso, in quanto si trova agli estremi della griglia
            {
                if(coordinateNaveSuGrigliaArray == latoSinistroGriglia[i] || coordinateNaveSuGrigliaArray == 0)//parte sinistra della griglia
                {
                    if (!immagineGirata)//se l'iimagine non è girata
                    {
                        posizioniDaControllare = posizioniDaControllare.RemoveFromArray(-1);//rimuove il controllo alla poppa della nave
                    }
                    else
                    {
                        for(int j = 0; j < controlloLatoSinistroNave.Length; j++)
                        {
                            posizioniDaControllare = posizioniDaControllare.RemoveFromArray(controlloLatoSinistroNave[j]);//rimuove i controlli a lato della nave
                        }
                    }
                    break;
                }
                if(coordinateNaveSuGrigliaArray == latoDestroGriglia[i])//parte di destra della griglia
                {
                    if (!immagineGirata)
                    {
                        posizioniDaControllare = posizioniDaControllare.RemoveFromArray(indexToRemove);
                    }
                    else
                    {
                        for(int j = 0; j < controlloLatoDestroNave.Length; j++)
                        {
                            posizioniDaControllare = posizioniDaControllare.RemoveFromArray(controlloLatoDestroNave[j]);
                        }
                    }
                    break;
                }
            }
        }
        #endregion
    }
}
