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
            this.classificaLabel = new System.Windows.Forms.Label();
            this.quitText = new System.Windows.Forms.Label();
            this.schermataPreLobby = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Label();
            this.fastMatchButton = new System.Windows.Forms.Label();
            this.normalMatchButton = new System.Windows.Forms.Label();
            this.titoloGioco1 = new System.Windows.Forms.Label();
            this.singlePlayerButton = new System.Windows.Forms.Label();
            this.multiplayerButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schermataPreLobby)).BeginInit();
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
            // classificaLabel
            // 
            this.classificaLabel.AutoSize = true;
            this.classificaLabel.BackColor = System.Drawing.Color.Transparent;
            this.classificaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificaLabel.Location = new System.Drawing.Point(377, 414);
            this.classificaLabel.Name = "classificaLabel";
            this.classificaLabel.Size = new System.Drawing.Size(252, 46);
            this.classificaLabel.TabIndex = 5;
            this.classificaLabel.Text = "CLASSIFICA";
            this.classificaLabel.Click += new System.EventHandler(this.classificaLabel_Click);
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
            this.backButton.Size = new System.Drawing.Size(105, 31);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Indietro";
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
            // normalMatchButton
            // 
            this.normalMatchButton.AutoSize = true;
            this.normalMatchButton.BackColor = System.Drawing.Color.Black;
            this.normalMatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalMatchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.normalMatchButton.Location = new System.Drawing.Point(890, 298);
            this.normalMatchButton.Name = "normalMatchButton";
            this.normalMatchButton.Size = new System.Drawing.Size(202, 31);
            this.normalMatchButton.TabIndex = 11;
            this.normalMatchButton.Text = "Partita Normale";
            this.normalMatchButton.Visible = false;
            this.normalMatchButton.Click += new System.EventHandler(this.normalMatchButton_Click);
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
            // Schermata_Iniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.multiplayerButton);
            this.Controls.Add(this.singlePlayerButton);
            this.Controls.Add(this.normalMatchButton);
            this.Controls.Add(this.fastMatchButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.schermataPreLobby);
            this.Controls.Add(this.quitText);
            this.Controls.Add(this.classificaLabel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titoloGioco2;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Label classificaLabel;
        private System.Windows.Forms.Label quitText;
        private System.Windows.Forms.PictureBox schermataPreLobby;
        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.Label fastMatchButton;
        private System.Windows.Forms.Label normalMatchButton;
        private System.Windows.Forms.Label titoloGioco1;
        private System.Windows.Forms.Label singlePlayerButton;
        private System.Windows.Forms.Label multiplayerButton;
    }
}