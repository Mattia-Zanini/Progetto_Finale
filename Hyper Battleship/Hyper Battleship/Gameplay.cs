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

//dimensioni originali 1374; 720
namespace Hyper_Battleship
{
    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
            this.Width = 1374;
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
                naveDassalto1Griglia10x10.Height = 105; naveDassalto1Griglia10x10.Width = 105; naveDassalto1Griglia10x10.Image = Properties.Resources.Nave_D_Assalto_Griglia6x6;
                naveDassalto2Griglia10x10.Height = 105; naveDassalto2Griglia10x10.Width = 105; naveDassalto2Griglia10x10.Image = Properties.Resources.Nave_D_Assalto_Griglia6x6;
                naveDassalto3Griglia10x10.Height = 105; naveDassalto3Griglia10x10.Width = 105; naveDassalto3Griglia10x10.Image = Properties.Resources.Nave_D_Assalto_Griglia6x6;
                cacciatorpediniere1Griglia10x10.Height = 105; cacciatorpediniere1Griglia10x10.Width = 210; cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia6x6;
                cacciatorpediniere2Griglia10x10.Height = 105; cacciatorpediniere2Griglia10x10.Width = 210; cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia6x6;
                sottomarino1Griglia10x10.Height = 105; sottomarino1Griglia10x10.Width = 315; sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia6x6;
                sottomarino2Griglia10x10.Height = 105; sottomarino2Griglia10x10.Width = 315; sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia6x6;

                selezioneAttacco1.Width = 75; selezioneAttacco1.Height = 75;
                selezioneAttacco2.Width = 75; selezioneAttacco2.Height = 75;
                radarGrigliaPictureBox.Width = 105; radarGrigliaPictureBox.Height = 105;
                quantitàAssaltoDoppioGiocatore1 = 1; quantitàAssaltoDoppioGiocatore2 = 1;

                //serve per ingrandire le picturebox che di default sono 45x45(partita normale) a 75x75 (partita veloce)
                naveIndividuataPictureBoxResize();
                naveColpitaResize();
                naveMancataResize();
            }
            else
            {
                grigliaDiGiocoGrande.Image = Properties.Resources.Griglia10x10;
                grigliaDiGiocoPiccola.Image = Properties.Resources.griglia_Piccola_10x10;
                selezioneAttacco1.Image = Properties.Resources.selezione_Attacco_Griglia10x10;
                selezioneAttacco2.Image = Properties.Resources.selezione_Attacco2_Griglia10x10;
            }

            controlloPresenzaFileSalvataggioClassiica();
        }

        static string nomeFileClassifica = @"ClassificaGiocatori.txt";
        static string percorsoSalvataggioClassificaGiocatori = AppDomain.CurrentDomain.BaseDirectory + nomeFileClassifica;
        private void controlloPresenzaFileSalvataggioClassiica()//cotrnolla se c'è il file nel percorso prestabilito, nel caso non ci sia, il programma lo crea
        {
            if (!File.Exists(percorsoSalvataggioClassificaGiocatori)) { using (StreamWriter sw = File.CreateText(percorsoSalvataggioClassificaGiocatori)) { } }
        }

        private void naveIndividuataPictureBoxResize()
        {
            naveIndividuata_1.Size = new Size(75, 75);
            naveIndividuata_2.Size = new Size(75, 75);
            naveIndividuata_3.Size = new Size(75, 75);
            naveIndividuata_4.Size = new Size(75, 75);
            naveIndividuata_5.Size = new Size(75, 75);
            naveIndividuata_6.Size = new Size(75, 75);
            naveIndividuata_7.Size = new Size(75, 75);
            naveIndividuata_8.Size = new Size(75, 75);
            naveIndividuata_9.Size = new Size(75, 75);
            naveIndividuata_10.Size = new Size(75, 75);
        }

        private void naveColpitaResize()
        {
            naveColpita_1.Size = new Size(75, 75);
            naveColpita_2.Size = new Size(75, 75);
            naveColpita_3.Size = new Size(75, 75);
            naveColpita_4.Size = new Size(75, 75);
            naveColpita_5.Size = new Size(75, 75);
            naveColpita_6.Size = new Size(75, 75);
            naveColpita_7.Size = new Size(75, 75);
            naveColpita_8.Size = new Size(75, 75);
            naveColpita_9.Size = new Size(75, 75);
            naveColpita_10.Size = new Size(75, 75);
        }

        private void naveMancataResize()
        {
            naveMancata_1.Size = new Size(75, 75);
            naveMancata_2.Size = new Size(75, 75);
            naveMancata_3.Size = new Size(75, 75);
            naveMancata_4.Size = new Size(75, 75);
            naveMancata_5.Size = new Size(75, 75);
            naveMancata_6.Size = new Size(75, 75);
            naveMancata_7.Size = new Size(75, 75);
            naveMancata_8.Size = new Size(75, 75);
            naveMancata_9.Size = new Size(75, 75);
            naveMancata_10.Size = new Size(75, 75);
            naveMancata_11.Size = new Size(75, 75);
            naveMancata_12.Size = new Size(75, 75);
            naveMancata_13.Size = new Size(75, 75);
            naveMancata_14.Size = new Size(75, 75);
            naveMancata_15.Size = new Size(75, 75);
            naveMancata_16.Size = new Size(75, 75);
            naveMancata_17.Size = new Size(75, 75);
            naveMancata_18.Size = new Size(75, 75);
            naveMancata_19.Size = new Size(75, 75);
            naveMancata_20.Size = new Size(75, 75);
            naveMancata_21.Size = new Size(75, 75);
            naveMancata_22.Size = new Size(75, 75);
            naveMancata_23.Size = new Size(75, 75);
            naveMancata_24.Size = new Size(75, 75);
            naveMancata_25.Size = new Size(75, 75);
            naveMancata_26.Size = new Size(75, 75);
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
        int naviIndividuateGiocatore1 = 0; int naviIndividuateGiocatore2 = 0;

        #region Variabili Per il Fuzionamento dell Programma + Tasto "Conferma", "Annulla" e "Passa Turno"
        int quantitàAssaltoDoppioGiocatore1 = 2, quantitàAssaltoDoppioGiocatore2 = 2;
        int nTurno = -1, nTimerRadar1 = 14, nTimerRadar2 = 14;
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
            if (nTurno == 0 && nTurno < 3)//riporta le navi invisibili, permettendo al secondo giocatore di poterle piazzare
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
            else if (nTurno == 1 && nTurno < 3)//nel caso entrambi i giocatori sono sicuri della loro decisione sull'allocare le navi nelle rispettive posizioni, comincia il gioco
            {
                IstruzioniAttacco f5 = new IstruzioniAttacco();
                f5.Show();//per mostrare le istruzioni di come attaccare

                player1PictureBox.Visible = true;
                player2PictureBox.Visible = false;

                mostraNavi(posizioneNaviGiocatore1);

                //per mostrare il punteggio dei giocatori
                puntiLabel.Visible = true;
                puntiCount.Visible = true;
                puntiCount.Text = Program.scoreGiocatore1.ToString();

                turnoLabel.Visible = true; contatoreTurni.Visible = true; contatoreTurni.Text = nTurno.ToString();
                quantitàPortaerei.Visible = false; quantitàCorazzata.Visible = false; quantitàSottomarini.Visible = false;
                quantitàCacciatorpediniere.Visible = false; quantitàNaveDassalto.Visible = false;
                portaereiPictureBox10x10.Visible = false; corazzataPcitureBox10x10.Visible = false; sottomarinoPictureBox10x10.Visible = false;
                cacciatorpedinierePictureBox10x10.Visible = false; naveDassaltoPictureBox10x10.Visible = false;
                grigliaDiGiocoPiccola.Visible = true;
                movimentoDisposizioneNavi.Enabled = true;
                attacco1 = true; selezioneAttacco1.Visible = true;
                confermaButton.Visible = true;
                radarPictureBox.Visible = true; countdownRadar.Visible = true; nTimerRadar1--; countdownRadar.Text = nTimerRadar1.ToString();
                doppioAssaltoPictureBox.Visible = true; quantitàAssaltoDoppio.Visible = true;
            }
            else if(nTurno % 2 == 1)//round giocatore 1
            {
                puntiCount.Text = Program.scoreGiocatore1.ToString();
                player1PictureBox.Visible = true; player2PictureBox.Visible = false;
                quantitàAssaltoDoppio.Text = quantitàAssaltoDoppioGiocatore1.ToString();
                mostraNavi(posizioneNaviGiocatore1);
                selezioneAttacco1.Visible = true;
                selezioneAttacco1.Location = new Point(899, 221);
                attacco1 = true; attacco2 = false;
                confermaButton.Visible = true;
                if(quantitàAssaltoDoppioGiocatore1 == 0)
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssaltoScalaGrigio;
                }
                else//nel caso il giocatore due abbia finito gli attacchi doppi, riporta l'immagine alla normalità
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssalto;
                }

                nTimerRadar1--; countdownRadar.Text = nTimerRadar1.ToString();
                if (radarUsato1)
                {
                    radarPictureBox.Image = Properties.Resources.RadarScalaGrigio;
                }
                else if (radarUsato1 == false && nTimerRadar1 == 0)
                {
                    countdownRadar.Visible = false;
                    radarPictureBox.Image = Properties.Resources.Radar;
                }
                selezioneAttacco1.BringToFront(); selezioneAttacco2.BringToFront();
                selezioneAttacco2.Visible = false;
                aspettoIndividuazione(naviIndividuateGiocatore2, posizioneNaviIndividuatePictureBoxG2, false);
                aspettoIndividuazione(naviIndividuateGiocatore1, posizioneNaviIndividuatePictureBoxG1, true);
                aspettoAttacchi(naviColpiteGiocatore2, naviMancateGiocatore2, posizioneAttacchiNaviColpitePictureBoxG2, posizioneAttacchiNaviMancatePictureBoxG2, false);
                aspettoAttacchi(naviColpiteGiocatore1, naviMancateGiocatore1, posizioneAttacchiNaviColpitePictureBoxG1, posizioneAttacchiNaviMancatePictureBoxG1, true);
            }
            else if(nTurno % 2 == 0)//round giocatore 2
            {
                puntiCount.Text = Program.scoreGiocatore2.ToString();
                player1PictureBox.Visible = false; player2PictureBox.Visible = true;
                quantitàAssaltoDoppio.Text = quantitàAssaltoDoppioGiocatore2.ToString();
                mostraNavi(posizioneNaviGiocatore2);
                selezioneAttacco1.Location = new Point(899, 221);
                attacco1 = true; attacco2 = false;
                confermaButton.Visible = true;
                if (quantitàAssaltoDoppioGiocatore2 == 0)
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssaltoScalaGrigio;
                }
                else
                {
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssalto;
                }

                nTimerRadar2--; countdownRadar.Text = nTimerRadar2.ToString();
                if (radarUsato2)
                {
                    radarPictureBox.Image = Properties.Resources.RadarScalaGrigio;
                }
                else if(radarUsato2 == false && nTimerRadar2 == 0)
                {
                    countdownRadar.Visible = false;
                    radarPictureBox.Image = Properties.Resources.Radar;
                }
                selezioneAttacco1.BringToFront(); selezioneAttacco2.BringToFront();
                selezioneAttacco2.Visible = false;
                aspettoIndividuazione(naviIndividuateGiocatore1, posizioneNaviIndividuatePictureBoxG1, false);
                aspettoIndividuazione(naviIndividuateGiocatore2, posizioneNaviIndividuatePictureBoxG2, true);
                aspettoAttacchi(naviColpiteGiocatore1, naviMancateGiocatore1, posizioneAttacchiNaviColpitePictureBoxG1, posizioneAttacchiNaviMancatePictureBoxG1, false);
                aspettoAttacchi(naviColpiteGiocatore2, naviMancateGiocatore2, posizioneAttacchiNaviColpitePictureBoxG2, posizioneAttacchiNaviMancatePictureBoxG2, true);
            }
        }

        private void aspettoAttacchi(int nRipetiCicloColpito, int nRipetiCicloMancato, string[] sorgentePosColpito, string[] sorgentePosMancato, bool visibilita)
        {
            for (int i = 0; i < nRipetiCicloColpito; i++)
            {
                string[] posXYAttacco = sorgentePosColpito[i].Split(',');
                posizionePictureBoxDegliAttacchiNaveColpita(i, Convert.ToInt32(posXYAttacco[0]), Convert.ToInt32(posXYAttacco[1]));
                visibilitaPictureBoxDegliAttacchiNaveColpita(i, visibilita);
            }
            for (int i = 0; i < nRipetiCicloMancato; i++)
            {
                string[] posXYAttacco = sorgentePosMancato[i].Split(',');
                posizionePictureBoxDegliAttacchiNaveMancata(i, Convert.ToInt32(posXYAttacco[0]), Convert.ToInt32(posXYAttacco[1]));
                visibilitaPictureBoxDegliAttacchiNaveMancata(i, visibilita);
            }
        }

        private void aspettoIndividuazione(int nRipetiCicloIndividuato, string[] sorgentePosIndividuato, bool visibilitaIndividuazione)
        {
            for (int i = 0; i < nRipetiCicloIndividuato; i++)//giocatore1
            {
                string[] posXYIndividuazione = sorgentePosIndividuato[i].Split(',');
                posizionePictureBoxNaveIndividuata(i, Convert.ToInt32(posXYIndividuazione[0]), Convert.ToInt32(posXYIndividuazione[1]));
                visibilitaPictureBoxDelleNaviIndividuate(i, visibilitaIndividuazione);
            }
        }

        private void doppioAssaltoPictureBox_Click(object sender, EventArgs e)
        {
            //mostra rispettivamente la quantità delle abilità di entrambi i giocatori
            if (player1PictureBox.Visible)
            {
                if(quantitàAssaltoDoppioGiocatore1 > 0)
                {
                    quantitàAssaltoDoppioGiocatore1--;
                    doppioAssaltoEventi();
                }
            }
            else
            {
                if (quantitàAssaltoDoppioGiocatore2 > 0)
                {
                    quantitàAssaltoDoppioGiocatore2--;
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
                if (!attacco2)//per evitare di dare conferma dell'uso dell'abilità se quest'ultima è già attiva
                {
                    attacco2 = true;
                    selezioneAttacco2.Visible = true;
                    confermaButton.Visible = true; annullaButton.Visible = true;
                    doppioAssaltoPictureBox.Image = Properties.Resources.doppioAssaltoScalaGrigio;
                    if (player1PictureBox.Visible)//diminuisce il quantitativo di doppio assalto disponibile al corrispondete giocatore che ha attivato l'abilità in quel turno
                    {
                        quantitàAssaltoDoppio.Text = (quantitàAssaltoDoppioGiocatore1).ToString();
                    }
                    else
                    {                        
                        quantitàAssaltoDoppio.Text = (quantitàAssaltoDoppioGiocatore2).ToString();
                    }
                }
            }
        }

        bool radarAttivo = false, radarUsato1 = false, radarUsato2 = false;
        private void radarPcitureBox_Click(object sender, EventArgs e)//quando un giocatore vuole usare il radar
        {
            if (nTurno > 25)
            {

                if (attacco1 == false && attacco2 == false)
                {
                    if (player1PictureBox.Visible)
                    {
                        if (radarUsato1 == false)
                        {
                            funzioneClickRadar();
                        }
                    }
                    else
                    {
                        if (radarUsato2 == false)
                        {
                            funzioneClickRadar();
                        }
                    }
                }
            }
        }

        private void funzioneClickRadar()
        {
            if (Program.modalità == false)//nel caso la partita sia in modalità veloce
            {
                //radarGrigliaPictureBox.Width = 105; radarGrigliaPictureBox.Height = 105;
                radarGrigliaPictureBox.Location = new Point(945, 267);
            }
            else
            {
                radarGrigliaPictureBox.Location = new Point(899, 311);
            }
            radarGrigliaPictureBox.BringToFront();
            radarAttivo = true;
            radarPictureBox.Image = Properties.Resources.RadarScalaGrigio;
            annullaButton.Visible = true;
            confermaButton.Visible = true;
            radarGrigliaPictureBox.Visible = true;
        }

        #endregion

        #region Salvataggio posizione delle navi dei giocatori
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
        private void mostraNavi(string[] dettagliNavi)//posiziona le navi nelle allocazioni stabilite da entrambi i giocatori
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
        #endregion

        #region Disposizione Navi
        string nave = ""; bool messaggioGiaMostrato = false;
        bool moveUp, moveDown, moveLeft, moveRight, rotateLeft, rotateRight;

        bool portaereiImaggineGirata, corazzataImaggineGirata, sottomarinoImmagineGirata1, sottomarinoImmagineGirata2, cacciatorpediniereImmagineGirata1, cacciatorpediniereImmagineGirata2;
        private void moveShipEvent(object sender, EventArgs e)//funzione ciclica che permettte di controllare i tasti che l'utente preme per spostare le navi che hanno selezionato
        {                                                    //in ogni "case" che sposta le navi con i rispettivi nomi identificativi, vengono effettuati anche dei controlli per evitare di posizionare
                                                             //una nave al di fuori della griglia, medesiam situazione anche per ruotarle
            if(Program.modalità == false)
            {
                movimentoNavi6x6();
            }
            else
            {
                movimentoNavi10x10();
            }
            
            //quando tutte le navi di un giocatore sono pisizionate e non è ancora stato mostrato il messaggio
            if (portaereiPosizionata && corazzataPosizionata && sottomarinoPosizionato1 && sottomarinoPosizionato2 && cacciatorpedinierePosizionato1 && cacciatorpedinierePosizionato2 && naveDassaltoPosizionata1 && naveDassaltoPosizionata2 && naveDassaltoPosizionata3 && messaggioGiaMostrato == false)
            {
                passaTurnoButton.Visible = true;
                confermaButton.Visible = false;
                naviPosizionate = 0;
                messaggioGiaMostrato = true;
                MessageBox.Show("Hai dispiegato in campo tutte le navi\nClicca il pulsante 'Passa il turno'");
            }

            //controlla se la partità è finita
            switch (Program.modalità)
            {
                case true:
                    if (naviColpiteGiocatore1 == 22 || naviColpiteGiocatore2 == 22)
                    {
                        movimentoDisposizioneNavi.Enabled = false;
                        finePartita();
                    }
                    break;
                case false:
                    if (naviColpiteGiocatore1 == 10 || naviColpiteGiocatore2 == 10)
                    {
                        movimentoDisposizioneNavi.Enabled = false;
                        finePartita();
                    }
                    break;
            }
        }

        private void finePartita()
        {
            if (player1PictureBox.Visible)
            {
                Program.nomeVincitore = Program.nomeGiocatore1;
                conclusionePartita();
            }
            else
            {
                Program.nomeVincitore = Program.nomeGiocatore2;
                conclusionePartita();
            }
        }

        private void conclusionePartita()
        {
            SchermataFinale f6 = new SchermataFinale();
            f6.Show();
            this.Hide();
            while (!Program.partitaConclusa)
            {
                Application.DoEvents();
            }
            Schermata_Iniziale f1 = new Schermata_Iniziale();
            f1.Show();
            this.Close();
        }

        private void movimentoNavi6x6()//partita veloce
        {
            switch (nave)
            {
                case "sottomarino":
                    switch (sottomarini)
                    {
                        case 1:
                            if (moveUp && sottomarino1Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                sottomarino1Griglia10x10.Top -= 105;
                            }
                            if (moveDown && sottomarino1Griglia10x10.Top < 565 && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata1)
                                {
                                    sottomarino1Griglia10x10.Top += 105;
                                }
                                else if (sottomarinoImmagineGirata1 && sottomarino1Griglia10x10.Top < 355)
                                {
                                    sottomarino1Griglia10x10.Top += 105;
                                }
                            }
                            if (moveRight && sottomarino1Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                sottomarino1Griglia10x10.Left += 105;
                            }
                            if (moveLeft && sottomarino1Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                sottomarino1Griglia10x10.Left -= 105;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata1)
                                {
                                    sottomarino1Griglia10x10.Width = 105; sottomarino1Griglia10x10.Height = 315;
                                    sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia6x6Verticale;
                                    sottomarinoImmagineGirata1 = true;
                                    if (sottomarino1Griglia10x10.Location.Y > 355)
                                    {
                                        sottomarino1Griglia10x10.Location = new Point(sottomarino1Griglia10x10.Location.X, 355);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (sottomarinoImmagineGirata1)
                                {
                                    sottomarino1Griglia10x10.Width = 315; sottomarino1Griglia10x10.Height = 105;
                                    sottomarino1Griglia10x10.Image = Properties.Resources.sottomarino_Griglia6x6;
                                    sottomarinoImmagineGirata1 = false;
                                    if (sottomarino1Griglia10x10.Location.X > 360)
                                    {
                                        sottomarino1Griglia10x10.Location = new Point(360, sottomarino1Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;

                        case 0:
                            if (moveUp && sottomarino2Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                sottomarino2Griglia10x10.Top -= 105;
                            }
                            if (moveDown && sottomarino2Griglia10x10.Top < 565 && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata2)
                                {
                                    sottomarino2Griglia10x10.Top += 105;
                                }
                                else if (sottomarinoImmagineGirata2 && sottomarino2Griglia10x10.Top < 355)
                                {
                                    sottomarino2Griglia10x10.Top += 105;
                                }
                            }
                            if (moveRight && sottomarino2Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                sottomarino2Griglia10x10.Left += 105;
                            }
                            if (moveLeft && sottomarino2Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                sottomarino2Griglia10x10.Left -= 105;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!sottomarinoImmagineGirata2)
                                {
                                    sottomarino2Griglia10x10.Width = 105; sottomarino2Griglia10x10.Height = 315;
                                    sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia6x6Verticale;
                                    sottomarinoImmagineGirata2 = true;
                                    if (sottomarino2Griglia10x10.Location.Y > 355)
                                    {
                                        sottomarino2Griglia10x10.Location = new Point(sottomarino2Griglia10x10.Location.X, 355);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (sottomarinoImmagineGirata2)
                                {
                                    sottomarino2Griglia10x10.Width = 315; sottomarino2Griglia10x10.Height = 105;
                                    sottomarino2Griglia10x10.Image = Properties.Resources.sottomarino_Griglia6x6;
                                    sottomarinoImmagineGirata2 = false;
                                    if (sottomarino2Griglia10x10.Location.X > 360)
                                    {
                                        sottomarino2Griglia10x10.Location = new Point(360, sottomarino2Griglia10x10.Location.Y);
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
                                cacciatorpediniere1Griglia10x10.Top -= 105;
                            }
                            if (moveDown && cacciatorpediniere1Griglia10x10.Top < 565 && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata1)
                                {
                                    cacciatorpediniere1Griglia10x10.Top += 105;
                                }
                                else if (cacciatorpediniereImmagineGirata1 && cacciatorpediniere1Griglia10x10.Top < 460)
                                {
                                    cacciatorpediniere1Griglia10x10.Top += 105;
                                }
                            }
                            if (moveRight && cacciatorpediniere1Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                cacciatorpediniere1Griglia10x10.Left += 105;
                            }
                            if (moveLeft && cacciatorpediniere1Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                cacciatorpediniere1Griglia10x10.Left -= 105;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata1)
                                {
                                    cacciatorpediniere1Griglia10x10.Width = 105; cacciatorpediniere1Griglia10x10.Height = 210;
                                    cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia6x6Verticale;
                                    cacciatorpediniereImmagineGirata1 = true;
                                    if (cacciatorpediniere1Griglia10x10.Location.Y > 460)
                                    {
                                        cacciatorpediniere1Griglia10x10.Location = new Point(cacciatorpediniere1Griglia10x10.Location.X, 460);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (cacciatorpediniereImmagineGirata1)
                                {
                                    cacciatorpediniere1Griglia10x10.Width = 210; cacciatorpediniere1Griglia10x10.Height = 105;
                                    cacciatorpediniere1Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia6x6;
                                    cacciatorpediniereImmagineGirata1 = false;
                                    if (cacciatorpediniere1Griglia10x10.Location.X > 465)
                                    {
                                        cacciatorpediniere1Griglia10x10.Location = new Point(465, cacciatorpediniere1Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;

                        case 0:
                            if (moveUp && cacciatorpediniere2Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                cacciatorpediniere2Griglia10x10.Top -= 105;
                            }
                            if (moveDown && cacciatorpediniere2Griglia10x10.Top < 565 && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata2)
                                {
                                    cacciatorpediniere2Griglia10x10.Top += 105;
                                }
                                else if (cacciatorpediniereImmagineGirata2 && cacciatorpediniere2Griglia10x10.Top < 460)
                                {
                                    cacciatorpediniere2Griglia10x10.Top += 105;
                                }
                            }
                            if (moveRight && cacciatorpediniere2Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                cacciatorpediniere2Griglia10x10.Left += 105;
                            }
                            if (moveLeft && cacciatorpediniere2Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                cacciatorpediniere2Griglia10x10.Left -= 105;
                            }
                            if (rotateLeft && !confirmButtonPressed)
                            {
                                if (!cacciatorpediniereImmagineGirata2)
                                {
                                    cacciatorpediniere2Griglia10x10.Width = 105; cacciatorpediniere2Griglia10x10.Height = 210;
                                    cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia6x6Verticale;
                                    cacciatorpediniereImmagineGirata2 = true;
                                    if (cacciatorpediniere2Griglia10x10.Location.Y > 460)
                                    {
                                        cacciatorpediniere2Griglia10x10.Location = new Point(cacciatorpediniere2Griglia10x10.Location.X, 460);
                                    }
                                }
                            }
                            if (rotateRight && !confirmButtonPressed)
                            {
                                if (cacciatorpediniereImmagineGirata2)
                                {
                                    cacciatorpediniere2Griglia10x10.Width = 210; cacciatorpediniere2Griglia10x10.Height = 105;
                                    cacciatorpediniere2Griglia10x10.Image = Properties.Resources.cacciatorpediniere_Griglia6x6;
                                    cacciatorpediniereImmagineGirata2 = false;
                                    if (cacciatorpediniere2Griglia10x10.Location.X > 465)
                                    {
                                        cacciatorpediniere2Griglia10x10.Location = new Point(465, cacciatorpediniere2Griglia10x10.Location.Y);
                                    }
                                }
                            }
                            break;

                    }
                    if (confirmButtonPressed)
                    {
                        if (cacciatorpedinieri == 1)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(cacciatorpediniere1Griglia10x10.Location.Y, cacciatorpediniere1Griglia10x10.Location.X);
                            posizioneNaveNellArray(2);
                        }
                        else if (cacciatorpedinieri == 0)
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
                                naveDassalto1Griglia10x10.Top -= 105;
                            }
                            if (moveDown && naveDassalto1Griglia10x10.Top < 565 && !confirmButtonPressed)
                            {
                                naveDassalto1Griglia10x10.Top += 105;
                            }
                            if (moveRight && naveDassalto1Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                naveDassalto1Griglia10x10.Left += 105;
                            }
                            if (moveLeft && naveDassalto1Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                naveDassalto1Griglia10x10.Left -= 105;
                            }
                            break;

                        case 1:
                            if (moveUp && naveDassalto2Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Top -= 105;
                            }
                            if (moveDown && naveDassalto2Griglia10x10.Top < 565 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Top += 105;
                            }
                            if (moveRight && naveDassalto2Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Left += 105;
                            }
                            if (moveLeft && naveDassalto2Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                naveDassalto2Griglia10x10.Left -= 105;
                            }
                            break;

                        case 0:
                            if (moveUp && naveDassalto3Griglia10x10.Top > 40 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Top -= 105;
                            }
                            if (moveDown && naveDassalto3Griglia10x10.Top < 565 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Top += 105;
                            }
                            if (moveRight && naveDassalto3Griglia10x10.Right < 675 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Left += 105;
                            }
                            if (moveLeft && naveDassalto3Griglia10x10.Left > 45 && !confirmButtonPressed)
                            {
                                naveDassalto3Griglia10x10.Left -= 105;
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
        }

        private void movimentoNavi10x10()
        {
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
                        if (cacciatorpedinieri == 1)
                        {
                            assegnazioneLocazioneNellaGrigliaNavi_YX_10x10(cacciatorpediniere1Griglia10x10.Location.Y, cacciatorpediniere1Griglia10x10.Location.X);
                            posizioneNaveNellArray(2);
                        }
                        else if (cacciatorpedinieri == 0)
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
            //funzioni che si occupano dell'attacco delle navi nemiche 10x10
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
                        selezioneAttacco1.SendToBack();
                        attaccoAlleNavi(confermaAttacco, selezioneAttacco1);
                    }
                    else
                    {
                        confirmButtonPressed = false;
                        MessageBox.Show("Non puoi riattaccare in una posizione già attaccata");
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
                        selezioneAttacco2.SendToBack();
                        attaccoAlleNavi(confermaAttacco, selezioneAttacco2);
                        attacco2 = false;
                    }
                    else
                    {
                        confirmButtonPressed = false;
                        MessageBox.Show("Non puoi riattaccare in una posizione già attaccata");
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

            if (radarAttivo)
            {
                if (moveUp && selezioneAttacco2.Top > 85 && !confirmButtonPressed)
                {
                    radarGrigliaPictureBox.Top -= 45;
                }
                if (moveDown && selezioneAttacco2.Top < 445 && !confirmButtonPressed)
                {
                    radarGrigliaPictureBox.Top += 45;
                }
                if (moveRight && selezioneAttacco2.Right < 1168 && !confirmButtonPressed)
                {
                    radarGrigliaPictureBox.Left += 45;
                }
                if (moveLeft && selezioneAttacco2.Left > 763 && !confirmButtonPressed)
                {
                    radarGrigliaPictureBox.Left -= 45;
                }
                if (confirmButtonPressed)
                {
                    if (player1PictureBox.Visible)
                    {
                        radarUsato1 = true;
                    }
                    else
                    {
                        radarUsato2 = true;
                    }
                    radarGrigliaPictureBox.Visible = false;
                    radarAttivo = false;
                    annullaButton.Visible = false;
                    confermaButton.Visible = false;
                    countdownRadar.Text = "0";
                    radarPictureBox.Image = Properties.Resources.RadarScalaGrigio;
                    int coordinateRadarSuGrigliaArray = identificazionePosizioneRadar(radarGrigliaPictureBox);
                    individuaNaviNemiche(ref coordinateRadarSuGrigliaArray, radarGrigliaPictureBox);
                }
                if (exitOperation)
                {
                    radarGrigliaPictureBox.Visible = false;
                    radarAttivo = false;
                    exitOperation = false;
                    annullaButton.Visible = false;
                    confermaButton.Visible = false;
                    countdownRadar.Text = "1";
                    radarPictureBox.Image = Properties.Resources.Radar;
                }
            }
        }

        private int identificazionePosizioneRadar(PictureBox RadarPic)//assegna un valore numerico secondo la posizione del radar nella griglia
        {
            int PosXYRadar = 0;
            if (Program.modalità)
            {
                radarAllocazione10x10(ref RadarPic, ref PosXYRadar);
            }
            else
            {
                radarAllocazione6x6(ref RadarPic, ref PosXYRadar);
            }

            return PosXYRadar;
        }

        private int radarAllocazione10x10(ref PictureBox RadarPic, ref int PosXYRadar)
        {
            switch (RadarPic.Location.Y)
            {
                case 41:
                    PosXYRadar = -1; break; //casella A
                case 86:
                    PosXYRadar = 9; break; //casella B
                case 131:
                    PosXYRadar = 19; break; //casella C
                case 176:
                    PosXYRadar = 29; break; //casella D
                case 221:
                    PosXYRadar = 39; break; //casella E
                case 266:
                    PosXYRadar = 49; break; //casella F
                case 311:
                    PosXYRadar = 59; break; //casella G
                case 356:
                    PosXYRadar = 69; break; //casella H
                case 401:
                    PosXYRadar = 79; break; //casella I
                case 446:
                    PosXYRadar = 89; break; //casella L
            }
            switch (RadarPic.Location.X)
            {
                case 719:
                    PosXYRadar += 1; break;
                case 764:
                    PosXYRadar += 2; break;
                case 809:
                    PosXYRadar += 3; break;
                case 854:
                    PosXYRadar += 4; break;
                case 899:
                    PosXYRadar += 5; break;
                case 944:
                    PosXYRadar += 6; break;
                case 989:
                    PosXYRadar += 7; break;
                case 1034:
                    PosXYRadar += 8; break;
                case 1079:
                    PosXYRadar += 9; break;
                case 1124:
                    PosXYRadar += 10; break;
            }

            return PosXYRadar;
        }

        private int radarAllocazione6x6(ref PictureBox RadarPic, ref int PosXYRadar)
        {
            switch (RadarPic.Location.X)
            {

            }
            switch (RadarPic.Location.Y)
            {

            }

            return PosXYRadar;
        }

        private void hahahahaha(ref int coordinateNaveSuGrigliaArray, ref int[] posizioniDaControllare, int indexToRemove, bool immagineGirata)//controlla che la nave non sia posizionte al limite a destra della griglia per evitare dei falsi check di navi vicine
        {
            int[] controlloLatoDestroNave = new int[] { 1, 11, 21, 31, 41 };
            int[] controlloLatoSinistroNave = new int[] { -1, 9, 19, 29, 39 };
            int[] latoSinistroGriglia = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int[] latoDestroGriglia = new int[] { 9, 19, 29, 39, 49, 59, 69, 79, 89 };
            for (int i = 0; i < 9; i++)//per rimuovere il controllo in eccesso, in quanto si trova agli estremi della griglia
            {
                if (coordinateNaveSuGrigliaArray == latoSinistroGriglia[i] || coordinateNaveSuGrigliaArray == 0)//parte sinistra della griglia
                {
                    if (!immagineGirata)//se l'iimagine non è girata
                    {
                        posizioniDaControllare = posizioniDaControllare.RemoveFromArray(-1);//rimuove il controllo alla poppa della nave
                    }
                    else
                    {
                        for (int j = 0; j < controlloLatoSinistroNave.Length; j++)
                        {
                            posizioniDaControllare = posizioniDaControllare.RemoveFromArray(controlloLatoSinistroNave[j]);//rimuove i controlli a lato della nave
                        }
                    }
                    break;
                }
                if (coordinateNaveSuGrigliaArray == latoDestroGriglia[i] || coordinateNaveSuGrigliaArray == latoDestroGriglia[i] - (indexToRemove - 1))//parte di destra della griglia
                {
                    if (!immagineGirata)
                    {
                        posizioniDaControllare = posizioniDaControllare.RemoveFromArray(indexToRemove);
                    }
                    else if (immagineGirata && coordinateNaveSuGrigliaArray != latoDestroGriglia[i] - (indexToRemove - 1))
                    {
                        for (int j = 0; j < controlloLatoDestroNave.Length; j++)
                        {
                            posizioniDaControllare = posizioniDaControllare.RemoveFromArray(controlloLatoDestroNave[j]);
                        }
                    }
                    break;
                }
            }
        }

        private void individuaNaviNemiche(ref int coordinateRadarSuGrigliaArray, PictureBox RadarPic)
        {
            int[] posCaselleDaControllare = new int[] { -40, -31, -30, -29, -22, -21, -20, -19, -18, -13, -12, -11, -10, -9, -8, -7, -4, -3, -2, -1, 0, 1, 2, 3, 4, 7, 8, 9, 10, 11, 12, 13, 18, 19, 20, 21, 22, 29, 30, 31, 40 };

            #region Rimozione Delle caselle da controllare
            int[] eventualiPosCaselleDaTogliereDalControlloModalitaVeloce = new int[] { -40, -31, -29, -22, -18, -13, -7, -4, 4, 7, 13, 18, 22, 29, 31, 40, -30, -21, -19, -12, -8, -3, 3, 8, 12, 19, 21, 30 };
            //controlli da escludere se il radar si trova in prossimità del lato sinistro della griglia, con vari livelli di rimozione delle posizioni di controllo
            int[] eventualiPosCaselleDaTogliereDalControlloLatoSinistroV1 = new int[] { -4 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoSinistroV2 = new int[] { -4, -13, -3, 7 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoSinistroV3 = new int[] { -4, -13, -3, 7, -22, -12, -2, 8, 18 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoSinistroV4 = new int[] { -4, -13, -3, 7, -22, -12, -2, 8, 18, -31, -21, -11, -1, 9, 19, 29 };
            //controlli da escludere se il radar si trova in prossimità del lato destro della griglia, con vari livelli di rimozione delle posizioni di controllo
            int[] eventualiPosCaselleDaTogliereDalControlloLatoDestroV1 = new int[] { 4 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoDestroV2 = new int[] { 4, -7, 3, 13 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoDestroV3 = new int[] { 4, -7, 3, 13, -18, -8, 2, 12, 22 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoDestroV4 = new int[] { 4, -7, 3, 13, -18, -8, 2, 12, 22, -29, -19, -9, 1, 11, 21, 31 };
            //controlli da escludere se il radar si trova in prossimità del lato alto della griglia, con vari livelli di rimozione delle posizioni di controllo
            int[] eventualiPosCaselleDaTogliereDalControlloLatoAltoV1 = new int[] { -40 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoAltoV2 = new int[] { -40, -31, -30, -29 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoAltoV3 = new int[] { -40, -31, -30, -29, -22, -21, -20, -19, -18 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoAltoV4 = new int[] { -40, -31, -30, -29, -22, -21, -20, -19, -18, -13, -12, -11, -10, -9, -8, -7 };
            //controlli da escludere se il radar si trova in prossimità del lato basso della griglia, con vari livelli di rimozione delle posizioni di controllo
            int[] eventualiPosCaselleDaTogliereDalControlloLatoBassoV1 = new int[] { 40 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoBassoV2 = new int[] { 40, 29, 30, 31 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoBassoV3 = new int[] { 40, 29, 30, 31, 18, 19, 20, 21, 22 };
            int[] eventualiPosCaselleDaTogliereDalControlloLatoBassoV4 = new int[] { 40, 29, 30, 31, 18, 19, 20, 21, 22, 7, 8, 9, 10, 11, 12, 13 };


            //controlli da escludere se il radar si trova in prossimità del lato sinistro della griglia, con vari livelli di rimozione delle posizioni di controllo, con griglia 6x6
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoSinistroV1 = new int[] { -2 };
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoSinistroV2 = new int[] { -2, -11, -1, 9 };
            //controlli da escludere se il radar si trova in prossimità del lato destro della griglia, con vari livelli di rimozione delle posizioni di controllo, con griglia 6x6
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoDestroV1 = new int[] { 2 };
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoDestroV2 = new int[] { 2, -9, 1, 11 };
            //controlli da escludere se il radar si trova in prossimità del lato alto della griglia, con vari livelli di rimozione delle posizioni di controllo, con griglia 6x6
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoAltoV1 = new int[] { -20 };
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoAltoV2 = new int[] { -20, -11, -10, -9 };
            //controlli da escludere se il radar si trova in prossimità del lato basso della griglia, con vari livelli di rimozione delle posizioni di controllo, con griglia 6x6
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoBassoV1 = new int[] { 20 };
            int[] eventuali6x6PosCaselleDaTogliereDalControlloLatoBassoV2 = new int[] { 20, 9, 10, 11 };

            if (Program.modalità == false)
            {
                for(int i = 0; i < eventualiPosCaselleDaTogliereDalControlloModalitaVeloce.Length; i++)
                {
                    posCaselleDaControllare.RemoveFromArray(eventualiPosCaselleDaTogliereDalControlloModalitaVeloce[i]);
                }
            }

            switch (RadarPic.Location.Y)
            {
                case 41:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoAltoV4, ref posCaselleDaControllare); break; //casella A
                case 86:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoAltoV3, ref posCaselleDaControllare); break; //casella B
                case 131:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoAltoV2, ref posCaselleDaControllare); break; //casella C
                case 176:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoAltoV1, ref posCaselleDaControllare); break; //casella D
                case 221:
                    break; //casella E
                case 266:
                    break; //casella F
                case 311:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoBassoV1, ref posCaselleDaControllare); break; //casella G
                case 356:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoBassoV2, ref posCaselleDaControllare); break; //casella H
                case 401:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoBassoV3, ref posCaselleDaControllare); break; //casella I
                case 446:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoBassoV4, ref posCaselleDaControllare); break; //casella L
            }
            switch (RadarPic.Location.X)
            {
                case 719:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoSinistroV4, ref posCaselleDaControllare); break; //casella 1
                case 764:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoSinistroV3, ref posCaselleDaControllare); break; //casella 2
                case 809:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoSinistroV2, ref posCaselleDaControllare); break; //casella 3
                case 854:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoSinistroV1, ref posCaselleDaControllare); break; //casella 4
                case 899:
                    break; //casella 5
                case 944:
                    break; //casella 6
                case 989:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoDestroV1, ref posCaselleDaControllare); break; //casella 7
                case 1034:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoDestroV2, ref posCaselleDaControllare); break; //casella 8
                case 1079:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoDestroV3, ref posCaselleDaControllare); break; //casella 9
                case 1124:
                    funzioneCheRimuoveLeCaselleDaControllare(eventualiPosCaselleDaTogliereDalControlloLatoDestroV4, ref posCaselleDaControllare); break; //casella 10
            }
            #endregion

            for(int i = 0; i < posCaselleDaControllare.Length; i++)
            {
                if(Program.modalità == true)//partita normale
                {
                    string[] elementiCasella = StrutturaGriglia10[coordinateRadarSuGrigliaArray + posCaselleDaControllare[i]].Split(',');
                    if (player1PictureBox.Visible)
                    {
                        posizioneNaviIndividuatePictureBoxG1[i] = individuazioneDelleImbarcazioniNemiche(elementiCasella[1], "acqua2", posCaselleDaControllare[i] + coordinateRadarSuGrigliaArray);
                    }
                    else
                    {
                        posizioneNaviIndividuatePictureBoxG2[i] = individuazioneDelleImbarcazioniNemiche(elementiCasella[0], "acqua1", posCaselleDaControllare[i] + coordinateRadarSuGrigliaArray);
                    }
                }
                else
                {

                }
            }

            if (player1PictureBox.Visible)//rimuove gli elementi in eccesso dagli array delle navi individuate
            {
                var naviIndividuateList = posizioneNaviIndividuatePictureBoxG1.ToList();
                for (int i = 0; i < posizioneNaviIndividuatePictureBoxG1.Length; i++)
                {
                    naviIndividuateList.Remove("");
                    naviIndividuateList.Remove(null);
                }
                posizioneNaviIndividuatePictureBoxG1 = naviIndividuateList.ToArray();
                aspettoIndividuazione(naviIndividuateGiocatore1, posizioneNaviIndividuatePictureBoxG1, true);
            }
            else
            {
                var naviIndividuateList = posizioneNaviIndividuatePictureBoxG2.ToList();
                for (int i = 0; i < posizioneNaviIndividuatePictureBoxG2.Length; i++)
                {
                    naviIndividuateList.Remove("");
                }
                posizioneNaviIndividuatePictureBoxG2 = naviIndividuateList.ToArray();
                aspettoIndividuazione(naviIndividuateGiocatore2, posizioneNaviIndividuatePictureBoxG2, true);
            }
        }

        private void funzioneCheRimuoveLeCaselleDaControllare(int[] caselleDaTogliereDalControllo, ref int[] posCaselleDaControllare)//fa la scrematura dei controlli
        {
            var numbersList = posCaselleDaControllare.ToList();
            for(int i = 0; i < caselleDaTogliereDalControllo.Length; i++)
            {
                numbersList.Remove(caselleDaTogliereDalControllo[i]);
            }
            posCaselleDaControllare = numbersList.ToArray();
        }

        private string individuazioneDelleImbarcazioniNemiche(string elementiCasella, string controllo, int CasellaDaControllare)//scrive le coordinate dell'individuazione della nave nemica
        {
            string posIndividuazione = "";
            if (elementiCasella != controllo)
            {
                int posX = 0; int posY = 0;
                conversioneDaNumeroArrayACoordinateGriglia(CasellaDaControllare, ref posX, ref posY);
                posIndividuazione = $"{posX},{posY}";
                if (player1PictureBox.Visible)
                {
                    naviIndividuateGiocatore1++;
                }
                else
                {
                    naviIndividuateGiocatore2++;
                }
            }

            return posIndividuazione;
        }

        private void conversioneDaNumeroArrayACoordinateGriglia(int numeroGriglia, ref int posX, ref int posY)//assegna, dato il numero della casella, all'eventuale individuazione una coordinata X e Y sulla griglia
        {
            if(Program.modalità == true)//partita normale
            {
                if(numeroGriglia <= 9)//fila A
                {
                    numeroGriglia += 1;
                    posY = 41;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if(numeroGriglia > 9 && numeroGriglia <= 19)//fila B
                {
                    numeroGriglia -= 9;
                    posY = 86;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 19 && numeroGriglia <= 29)//fila C
                {
                    numeroGriglia -= 19;
                    posY = 131;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 29 && numeroGriglia <= 39)//fila D
                {
                    numeroGriglia -= 29;
                    posY = 176;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 39 && numeroGriglia <= 49)//fila E
                {
                    numeroGriglia -= 39;
                    posY = 221;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 49 && numeroGriglia <= 59)//fila F
                {
                    numeroGriglia -= 49;
                    posY = 266;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 59 && numeroGriglia <= 69)//fila G
                {
                    numeroGriglia -= 59;
                    posY = 311;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 69 && numeroGriglia <= 79)//fila H
                {
                    numeroGriglia -= 69;
                    posY = 356;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 79 && numeroGriglia <= 89)//fila I
                {
                    numeroGriglia -= 79;
                    posY = 401;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
                else if (numeroGriglia > 89)//fila L
                {
                    numeroGriglia -= 89;
                    posY = 446;
                    posX = assegnazioneLocazioneXControlloRadarGriglia10x10(ref numeroGriglia);
                }
            }
            else
            {

            }
        }

        private int assegnazioneLocazioneXControlloRadarGriglia10x10(ref int numeroGriglia)
        {
            int posControlloRadarX = 0;

            switch (numeroGriglia)
            {
                case 1:
                    posControlloRadarX = 719; break;
                case 2:
                    posControlloRadarX = 764; break;
                case 3:
                    posControlloRadarX = 809; break;
                case 4:
                    posControlloRadarX = 854; break;
                case 5:
                    posControlloRadarX = 899; break;
                case 6:
                    posControlloRadarX = 944; break;
                case 7:
                    posControlloRadarX = 989; break;
                case 8:
                    posControlloRadarX = 1034; break;
                case 9:
                    posControlloRadarX = 1079; break;
                case 10:
                    posControlloRadarX = 1124; break;
            }

            return posControlloRadarX;
        }

        string[] posizioneAttacchiNaviColpitePictureBoxG1 = new string[22];
        string[] posizioneAttacchiNaviMancatePictureBoxG1 = new string[88];
        string[] posizioneAttacchiNaviColpitePictureBoxG2 = new string[22];
        string[] posizioneAttacchiNaviMancatePictureBoxG2 = new string[88];
        string[] posizioneNaviIndividuatePictureBoxG1 = new string[41];
        string[] posizioneNaviIndividuatePictureBoxG2 = new string[41];

        private void attaccoAlleNavi(string[] nave, PictureBox attacco)//controlla se un giocatore colpisce o manca una nave
        {
            if (player1PictureBox.Visible)//se si manca la nave nemica si perdono 5 punti
                                          //se invece i giocatori colpiscono la nave nemica guadagnano 100 punti
            {
                if(nave[1] != "acqua2")
                {
                    posizionePictureBoxDegliAttacchiNaveColpita(naviColpiteGiocatore1, attacco.Location.X, attacco.Location.Y);
                    visibilitaPictureBoxDegliAttacchiNaveColpita(naviColpiteGiocatore1, true);
                    posizioneAttacchiNaviColpitePictureBoxG1[naviColpiteGiocatore1] = $"{attacco.Location.X},{attacco.Location.Y}";
                    naviColpiteGiocatore1++;
                    Program.scoreGiocatore1 += 100;
                }
                else
                {
                    posizionePictureBoxDegliAttacchiNaveMancata(naviMancateGiocatore1, attacco.Location.X, attacco.Location.Y);
                    visibilitaPictureBoxDegliAttacchiNaveMancata(naviMancateGiocatore1, true);
                    posizioneAttacchiNaviMancatePictureBoxG1[naviMancateGiocatore1] = $"{attacco.Location.X},{attacco.Location.Y}";
                    naviMancateGiocatore1++;
                    Program.scoreGiocatore1 -= 5;
                }
                puntiCount.Text = Program.scoreGiocatore1.ToString();
            }
            else
            {
                if (nave[0] != "acqua1")
                {
                    posizionePictureBoxDegliAttacchiNaveColpita(naviColpiteGiocatore2, attacco.Location.X, attacco.Location.Y);
                    visibilitaPictureBoxDegliAttacchiNaveColpita(naviColpiteGiocatore2, true);
                    posizioneAttacchiNaviColpitePictureBoxG2[naviColpiteGiocatore2] = $"{attacco.Location.X},{attacco.Location.Y}";
                    naviColpiteGiocatore2++;
                    Program.scoreGiocatore2 += 100;
                }
                else
                {
                    posizionePictureBoxDegliAttacchiNaveMancata(naviMancateGiocatore2, attacco.Location.X, attacco.Location.Y);
                    visibilitaPictureBoxDegliAttacchiNaveMancata(naviMancateGiocatore2, true);
                    posizioneAttacchiNaviMancatePictureBoxG2[naviMancateGiocatore2] = $"{attacco.Location.X},{attacco.Location.Y}";
                    naviMancateGiocatore2++;
                    Program.scoreGiocatore2 -= 5;
                }
                puntiCount.Text = Program.scoreGiocatore2.ToString();
            }
        }

        private void visibilitaPictureBoxDegliAttacchiNaveColpita(int numeroNaveColpita, bool visibilita)//mostra o nasconde le naviColpite
        {
            switch (numeroNaveColpita)
            {
                case 0:
                    naveColpita_1.Visible = visibilita;
                    break;
                case 1:
                    naveColpita_2.Visible = visibilita;
                    break;
                case 2:
                    naveColpita_3.Visible = visibilita;
                    break;
                case 3:
                    naveColpita_4.Visible = visibilita;
                    break;
                case 4:
                    naveColpita_5.Visible = visibilita;
                    break;
                case 5:
                    naveColpita_6.Visible = visibilita;
                    break;
                case 6:
                    naveColpita_7.Visible = visibilita;
                    break;
                case 7:
                    naveColpita_8.Visible = visibilita;
                    break;
                case 8:
                    naveColpita_9.Visible = visibilita;
                    break;
                case 9:
                    naveColpita_10.Visible = visibilita;
                    break;
                case 10:
                    naveColpita_11.Visible = visibilita;
                    break;
                case 11:
                    naveColpita_12.Visible = visibilita;
                    break;
                case 12:
                    naveColpita_13.Visible = visibilita;
                    break;
                case 13:
                    naveColpita_14.Visible = visibilita;
                    break;
                case 14:
                    naveColpita_15.Visible = visibilita;
                    break;
                case 15:
                    naveColpita_16.Visible = visibilita;
                    break;
                case 16:
                    naveColpita_17.Visible = visibilita;
                    break;
                case 17:
                    naveColpita_18.Visible = visibilita;
                    break;
                case 18:
                    naveColpita_19.Visible = visibilita;
                    break;
                case 19:
                    naveColpita_20.Visible = visibilita;
                    break;
                case 20:
                    naveColpita_21.Visible = visibilita;
                    break;
                case 21:
                    naveColpita_22.Visible = visibilita;
                    break;
            }
        }

        private void visibilitaPictureBoxDegliAttacchiNaveMancata(int numeroNaveMancata, bool visibilita)//mostra o nasconde le naviColpite
        {
            switch (numeroNaveMancata)
            {
                case 0:
                    naveMancata_1.Visible = visibilita;
                    break;
                case 1:
                    naveMancata_2.Visible = visibilita;
                    break;
                case 2:
                    naveMancata_3.Visible = visibilita;
                    break;
                case 3:
                    naveMancata_4.Visible = visibilita;
                    break;
                case 4:
                    naveMancata_5.Visible = visibilita;
                    break;
                case 5:
                    naveMancata_6.Visible = visibilita;
                    break;
                case 6:
                    naveMancata_7.Visible = visibilita;
                    break;
                case 7:
                    naveMancata_8.Visible = visibilita;
                    break;
                case 8:
                    naveMancata_9.Visible = visibilita;
                    break;
                case 9:
                    naveMancata_10.Visible = visibilita;
                    break;
                case 10:
                    naveMancata_11.Visible = visibilita;
                    break;
                case 11:
                    naveMancata_12.Visible = visibilita;
                    break;
                case 12:
                    naveMancata_13.Visible = visibilita;
                    break;
                case 13:
                    naveMancata_14.Visible = visibilita;
                    break;
                case 14:
                    naveMancata_15.Visible = visibilita;
                    break;
                case 15:
                    naveMancata_16.Visible = visibilita;
                    break;
                case 16:
                    naveMancata_17.Visible = visibilita;
                    break;
                case 17:
                    naveMancata_18.Visible = visibilita;
                    break;
                case 18:
                    naveMancata_19.Visible = visibilita;
                    break;
                case 19:
                    naveMancata_20.Visible = visibilita;
                    break;
                case 20:
                    naveMancata_21.Visible = visibilita;
                    break;
                case 21:
                    naveMancata_22.Visible = visibilita;
                    break;
                case 22:
                    naveMancata_23.Visible = visibilita;
                    break;
                case 23:
                    naveMancata_24.Visible = visibilita;
                    break;
                case 24:
                    naveMancata_25.Visible = visibilita;
                    break;
                case 25:
                    naveMancata_26.Visible = visibilita;
                    break;
                case 26:
                    naveMancata_27.Visible = visibilita;
                    break;
                case 27:
                    naveMancata_28.Visible = visibilita;
                    break;
                case 28:
                    naveMancata_29.Visible = visibilita;
                    break;
                case 29:
                    naveMancata_30.Visible = visibilita;
                    break;
                case 30:
                    naveMancata_31.Visible = visibilita;
                    break;
                case 31:
                    naveMancata_32.Visible = visibilita;
                    break;
                case 32:
                    naveMancata_33.Visible = visibilita;
                    break;
                case 33:
                    naveMancata_34.Visible = visibilita;
                    break;
                case 34:
                    naveMancata_35.Visible = visibilita;
                    break;
                case 35:
                    naveMancata_36.Visible = visibilita;
                    break;
                case 36:
                    naveMancata_37.Visible = visibilita;
                    break;
                case 37:
                    naveMancata_38.Visible = visibilita;
                    break;
                case 38:
                    naveMancata_39.Visible = visibilita;
                    break;
                case 39:
                    naveMancata_40.Visible = visibilita;
                    break;
                case 40:
                    naveMancata_41.Visible = visibilita;
                    break;
                case 41:
                    naveMancata_42.Visible = visibilita;
                    break;
                case 42:
                    naveMancata_43.Visible = visibilita;
                    break;
                case 43:
                    naveMancata_44.Visible = visibilita;
                    break;
                case 44:
                    naveMancata_45.Visible = visibilita;
                    break;
                case 45:
                    naveMancata_46.Visible = visibilita;
                    break;
                case 46:
                    naveMancata_47.Visible = visibilita;
                    break;
                case 47:
                    naveMancata_48.Visible = visibilita;
                    break;
                case 48:
                    naveMancata_49.Visible = visibilita;
                    break;
                case 49:
                    naveMancata_50.Visible = visibilita;
                    break;
                case 50:
                    naveMancata_51.Visible = visibilita;
                    break;
                case 51:
                    naveMancata_52.Visible = visibilita;
                    break;
                case 52:
                    naveMancata_53.Visible = visibilita;
                    break;
                case 53:
                    naveMancata_54.Visible = visibilita;
                    break;
                case 54:
                    naveMancata_55.Visible = visibilita;
                    break;
                case 55:
                    naveMancata_56.Visible = visibilita;
                    break;
                case 56:
                    naveMancata_57.Visible = visibilita;
                    break;
                case 57:
                    naveMancata_58.Visible = visibilita;
                    break;
                case 58:
                    naveMancata_59.Visible = visibilita;
                    break;
                case 59:
                    naveMancata_60.Visible = visibilita;
                    break;
                case 60:
                    naveMancata_61.Visible = visibilita;
                    break;
                case 61:
                    naveMancata_62.Visible = visibilita;
                    break;
                case 62:
                    naveMancata_63.Visible = visibilita;
                    break;
                case 63:
                    naveMancata_64.Visible = visibilita;
                    break;
                case 64:
                    naveMancata_65.Visible = visibilita;
                    break;
                case 65:
                    naveMancata_66.Visible = visibilita;
                    break;
                case 66:
                    naveMancata_67.Visible = visibilita;
                    break;
                case 67:
                    naveMancata_68.Visible = visibilita;
                    break;
                case 68:
                    naveMancata_69.Visible = visibilita;
                    break;
                case 69:
                    naveMancata_70.Visible = visibilita;
                    break;
                case 70:
                    naveMancata_71.Visible = visibilita;
                    break;
                case 71:
                    naveMancata_72.Visible = visibilita;
                    break;
                case 72:
                    naveMancata_73.Visible = visibilita;
                    break;
                case 73:
                    naveMancata_74.Visible = visibilita;
                    break;
                case 74:
                    naveMancata_75.Visible = visibilita;
                    break;
                case 75:
                    naveMancata_76.Visible = visibilita;
                    break;
                case 76:
                    naveMancata_77.Visible = visibilita;
                    break;
                case 77:
                    naveMancata_78.Visible = visibilita;
                    break;
                case 78:
                    naveMancata_79.Visible = visibilita;
                    break;
                case 79:
                    naveMancata_80.Visible = visibilita;
                    break;
                case 80:
                    naveMancata_81.Visible = visibilita;
                    break;
                case 81:
                    naveMancata_82.Visible = visibilita;
                    break;
                case 82:
                    naveMancata_83.Visible = visibilita;
                    break;
                case 83:
                    naveMancata_84.Visible = visibilita;
                    break;
                case 84:
                    naveMancata_85.Visible = visibilita;
                    break;
                case 85:
                    naveMancata_86.Visible = visibilita;
                    break;
                case 86:
                    naveMancata_87.Visible = visibilita;
                    break;
                case 87:
                    naveMancata_88.Visible = visibilita;
                    break;
            }
        }

        private void visibilitaPictureBoxDelleNaviIndividuate(int numeroNaveTrovata, bool visibilita)//mostra o nasconde le naviColpite
        {
            switch (numeroNaveTrovata)
            {
                case 0:
                    naveIndividuata_1.Visible = visibilita;
                    break;
                case 1:
                    naveIndividuata_2.Visible = visibilita;
                    break;
                case 2:
                    naveIndividuata_3.Visible = visibilita;
                    break;
                case 3:
                    naveIndividuata_4.Visible = visibilita;
                    break;
                case 4:
                    naveIndividuata_5.Visible = visibilita;
                    break;
                case 5:
                    naveIndividuata_6.Visible = visibilita;
                    break;
                case 6:
                    naveIndividuata_7.Visible = visibilita;
                    break;
                case 7:
                    naveIndividuata_8.Visible = visibilita;
                    break;
                case 8:
                    naveIndividuata_9.Visible = visibilita;
                    break;
                case 9:
                    naveIndividuata_10.Visible = visibilita;
                    break;
                case 10:
                    naveIndividuata_11.Visible = visibilita;
                    break;
                case 11:
                    naveIndividuata_12.Visible = visibilita;
                    break;
                case 12:
                    naveIndividuata_13.Visible = visibilita;
                    break;
                case 13:
                    naveIndividuata_14.Visible = visibilita;
                    break;
                case 14:
                    naveIndividuata_15.Visible = visibilita;
                    break;
                case 15:
                    naveIndividuata_16.Visible = visibilita;
                    break;
                case 16:
                    naveIndividuata_17.Visible = visibilita;
                    break;
                case 17:
                    naveIndividuata_18.Visible = visibilita;
                    break;
                case 18:
                    naveIndividuata_19.Visible = visibilita;
                    break;
                case 19:
                    naveIndividuata_20.Visible = visibilita;
                    break;
                case 20:
                    naveIndividuata_21.Visible = visibilita;
                    break;
                case 21:
                    naveIndividuata_22.Visible = visibilita;
                    break;
            }
        }

        private void posizionePictureBoxDegliAttacchiNaveColpita(int numeroNaveColpita, int x, int y)//imposta la posizione delle picturebox delle navi colpite
        {
            switch (numeroNaveColpita)
            {
                case 0:
                    naveColpita_1.Location = new Point(x, y);
                    break;
                case 1:
                    naveColpita_2.Location = new Point(x, y);
                    break;
                case 2:
                    naveColpita_3.Location = new Point(x, y);
                    break;
                case 3:
                    naveColpita_4.Location = new Point(x, y);
                    break;
                case 4:
                    naveColpita_5.Location = new Point(x, y);
                    break;
                case 5:
                    naveColpita_6.Location = new Point(x, y);
                    break;
                case 6:
                    naveColpita_7.Location = new Point(x, y);
                    break;
                case 7:
                    naveColpita_8.Location = new Point(x, y);
                    break;
                case 8:
                    naveColpita_9.Location = new Point(x, y);
                    break;
                case 9:
                    naveColpita_10.Location = new Point(x, y);
                    break;
                case 10:
                    naveColpita_11.Location = new Point(x, y);
                    break;
                case 11:
                    naveColpita_12.Location = new Point(x, y);
                    break;
                case 12:
                    naveColpita_13.Location = new Point(x, y);
                    break;
                case 13:
                    naveColpita_14.Location = new Point(x, y);
                    break;
                case 14:
                    naveColpita_15.Location = new Point(x, y);
                    break;
                case 15:
                    naveColpita_16.Location = new Point(x, y);
                    break;
                case 16:
                    naveColpita_17.Location = new Point(x, y);
                    break;
                case 17:
                    naveColpita_18.Location = new Point(x, y);
                    break;
                case 18:
                    naveColpita_19.Location = new Point(x, y);
                    break;
                case 19:
                    naveColpita_20.Location = new Point(x, y);
                    break;
                case 20:
                    naveColpita_21.Location = new Point(x, y);
                    break;
                case 21:
                    naveColpita_22.Location = new Point(x, y);
                    break;
            }
        }

        private void posizionePictureBoxDegliAttacchiNaveMancata(int numeroNaveMancata, int x, int y)//imposta la posizione delle picturebox delle navi mancate
        {
            switch (numeroNaveMancata)
            {
                case 0:
                    naveMancata_1.Location = new Point(x, y);
                    break;
                case 1:
                    naveMancata_2.Location = new Point(x, y);
                    break;
                case 2:
                    naveMancata_3.Location = new Point(x, y);
                    break;
                case 3:
                    naveMancata_4.Location = new Point(x, y);
                    break;
                case 4:
                    naveMancata_5.Location = new Point(x, y);
                    break;
                case 5:
                    naveMancata_6.Location = new Point(x, y);
                    break;
                case 6:
                    naveMancata_7.Location = new Point(x, y);
                    break;
                case 7:
                    naveMancata_8.Location = new Point(x, y);
                    break;
                case 8:
                    naveMancata_9.Location = new Point(x, y);
                    break;
                case 9:
                    naveMancata_10.Location = new Point(x, y);
                    break;
                case 10:
                    naveMancata_11.Location = new Point(x, y);
                    break;
                case 11:
                    naveMancata_12.Location = new Point(x, y);
                    break;
                case 12:
                    naveMancata_13.Location = new Point(x, y);
                    break;
                case 13:
                    naveMancata_14.Location = new Point(x, y);
                    break;
                case 14:
                    naveMancata_15.Location = new Point(x, y);
                    break;
                case 15:
                    naveMancata_16.Location = new Point(x, y);
                    break;
                case 16:
                    naveMancata_17.Location = new Point(x, y);
                    break;
                case 17:
                    naveMancata_18.Location = new Point(x, y);
                    break;
                case 18:
                    naveMancata_19.Location = new Point(x, y);
                    break;
                case 19:
                    naveMancata_20.Location = new Point(x, y);
                    break;
                case 20:
                    naveMancata_21.Location = new Point(x, y);
                    break;
                case 21:
                    naveMancata_22.Location = new Point(x, y);
                    break;
                case 22:
                    naveMancata_23.Location = new Point(x, y);
                    break;
                case 23:
                    naveMancata_24.Location = new Point(x, y);
                    break;
                case 24:
                    naveMancata_25.Location = new Point(x, y);
                    break;
                case 25:
                    naveMancata_26.Location = new Point(x, y);
                    break;
                case 26:
                    naveMancata_27.Location = new Point(x, y);
                    break;
                case 27:
                    naveMancata_28.Location = new Point(x, y);
                    break;
                case 28:
                    naveMancata_29.Location = new Point(x, y);
                    break;
                case 29:
                    naveMancata_30.Location = new Point(x, y);
                    break;
                case 30:
                    naveMancata_31.Location = new Point(x, y);
                    break;
                case 31:
                    naveMancata_32.Location = new Point(x, y);
                    break;
                case 32:
                    naveMancata_33.Location = new Point(x, y);
                    break;
                case 33:
                    naveMancata_34.Location = new Point(x, y);
                    break;
                case 34:
                    naveMancata_35.Location = new Point(x, y);
                    break;
                case 35:
                    naveMancata_36.Location = new Point(x, y);
                    break;
                case 36:
                    naveMancata_37.Location = new Point(x, y);
                    break;
                case 37:
                    naveMancata_38.Location = new Point(x, y);
                    break;
                case 38:
                    naveMancata_39.Location = new Point(x, y);
                    break;
                case 39:
                    naveMancata_40.Location = new Point(x, y);
                    break;
                case 40:
                    naveMancata_41.Location = new Point(x, y);
                    break;
                case 41:
                    naveMancata_42.Location = new Point(x, y);
                    break;
                case 42:
                    naveMancata_43.Location = new Point(x, y);
                    break;
                case 43:
                    naveMancata_44.Location = new Point(x, y);
                    break;
                case 44:
                    naveMancata_45.Location = new Point(x, y);
                    break;
                case 45:
                    naveMancata_46.Location = new Point(x, y);
                    break;
                case 46:
                    naveMancata_47.Location = new Point(x, y);
                    break;
                case 47:
                    naveMancata_48.Location = new Point(x, y);
                    break;
                case 48:
                    naveMancata_49.Location = new Point(x, y);
                    break;
                case 49:
                    naveMancata_50.Location = new Point(x, y);
                    break;
                case 50:
                    naveMancata_51.Location = new Point(x, y);
                    break;
                case 51:
                    naveMancata_52.Location = new Point(x, y);
                    break;
                case 52:
                    naveMancata_53.Location = new Point(x, y);
                    break;
                case 53:
                    naveMancata_54.Location = new Point(x, y);
                    break;
                case 54:
                    naveMancata_55.Location = new Point(x, y);
                    break;
                case 55:
                    naveMancata_56.Location = new Point(x, y);
                    break;
                case 56:
                    naveMancata_57.Location = new Point(x, y);
                    break;
                case 57:
                    naveMancata_58.Location = new Point(x, y);
                    break;
                case 58:
                    naveMancata_59.Location = new Point(x, y);
                    break;
                case 59:
                    naveMancata_60.Location = new Point(x, y);
                    break;
                case 60:
                    naveMancata_61.Location = new Point(x, y);
                    break;
                case 61:
                    naveMancata_62.Location = new Point(x, y);
                    break;
                case 62:
                    naveMancata_63.Location = new Point(x, y);
                    break;
                case 63:
                    naveMancata_64.Location = new Point(x, y);
                    break;
                case 64:
                    naveMancata_65.Location = new Point(x, y);
                    break;
                case 65:
                    naveMancata_66.Location = new Point(x, y);
                    break;
                case 66:
                    naveMancata_67.Location = new Point(x, y);
                    break;
                case 67:
                    naveMancata_68.Location = new Point(x, y);
                    break;
                case 68:
                    naveMancata_69.Location = new Point(x, y);
                    break;
                case 69:
                    naveMancata_70.Location = new Point(x, y);
                    break;
                case 70:
                    naveMancata_71.Location = new Point(x, y);
                    break;
                case 71:
                    naveMancata_72.Location = new Point(x, y);
                    break;
                case 72:
                    naveMancata_73.Location = new Point(x, y);
                    break;
                case 73:
                    naveMancata_74.Location = new Point(x, y);
                    break;
                case 74:
                    naveMancata_75.Location = new Point(x, y);
                    break;
                case 75:
                    naveMancata_76.Location = new Point(x, y);
                    break;
                case 76:
                    naveMancata_77.Location = new Point(x, y);
                    break;
                case 77:
                    naveMancata_78.Location = new Point(x, y);
                    break;
                case 78:
                    naveMancata_79.Location = new Point(x, y);
                    break;
                case 79:
                    naveMancata_80.Location = new Point(x, y);
                    break;
                case 80:
                    naveMancata_81.Location = new Point(x, y);
                    break;
                case 81:
                    naveMancata_82.Location = new Point(x, y);
                    break;
                case 82:
                    naveMancata_83.Location = new Point(x, y);
                    break;
                case 83:
                    naveMancata_84.Location = new Point(x, y);
                    break;
                case 84:
                    naveMancata_85.Location = new Point(x, y);
                    break;
                case 85:
                    naveMancata_86.Location = new Point(x, y);
                    break;
                case 86:
                    naveMancata_87.Location = new Point(x, y);
                    break;
                case 87:
                    naveMancata_88.Location = new Point(x, y);
                    break;
            }
        }

        private void posizionePictureBoxNaveIndividuata(int numeroNaveIndividuata, int x, int y)//imposta la posizione delle picturebox delle navi colpite
        {
            switch (numeroNaveIndividuata)
            {
                case 0:
                    naveIndividuata_1.Location = new Point(x, y);
                    break;
                case 1:
                    naveIndividuata_2.Location = new Point(x, y);
                    break;
                case 2:
                    naveIndividuata_3.Location = new Point(x, y);
                    break;
                case 3:
                    naveIndividuata_4.Location = new Point(x, y);
                    break;
                case 4:
                    naveIndividuata_5.Location = new Point(x, y);
                    break;
                case 5:
                    naveIndividuata_6.Location = new Point(x, y);
                    break;
                case 6:
                    naveIndividuata_7.Location = new Point(x, y);
                    break;
                case 7:
                    naveIndividuata_8.Location = new Point(x, y);
                    break;
                case 8:
                    naveIndividuata_9.Location = new Point(x, y);
                    break;
                case 9:
                    naveIndividuata_10.Location = new Point(x, y);
                    break;
                case 10:
                    naveIndividuata_11.Location = new Point(x, y);
                    break;
                case 11:
                    naveIndividuata_12.Location = new Point(x, y);
                    break;
                case 12:
                    naveIndividuata_13.Location = new Point(x, y);
                    break;
                case 13:
                    naveIndividuata_14.Location = new Point(x, y);
                    break;
                case 14:
                    naveIndividuata_15.Location = new Point(x, y);
                    break;
                case 15:
                    naveIndividuata_16.Location = new Point(x, y);
                    break;
                case 16:
                    naveIndividuata_17.Location = new Point(x, y);
                    break;
                case 17:
                    naveIndividuata_18.Location = new Point(x, y);
                    break;
                case 18:
                    naveIndividuata_19.Location = new Point(x, y);
                    break;
                case 19:
                    naveIndividuata_20.Location = new Point(x, y);
                    break;
                case 20:
                    naveIndividuata_21.Location = new Point(x, y);
                    break;
                case 21:
                    naveIndividuata_22.Location = new Point(x, y);
                    break;
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
                        if(Program.modalità == true)
                        {
                            sottomarino1Griglia10x10.Location = new Point(297 - 63, 292);//partita normale
                        }
                        else
                        {
                            sottomarino1Griglia10x10.Location = new Point(150, 250);//partita veloce
                        }
                        sottomarino1Griglia10x10.Visible = true;
                    }
                    else if (sottomarini == 0)
                    {
                        if (Program.modalità == true)
                        {
                            sottomarino2Griglia10x10.Location = new Point(297 - 63, 292);//partita normale
                        }
                        else
                        {
                            sottomarino2Griglia10x10.Location = new Point(150, 250);//partita veloce
                        }
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
                        if (Program.modalità == true)
                        {
                            cacciatorpediniere1Griglia10x10.Location = new Point(297, 292);//partita normale
                        }
                        else
                        {
                            cacciatorpediniere1Griglia10x10.Location = new Point(255, 250);//partita veloce
                        }
                        cacciatorpediniere1Griglia10x10.Visible = true;
                    }
                    else if (cacciatorpedinieri == 0)
                    {
                        if (Program.modalità == true)
                        {
                            cacciatorpediniere2Griglia10x10.Location = new Point(297, 292);//partita normale
                        }
                        else
                        {
                            cacciatorpediniere2Griglia10x10.Location = new Point(255, 250);//partita veloce
                        }
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
                        if (Program.modalità == true)
                        {
                            naveDassalto1Griglia10x10.Location = new Point(297, 292);//partita normale
                        }
                        else
                        {
                            naveDassalto1Griglia10x10.Location = new Point(255, 250);//partita veloce
                        }
                        naveDassalto1Griglia10x10.Visible = true;
                    }
                    else if (naviDassalto == 1)
                    {
                        if (Program.modalità == true)
                        {
                            naveDassalto2Griglia10x10.Location = new Point(297, 292);//partita normale
                        }
                        else
                        {
                            naveDassalto2Griglia10x10.Location = new Point(255, 250);//partita veloce
                        }
                        naveDassalto2Griglia10x10.Visible = true;
                    }
                    else if (naviDassalto == 0)
                    {
                        if (Program.modalità == true)
                        {
                            naveDassalto3Griglia10x10.Location = new Point(297, 292);//partita normale
                        }
                        else
                        {
                            naveDassalto3Griglia10x10.Location = new Point(255, 250);//partita veloce
                        }
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
                if(coordinateNaveSuGrigliaArray == latoDestroGriglia[i] || coordinateNaveSuGrigliaArray == latoDestroGriglia[i] - (indexToRemove - 1))//parte di destra della griglia
                {
                    if (!immagineGirata)
                    {
                        posizioniDaControllare = posizioniDaControllare.RemoveFromArray(indexToRemove);
                    }
                    else if(immagineGirata && coordinateNaveSuGrigliaArray != latoDestroGriglia[i] - (indexToRemove - 1))
                    {
                        for (int j = 0; j < controlloLatoDestroNave.Length; j++)
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
