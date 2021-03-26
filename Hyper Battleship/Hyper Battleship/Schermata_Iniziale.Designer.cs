namespace Hyper_Battleship
{
    partial class Schermata_Iniziale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schermata_Iniziale));
            this.titoloGioco2 = new System.Windows.Forms.Label();
            this.startText = new System.Windows.Forms.Label();
            this.settingsText = new System.Windows.Forms.Label();
            this.quitText = new System.Windows.Forms.Label();
            this.schermataPreLobby = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Label();
            this.fastMatchButton = new System.Windows.Forms.Label();
            this.fullMatchButton = new System.Windows.Forms.Label();
            this.titoloGioco1 = new System.Windows.Forms.Label();
            this.singlePlayerButton = new System.Windows.Forms.Label();
            this.multiplayerButton = new System.Windows.Forms.Label();
            this.quitPreLobbyButton = new System.Windows.Forms.Label();
            this.inizioPartitaButton = new System.Windows.Forms.Label();
            this.preLobbyTextSingleplayer = new System.Windows.Forms.Label();
            this.preLobbyTextMultiplayer = new System.Windows.Forms.Label();
            this.player2Picture = new System.Windows.Forms.PictureBox();
            this.player1Picture = new System.Windows.Forms.PictureBox();
            this.avvisoCredenzialiNonValide = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButtonGame = new System.Windows.Forms.Label();
            this.playerPasswordInsertBox = new System.Windows.Forms.TextBox();
            this.playerNameInsertBox = new System.Windows.Forms.TextBox();
            this.passwordPlayerText = new System.Windows.Forms.Label();
            this.namePLayerText = new System.Windows.Forms.Label();
            this.alreadyExistPlayerButton = new System.Windows.Forms.Label();
            this.newPlayerButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schermataPreLobby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // titoloGioco2
            // 
            this.titoloGioco2.AutoSize = true;
            this.titoloGioco2.BackColor = System.Drawing.Color.Transparent;
            this.titoloGioco2.Font = new System.Drawing.Font("SimSun", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titoloGioco2.ForeColor = System.Drawing.Color.Red;
            this.titoloGioco2.Location = new System.Drawing.Point(285, 103);
            this.titoloGioco2.Name = "titoloGioco2";
            this.titoloGioco2.Size = new System.Drawing.Size(487, 87);
            this.titoloGioco2.TabIndex = 1;
            this.titoloGioco2.Text = "BATTLESHIP";
            this.titoloGioco2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startText
            // 
            this.startText.AutoSize = true;
            this.startText.BackColor = System.Drawing.Color.Transparent;
            this.startText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startText.Location = new System.Drawing.Point(437, 298);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(134, 46);
            this.startText.TabIndex = 3;
            this.startText.Text = "INIZIO";
            this.startText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startText_MouseClick);
            // 
            // settingsText
            // 
            this.settingsText.AutoSize = true;
            this.settingsText.BackColor = System.Drawing.Color.Transparent;
            this.settingsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsText.Location = new System.Drawing.Point(364, 413);
            this.settingsText.Name = "settingsText";
            this.settingsText.Size = new System.Drawing.Size(303, 46);
            this.settingsText.TabIndex = 5;
            this.settingsText.Text = "IMPOSTAZIONI";
            // 
            // quitText
            // 
            this.quitText.AutoSize = true;
            this.quitText.BackColor = System.Drawing.Color.Transparent;
            this.quitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitText.Location = new System.Drawing.Point(447, 533);
            this.quitText.Name = "quitText";
            this.quitText.Size = new System.Drawing.Size(113, 46);
            this.quitText.TabIndex = 7;
            this.quitText.Text = "ESCI";
            this.quitText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.quitText_MouseClick);
            // 
            // schermataPreLobby
            // 
            this.schermataPreLobby.Image = ((System.Drawing.Image)(resources.GetObject("schermataPreLobby.Image")));
            this.schermataPreLobby.Location = new System.Drawing.Point(1265, 0);
            this.schermataPreLobby.Name = "schermataPreLobby";
            this.schermataPreLobby.Size = new System.Drawing.Size(394, 686);
            this.schermataPreLobby.TabIndex = 8;
            this.schermataPreLobby.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(890, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(176, 31);
            this.backButton.TabIndex = 9;
            this.backButton.Text = " < INDIETRO";
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // fastMatchButton
            // 
            this.fastMatchButton.AutoSize = true;
            this.fastMatchButton.BackColor = System.Drawing.Color.Black;
            this.fastMatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastMatchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fastMatchButton.Location = new System.Drawing.Point(890, 152);
            this.fastMatchButton.Name = "fastMatchButton";
            this.fastMatchButton.Size = new System.Drawing.Size(183, 31);
            this.fastMatchButton.TabIndex = 10;
            this.fastMatchButton.Text = "Partita Veloce";
            this.fastMatchButton.Visible = false;
            this.fastMatchButton.Click += new System.EventHandler(this.fastMatchButton_Click);
            // 
            // fullMatchButton
            // 
            this.fullMatchButton.AutoSize = true;
            this.fullMatchButton.BackColor = System.Drawing.Color.Black;
            this.fullMatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullMatchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullMatchButton.Location = new System.Drawing.Point(890, 298);
            this.fullMatchButton.Name = "fullMatchButton";
            this.fullMatchButton.Size = new System.Drawing.Size(202, 31);
            this.fullMatchButton.TabIndex = 11;
            this.fullMatchButton.Text = "Partita Normale";
            this.fullMatchButton.Visible = false;
            this.fullMatchButton.Click += new System.EventHandler(this.fullMatchButton_Click);
            // 
            // titoloGioco1
            // 
            this.titoloGioco1.AutoSize = true;
            this.titoloGioco1.BackColor = System.Drawing.Color.Transparent;
            this.titoloGioco1.Font = new System.Drawing.Font("SimSun", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titoloGioco1.ForeColor = System.Drawing.Color.Red;
            this.titoloGioco1.Location = new System.Drawing.Point(370, 8);
            this.titoloGioco1.Name = "titoloGioco1";
            this.titoloGioco1.Size = new System.Drawing.Size(262, 87);
            this.titoloGioco1.TabIndex = 0;
            this.titoloGioco1.Text = "HYPER";
            this.titoloGioco1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singlePlayerButton
            // 
            this.singlePlayerButton.AutoSize = true;
            this.singlePlayerButton.BackColor = System.Drawing.Color.Black;
            this.singlePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.singlePlayerButton.Location = new System.Drawing.Point(890, 152);
            this.singlePlayerButton.Name = "singlePlayerButton";
            this.singlePlayerButton.Size = new System.Drawing.Size(229, 31);
            this.singlePlayerButton.TabIndex = 12;
            this.singlePlayerButton.Text = "Giocatore Singolo";
            this.singlePlayerButton.Visible = false;
            this.singlePlayerButton.Click += new System.EventHandler(this.singlePlayerButton_Click);
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.AutoSize = true;
            this.multiplayerButton.BackColor = System.Drawing.Color.Black;
            this.multiplayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplayerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplayerButton.Location = new System.Drawing.Point(890, 298);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(183, 31);
            this.multiplayerButton.TabIndex = 13;
            this.multiplayerButton.Text = "Multigiocatore";
            this.multiplayerButton.Visible = false;
            this.multiplayerButton.Click += new System.EventHandler(this.multiplayerButton_Click);
            // 
            // quitPreLobbyButton
            // 
            this.quitPreLobbyButton.AutoSize = true;
            this.quitPreLobbyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitPreLobbyButton.Location = new System.Drawing.Point(822, 320);
            this.quitPreLobbyButton.Name = "quitPreLobbyButton";
            this.quitPreLobbyButton.Size = new System.Drawing.Size(72, 46);
            this.quitPreLobbyButton.TabIndex = 29;
            this.quitPreLobbyButton.Text = "No";
            this.quitPreLobbyButton.Visible = false;
            this.quitPreLobbyButton.Click += new System.EventHandler(this.quitPreLobbyButton_Click_1);
            // 
            // inizioPartitaButton
            // 
            this.inizioPartitaButton.AutoSize = true;
            this.inizioPartitaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inizioPartitaButton.Location = new System.Drawing.Point(388, 320);
            this.inizioPartitaButton.Name = "inizioPartitaButton";
            this.inizioPartitaButton.Size = new System.Drawing.Size(56, 46);
            this.inizioPartitaButton.TabIndex = 28;
            this.inizioPartitaButton.Text = "Si";
            this.inizioPartitaButton.Visible = false;
            this.inizioPartitaButton.Click += new System.EventHandler(this.inizioPartitaButton_Click_1);
            // 
            // preLobbyTextSingleplayer
            // 
            this.preLobbyTextSingleplayer.AutoSize = true;
            this.preLobbyTextSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preLobbyTextSingleplayer.Location = new System.Drawing.Point(446, 72);
            this.preLobbyTextSingleplayer.Name = "preLobbyTextSingleplayer";
            this.preLobbyTextSingleplayer.Size = new System.Drawing.Size(423, 46);
            this.preLobbyTextSingleplayer.TabIndex = 27;
            this.preLobbyTextSingleplayer.Text = "sei pronto per iniziare?";
            this.preLobbyTextSingleplayer.Visible = false;
            // 
            // preLobbyTextMultiplayer
            // 
            this.preLobbyTextMultiplayer.AutoSize = true;
            this.preLobbyTextMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preLobbyTextMultiplayer.Location = new System.Drawing.Point(436, 72);
            this.preLobbyTextMultiplayer.Name = "preLobbyTextMultiplayer";
            this.preLobbyTextMultiplayer.Size = new System.Drawing.Size(442, 46);
            this.preLobbyTextMultiplayer.TabIndex = 26;
            this.preLobbyTextMultiplayer.Text = "siete pronti per iniziare?";
            this.preLobbyTextMultiplayer.Visible = false;
            // 
            // player2Picture
            // 
            this.player2Picture.Image = ((System.Drawing.Image)(resources.GetObject("player2Picture.Image")));
            this.player2Picture.Location = new System.Drawing.Point(629, 146);
            this.player2Picture.Name = "player2Picture";
            this.player2Picture.Size = new System.Drawing.Size(50, 50);
            this.player2Picture.TabIndex = 25;
            this.player2Picture.TabStop = false;
            this.player2Picture.Visible = false;
            // 
            // player1Picture
            // 
            this.player1Picture.Image = ((System.Drawing.Image)(resources.GetObject("player1Picture.Image")));
            this.player1Picture.Location = new System.Drawing.Point(629, 146);
            this.player1Picture.Name = "player1Picture";
            this.player1Picture.Size = new System.Drawing.Size(50, 50);
            this.player1Picture.TabIndex = 24;
            this.player1Picture.TabStop = false;
            this.player1Picture.Visible = false;
            // 
            // avvisoCredenzialiNonValide
            // 
            this.avvisoCredenzialiNonValide.AutoSize = true;
            this.avvisoCredenzialiNonValide.BackColor = System.Drawing.Color.Transparent;
            this.avvisoCredenzialiNonValide.ForeColor = System.Drawing.Color.Red;
            this.avvisoCredenzialiNonValide.Location = new System.Drawing.Point(574, 353);
            this.avvisoCredenzialiNonValide.Name = "avvisoCredenzialiNonValide";
            this.avvisoCredenzialiNonValide.Size = new System.Drawing.Size(0, 13);
            this.avvisoCredenzialiNonValide.TabIndex = 23;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Menu;
            this.confirmButton.Location = new System.Drawing.Point(739, 373);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.Text = "Conferma";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click_1);
            // 
            // backButtonGame
            // 
            this.backButtonGame.AutoSize = true;
            this.backButtonGame.BackColor = System.Drawing.Color.Transparent;
            this.backButtonGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonGame.ForeColor = System.Drawing.SystemColors.Control;
            this.backButtonGame.Location = new System.Drawing.Point(12, 626);
            this.backButtonGame.Name = "backButtonGame";
            this.backButtonGame.Size = new System.Drawing.Size(243, 46);
            this.backButtonGame.TabIndex = 21;
            this.backButtonGame.Text = "< INDIETRO";
            this.backButtonGame.Visible = false;
            this.backButtonGame.Click += new System.EventHandler(this.backButtonGame_Click_1);
            // 
            // playerPasswordInsertBox
            // 
            this.playerPasswordInsertBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.playerPasswordInsertBox.Location = new System.Drawing.Point(574, 326);
            this.playerPasswordInsertBox.Name = "playerPasswordInsertBox";
            this.playerPasswordInsertBox.Size = new System.Drawing.Size(167, 20);
            this.playerPasswordInsertBox.TabIndex = 20;
            this.playerPasswordInsertBox.Visible = false;
            // 
            // playerNameInsertBox
            // 
            this.playerNameInsertBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.playerNameInsertBox.Location = new System.Drawing.Point(574, 263);
            this.playerNameInsertBox.Name = "playerNameInsertBox";
            this.playerNameInsertBox.Size = new System.Drawing.Size(167, 20);
            this.playerNameInsertBox.TabIndex = 19;
            this.playerNameInsertBox.Visible = false;
            // 
            // passwordPlayerText
            // 
            this.passwordPlayerText.AutoSize = true;
            this.passwordPlayerText.BackColor = System.Drawing.Color.Transparent;
            this.passwordPlayerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordPlayerText.Location = new System.Drawing.Point(571, 293);
            this.passwordPlayerText.Name = "passwordPlayerText";
            this.passwordPlayerText.Size = new System.Drawing.Size(69, 17);
            this.passwordPlayerText.TabIndex = 18;
            this.passwordPlayerText.Text = "Password";
            this.passwordPlayerText.Visible = false;
            // 
            // namePLayerText
            // 
            this.namePLayerText.AutoSize = true;
            this.namePLayerText.BackColor = System.Drawing.Color.Transparent;
            this.namePLayerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePLayerText.Location = new System.Drawing.Point(571, 230);
            this.namePLayerText.Name = "namePLayerText";
            this.namePLayerText.Size = new System.Drawing.Size(108, 17);
            this.namePLayerText.TabIndex = 17;
            this.namePLayerText.Text = "Nome giocatore";
            this.namePLayerText.Visible = false;
            // 
            // alreadyExistPlayerButton
            // 
            this.alreadyExistPlayerButton.AutoSize = true;
            this.alreadyExistPlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.alreadyExistPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyExistPlayerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alreadyExistPlayerButton.Location = new System.Drawing.Point(34, 195);
            this.alreadyExistPlayerButton.Name = "alreadyExistPlayerButton";
            this.alreadyExistPlayerButton.Size = new System.Drawing.Size(252, 31);
            this.alreadyExistPlayerButton.TabIndex = 16;
            this.alreadyExistPlayerButton.Text = "Giocatore Esistente";
            this.alreadyExistPlayerButton.Visible = false;
            this.alreadyExistPlayerButton.Click += new System.EventHandler(this.alreadyExistPlayerButton_Click_1);
            // 
            // newPlayerButton
            // 
            this.newPlayerButton.AutoSize = true;
            this.newPlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.newPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerButton.Location = new System.Drawing.Point(34, 263);
            this.newPlayerButton.Name = "newPlayerButton";
            this.newPlayerButton.Size = new System.Drawing.Size(218, 31);
            this.newPlayerButton.TabIndex = 15;
            this.newPlayerButton.Text = "Nuovo Giocatore";
            this.newPlayerButton.Visible = false;
            this.newPlayerButton.Click += new System.EventHandler(this.newPlayerButton_Click_1);
            // 
            // Schermata_Iniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.quitPreLobbyButton);
            this.Controls.Add(this.inizioPartitaButton);
            this.Controls.Add(this.preLobbyTextSingleplayer);
            this.Controls.Add(this.preLobbyTextMultiplayer);
            this.Controls.Add(this.player2Picture);
            this.Controls.Add(this.player1Picture);
            this.Controls.Add(this.avvisoCredenzialiNonValide);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.backButtonGame);
            this.Controls.Add(this.playerPasswordInsertBox);
            this.Controls.Add(this.playerNameInsertBox);
            this.Controls.Add(this.passwordPlayerText);
            this.Controls.Add(this.namePLayerText);
            this.Controls.Add(this.alreadyExistPlayerButton);
            this.Controls.Add(this.newPlayerButton);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.singlePlayerButton);
            this.Controls.Add(this.fullMatchButton);
            this.Controls.Add(this.fastMatchButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.schermataPreLobby);
            this.Controls.Add(this.quitText);
            this.Controls.Add(this.settingsText);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.titoloGioco2);
            this.Controls.Add(this.titoloGioco1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Schermata_Iniziale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hyper Battleship";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Schermata_Iniziale_FormClosed);
            this.Load += new System.EventHandler(this.Schermata_Iniziale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schermataPreLobby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titoloGioco2;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Label settingsText;
        private System.Windows.Forms.Label quitText;
        private System.Windows.Forms.PictureBox schermataPreLobby;
        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.Label fastMatchButton;
        private System.Windows.Forms.Label fullMatchButton;
        private System.Windows.Forms.Label titoloGioco1;
        private System.Windows.Forms.Label singlePlayerButton;
        private System.Windows.Forms.Label multiplayerButton;
        private System.Windows.Forms.Label quitPreLobbyButton;
        private System.Windows.Forms.Label inizioPartitaButton;
        private System.Windows.Forms.Label preLobbyTextSingleplayer;
        private System.Windows.Forms.Label preLobbyTextMultiplayer;
        private System.Windows.Forms.PictureBox player2Picture;
        private System.Windows.Forms.PictureBox player1Picture;
        private System.Windows.Forms.Label avvisoCredenzialiNonValide;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label backButtonGame;
        private System.Windows.Forms.TextBox playerPasswordInsertBox;
        private System.Windows.Forms.TextBox playerNameInsertBox;
        private System.Windows.Forms.Label passwordPlayerText;
        private System.Windows.Forms.Label namePLayerText;
        private System.Windows.Forms.Label alreadyExistPlayerButton;
        private System.Windows.Forms.Label newPlayerButton;
    }
}