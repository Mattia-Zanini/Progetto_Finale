namespace Hyper_Battleship
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginAccountLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.backLabel = new System.Windows.Forms.Label();
            this.startMatchLabel = new System.Windows.Forms.Label();
            this.yesStartMatch = new System.Windows.Forms.Label();
            this.noStartMatch = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.avvisoNumeroMinimoCaratteriDaInserire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginAccountLabel
            // 
            this.loginAccountLabel.AutoSize = true;
            this.loginAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAccountLabel.ForeColor = System.Drawing.Color.Gray;
            this.loginAccountLabel.Location = new System.Drawing.Point(82, 71);
            this.loginAccountLabel.Name = "loginAccountLabel";
            this.loginAccountLabel.Size = new System.Drawing.Size(186, 31);
            this.loginAccountLabel.TabIndex = 0;
            this.loginAccountLabel.Text = "Login Account";
            this.loginAccountLabel.Visible = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(49, 151);
            this.usernameTextBox.MaxLength = 12;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(246, 27);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Gray;
            this.usernameLabel.Location = new System.Drawing.Point(45, 126);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 22);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Lime;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(49, 227);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(246, 34);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.Gray;
            this.backLabel.Location = new System.Drawing.Point(12, 9);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(55, 17);
            this.backLabel.TabIndex = 12;
            this.backLabel.Text = "Indietro";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // startMatchLabel
            // 
            this.startMatchLabel.AutoSize = true;
            this.startMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMatchLabel.ForeColor = System.Drawing.Color.Gray;
            this.startMatchLabel.Location = new System.Drawing.Point(43, 56);
            this.startMatchLabel.Name = "startMatchLabel";
            this.startMatchLabel.Size = new System.Drawing.Size(287, 31);
            this.startMatchLabel.TabIndex = 19;
            this.startMatchLabel.Text = "Vuoi iniziare la partita?";
            this.startMatchLabel.Visible = false;
            // 
            // yesStartMatch
            // 
            this.yesStartMatch.AutoSize = true;
            this.yesStartMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesStartMatch.ForeColor = System.Drawing.Color.Gray;
            this.yesStartMatch.Location = new System.Drawing.Point(29, 193);
            this.yesStartMatch.Name = "yesStartMatch";
            this.yesStartMatch.Size = new System.Drawing.Size(38, 31);
            this.yesStartMatch.TabIndex = 20;
            this.yesStartMatch.Text = "Si";
            this.yesStartMatch.Visible = false;
            this.yesStartMatch.Click += new System.EventHandler(this.yesStartMatch_Click);
            // 
            // noStartMatch
            // 
            this.noStartMatch.AutoSize = true;
            this.noStartMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noStartMatch.ForeColor = System.Drawing.Color.Gray;
            this.noStartMatch.Location = new System.Drawing.Point(281, 193);
            this.noStartMatch.Name = "noStartMatch";
            this.noStartMatch.Size = new System.Drawing.Size(49, 31);
            this.noStartMatch.TabIndex = 21;
            this.noStartMatch.Text = "No";
            this.noStartMatch.Visible = false;
            this.noStartMatch.Click += new System.EventHandler(this.noStartMatch_Click);
            // 
            // player2
            // 
            this.player2.Image = global::Hyper_Battleship.Properties.Resources.P2;
            this.player2.Location = new System.Drawing.Point(143, 12);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(50, 50);
            this.player2.TabIndex = 8;
            this.player2.TabStop = false;
            this.player2.Visible = false;
            // 
            // player1
            // 
            this.player1.Image = global::Hyper_Battleship.Properties.Resources.P1;
            this.player1.Location = new System.Drawing.Point(143, 12);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(50, 50);
            this.player1.TabIndex = 7;
            this.player1.TabStop = false;
            this.player1.Visible = false;
            // 
            // avvisoNumeroMinimoCaratteriDaInserire
            // 
            this.avvisoNumeroMinimoCaratteriDaInserire.AutoSize = true;
            this.avvisoNumeroMinimoCaratteriDaInserire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avvisoNumeroMinimoCaratteriDaInserire.ForeColor = System.Drawing.Color.Gray;
            this.avvisoNumeroMinimoCaratteriDaInserire.Location = new System.Drawing.Point(198, 135);
            this.avvisoNumeroMinimoCaratteriDaInserire.Name = "avvisoNumeroMinimoCaratteriDaInserire";
            this.avvisoNumeroMinimoCaratteriDaInserire.Size = new System.Drawing.Size(97, 13);
            this.avvisoNumeroMinimoCaratteriDaInserire.TabIndex = 22;
            this.avvisoNumeroMinimoCaratteriDaInserire.Text = "(almeno 4 caratteri)";
            this.avvisoNumeroMinimoCaratteriDaInserire.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 290);
            this.Controls.Add(this.avvisoNumeroMinimoCaratteriDaInserire);
            this.Controls.Add(this.noStartMatch);
            this.Controls.Add(this.yesStartMatch);
            this.Controls.Add(this.startMatchLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.loginAccountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginAccountLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label startMatchLabel;
        private System.Windows.Forms.Label yesStartMatch;
        private System.Windows.Forms.Label noStartMatch;
        private System.Windows.Forms.Label avvisoNumeroMinimoCaratteriDaInserire;
    }
}