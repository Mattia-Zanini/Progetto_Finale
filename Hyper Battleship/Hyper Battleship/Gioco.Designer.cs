namespace Hyper_Battleship
{
    partial class Gioco
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gioco));
            this.newPlayerButton = new System.Windows.Forms.Label();
            this.alreadyExistPlayerButton = new System.Windows.Forms.Label();
            this.namePLayerText = new System.Windows.Forms.Label();
            this.passwordPlayerText = new System.Windows.Forms.Label();
            this.playerNameInsertBox = new System.Windows.Forms.TextBox();
            this.playerPasswordInsertBox = new System.Windows.Forms.TextBox();
            this.backButtonGame = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.avvisoCredenzialiNonValide = new System.Windows.Forms.Label();
            this.player1Picture = new System.Windows.Forms.PictureBox();
            this.player2Picture = new System.Windows.Forms.PictureBox();
            this.preLobbyTextMultiplayer = new System.Windows.Forms.Label();
            this.preLobbyTextSingleplayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // newPlayerButton
            // 
            this.newPlayerButton.AutoSize = true;
            this.newPlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.newPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerButton.Location = new System.Drawing.Point(34, 263);
            this.newPlayerButton.Name = "newPlayerButton";
            this.newPlayerButton.Size = new System.Drawing.Size(218, 31);
            this.newPlayerButton.TabIndex = 0;
            this.newPlayerButton.Text = "Nuovo Giocatore";
            this.newPlayerButton.Click += new System.EventHandler(this.newPlayerButton_Click);
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
            this.alreadyExistPlayerButton.TabIndex = 1;
            this.alreadyExistPlayerButton.Text = "Giocatore Esistente";
            this.alreadyExistPlayerButton.Click += new System.EventHandler(this.alreadyExistPlayerButton_Click);
            // 
            // namePLayerText
            // 
            this.namePLayerText.AutoSize = true;
            this.namePLayerText.BackColor = System.Drawing.Color.Transparent;
            this.namePLayerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePLayerText.Location = new System.Drawing.Point(571, 230);
            this.namePLayerText.Name = "namePLayerText";
            this.namePLayerText.Size = new System.Drawing.Size(108, 17);
            this.namePLayerText.TabIndex = 2;
            this.namePLayerText.Text = "Nome giocatore";
            this.namePLayerText.Visible = false;
            // 
            // passwordPlayerText
            // 
            this.passwordPlayerText.AutoSize = true;
            this.passwordPlayerText.BackColor = System.Drawing.Color.Transparent;
            this.passwordPlayerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordPlayerText.Location = new System.Drawing.Point(571, 293);
            this.passwordPlayerText.Name = "passwordPlayerText";
            this.passwordPlayerText.Size = new System.Drawing.Size(69, 17);
            this.passwordPlayerText.TabIndex = 3;
            this.passwordPlayerText.Text = "Password";
            this.passwordPlayerText.Visible = false;
            // 
            // playerNameInsertBox
            // 
            this.playerNameInsertBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.playerNameInsertBox.Location = new System.Drawing.Point(574, 263);
            this.playerNameInsertBox.Name = "playerNameInsertBox";
            this.playerNameInsertBox.Size = new System.Drawing.Size(167, 20);
            this.playerNameInsertBox.TabIndex = 4;
            this.playerNameInsertBox.Visible = false;
            // 
            // playerPasswordInsertBox
            // 
            this.playerPasswordInsertBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.playerPasswordInsertBox.Location = new System.Drawing.Point(574, 326);
            this.playerPasswordInsertBox.Name = "playerPasswordInsertBox";
            this.playerPasswordInsertBox.Size = new System.Drawing.Size(167, 20);
            this.playerPasswordInsertBox.TabIndex = 5;
            this.playerPasswordInsertBox.Visible = false;
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
            this.backButtonGame.TabIndex = 6;
            this.backButtonGame.Text = "< INDIETRO";
            this.backButtonGame.Click += new System.EventHandler(this.backButtonGame_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Menu;
            this.confirmButton.Location = new System.Drawing.Point(739, 373);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Conferma";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // avvisoCredenzialiNonValide
            // 
            this.avvisoCredenzialiNonValide.AutoSize = true;
            this.avvisoCredenzialiNonValide.BackColor = System.Drawing.Color.Transparent;
            this.avvisoCredenzialiNonValide.ForeColor = System.Drawing.Color.Red;
            this.avvisoCredenzialiNonValide.Location = new System.Drawing.Point(574, 353);
            this.avvisoCredenzialiNonValide.Name = "avvisoCredenzialiNonValide";
            this.avvisoCredenzialiNonValide.Size = new System.Drawing.Size(0, 13);
            this.avvisoCredenzialiNonValide.TabIndex = 8;
            // 
            // player1Picture
            // 
            this.player1Picture.Image = ((System.Drawing.Image)(resources.GetObject("player1Picture.Image")));
            this.player1Picture.Location = new System.Drawing.Point(629, 146);
            this.player1Picture.Name = "player1Picture";
            this.player1Picture.Size = new System.Drawing.Size(50, 50);
            this.player1Picture.TabIndex = 9;
            this.player1Picture.TabStop = false;
            this.player1Picture.Visible = false;
            // 
            // player2Picture
            // 
            this.player2Picture.Image = ((System.Drawing.Image)(resources.GetObject("player2Picture.Image")));
            this.player2Picture.Location = new System.Drawing.Point(629, 146);
            this.player2Picture.Name = "player2Picture";
            this.player2Picture.Size = new System.Drawing.Size(50, 50);
            this.player2Picture.TabIndex = 10;
            this.player2Picture.TabStop = false;
            this.player2Picture.Visible = false;
            // 
            // preLobbyTextMultiplayer
            // 
            this.preLobbyTextMultiplayer.AutoSize = true;
            this.preLobbyTextMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preLobbyTextMultiplayer.Location = new System.Drawing.Point(436, 72);
            this.preLobbyTextMultiplayer.Name = "preLobbyTextMultiplayer";
            this.preLobbyTextMultiplayer.Size = new System.Drawing.Size(442, 46);
            this.preLobbyTextMultiplayer.TabIndex = 11;
            this.preLobbyTextMultiplayer.Text = "siete pronti per iniziare?";
            this.preLobbyTextMultiplayer.Visible = false;
            // 
            // preLobbyTextSingleplayer
            // 
            this.preLobbyTextSingleplayer.AutoSize = true;
            this.preLobbyTextSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preLobbyTextSingleplayer.Location = new System.Drawing.Point(446, 72);
            this.preLobbyTextSingleplayer.Name = "preLobbyTextSingleplayer";
            this.preLobbyTextSingleplayer.Size = new System.Drawing.Size(423, 46);
            this.preLobbyTextSingleplayer.TabIndex = 12;
            this.preLobbyTextSingleplayer.Text = "sei pronto per iniziare?";
            this.preLobbyTextSingleplayer.Visible = false;
            // 
            // Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gioco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hyper Battleship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gioco_FormClosing);
            this.Load += new System.EventHandler(this.Hyper_Battleship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newPlayerButton;
        private System.Windows.Forms.Label alreadyExistPlayerButton;
        private System.Windows.Forms.Label namePLayerText;
        private System.Windows.Forms.Label passwordPlayerText;
        private System.Windows.Forms.TextBox playerNameInsertBox;
        private System.Windows.Forms.TextBox playerPasswordInsertBox;
        private System.Windows.Forms.Label backButtonGame;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label avvisoCredenzialiNonValide;
        private System.Windows.Forms.PictureBox player1Picture;
        private System.Windows.Forms.PictureBox player2Picture;
        private System.Windows.Forms.Label preLobbyTextMultiplayer;
        private System.Windows.Forms.Label preLobbyTextSingleplayer;
    }
}

