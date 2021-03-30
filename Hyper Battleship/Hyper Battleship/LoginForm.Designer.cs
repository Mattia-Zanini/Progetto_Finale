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
            this.loginAccountLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.newPlayerLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.alertLoginAccount = new System.Windows.Forms.Label();
            this.playerLabel2 = new System.Windows.Forms.Label();
            this.playerLabel3 = new System.Windows.Forms.Label();
            this.newPlayerLabel2 = new System.Windows.Forms.Label();
            this.playerWithOutScore = new System.Windows.Forms.Label();
            this.playerWithOutScoreLabel = new System.Windows.Forms.Label();
            this.exitLoginButton = new System.Windows.Forms.Label();
            this.startMatchLabel = new System.Windows.Forms.Label();
            this.yesStartMatch = new System.Windows.Forms.Label();
            this.noStartMatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
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
            this.usernameTextBox.Location = new System.Drawing.Point(49, 139);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(246, 27);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Gray;
            this.usernameLabel.Location = new System.Drawing.Point(46, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Gray;
            this.passwordLabel.Location = new System.Drawing.Point(46, 194);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(49, 214);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(246, 27);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Visible = false;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.Color.Gray;
            this.showPassword.Location = new System.Drawing.Point(49, 270);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(135, 21);
            this.showPassword.TabIndex = 5;
            this.showPassword.Text = "Mostra Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.Visible = false;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Lime;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(49, 313);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(246, 34);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.Gray;
            this.playerLabel.Location = new System.Drawing.Point(6, 79);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(249, 31);
            this.playerLabel.TabIndex = 10;
            this.playerLabel.Text = "Giocatore esistente";
            this.playerLabel.Click += new System.EventHandler(this.playerLabel_Click);
            this.playerLabel.MouseEnter += new System.EventHandler(this.playerLabel_MouseEnter);
            this.playerLabel.MouseLeave += new System.EventHandler(this.playerLabel_MouseLeave);
            // 
            // newPlayerLabel
            // 
            this.newPlayerLabel.AutoSize = true;
            this.newPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerLabel.ForeColor = System.Drawing.Color.Gray;
            this.newPlayerLabel.Location = new System.Drawing.Point(9, 180);
            this.newPlayerLabel.Name = "newPlayerLabel";
            this.newPlayerLabel.Size = new System.Drawing.Size(212, 31);
            this.newPlayerLabel.TabIndex = 11;
            this.newPlayerLabel.Text = "Nuovo giocatore";
            this.newPlayerLabel.Click += new System.EventHandler(this.newPlayerLabel_Click);
            this.newPlayerLabel.MouseEnter += new System.EventHandler(this.newPlayerLabel_MouseEnter);
            this.newPlayerLabel.MouseLeave += new System.EventHandler(this.newPlayerLabel_MouseLeave);
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
            this.backLabel.Visible = false;
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // alertLoginAccount
            // 
            this.alertLoginAccount.AutoSize = true;
            this.alertLoginAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLoginAccount.ForeColor = System.Drawing.Color.Red;
            this.alertLoginAccount.Location = new System.Drawing.Point(46, 244);
            this.alertLoginAccount.Name = "alertLoginAccount";
            this.alertLoginAccount.Size = new System.Drawing.Size(0, 17);
            this.alertLoginAccount.TabIndex = 10;
            this.alertLoginAccount.Visible = false;
            // 
            // playerLabel2
            // 
            this.playerLabel2.AutoSize = true;
            this.playerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel2.ForeColor = System.Drawing.Color.Gray;
            this.playerLabel2.Location = new System.Drawing.Point(53, 111);
            this.playerLabel2.Name = "playerLabel2";
            this.playerLabel2.Size = new System.Drawing.Size(158, 13);
            this.playerLabel2.TabIndex = 13;
            this.playerLabel2.Text = "Ti permette di collegarti al profilo";
            this.playerLabel2.Visible = false;
            // 
            // playerLabel3
            // 
            this.playerLabel3.AutoSize = true;
            this.playerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel3.ForeColor = System.Drawing.Color.Gray;
            this.playerLabel3.Location = new System.Drawing.Point(53, 124);
            this.playerLabel3.Name = "playerLabel3";
            this.playerLabel3.Size = new System.Drawing.Size(126, 13);
            this.playerLabel3.TabIndex = 14;
            this.playerLabel3.Text = "di un utente già registrato";
            this.playerLabel3.Visible = false;
            // 
            // newPlayerLabel2
            // 
            this.newPlayerLabel2.AutoSize = true;
            this.newPlayerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPlayerLabel2.ForeColor = System.Drawing.Color.Gray;
            this.newPlayerLabel2.Location = new System.Drawing.Point(53, 220);
            this.newPlayerLabel2.Name = "newPlayerLabel2";
            this.newPlayerLabel2.Size = new System.Drawing.Size(216, 13);
            this.newPlayerLabel2.TabIndex = 15;
            this.newPlayerLabel2.Text = "Ti permette di creare un nuovo profilo utente";
            this.newPlayerLabel2.Visible = false;
            // 
            // playerWithOutScore
            // 
            this.playerWithOutScore.AutoSize = true;
            this.playerWithOutScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWithOutScore.ForeColor = System.Drawing.Color.Gray;
            this.playerWithOutScore.Location = new System.Drawing.Point(9, 270);
            this.playerWithOutScore.Name = "playerWithOutScore";
            this.playerWithOutScore.Size = new System.Drawing.Size(225, 31);
            this.playerWithOutScore.TabIndex = 16;
            this.playerWithOutScore.Text = "Senza Salvataggi";
            this.playerWithOutScore.Click += new System.EventHandler(this.playerWithOutScore_Click);
            this.playerWithOutScore.MouseEnter += new System.EventHandler(this.playerWithOutScore_MouseEnter);
            this.playerWithOutScore.MouseLeave += new System.EventHandler(this.playerWithOutScore_MouseLeave);
            // 
            // playerWithOutScoreLabel
            // 
            this.playerWithOutScoreLabel.AutoSize = true;
            this.playerWithOutScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWithOutScoreLabel.ForeColor = System.Drawing.Color.Gray;
            this.playerWithOutScoreLabel.Location = new System.Drawing.Point(53, 304);
            this.playerWithOutScoreLabel.Name = "playerWithOutScoreLabel";
            this.playerWithOutScoreLabel.Size = new System.Drawing.Size(217, 13);
            this.playerWithOutScoreLabel.TabIndex = 17;
            this.playerWithOutScoreLabel.Text = "Ti permette di giocare senza creare un profio";
            this.playerWithOutScoreLabel.Visible = false;
            // 
            // exitLoginButton
            // 
            this.exitLoginButton.AutoSize = true;
            this.exitLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLoginButton.ForeColor = System.Drawing.Color.Gray;
            this.exitLoginButton.Location = new System.Drawing.Point(12, 9);
            this.exitLoginButton.Name = "exitLoginButton";
            this.exitLoginButton.Size = new System.Drawing.Size(34, 17);
            this.exitLoginButton.TabIndex = 18;
            this.exitLoginButton.Text = "Esci";
            this.exitLoginButton.Click += new System.EventHandler(this.exitLoginButton_Click);
            // 
            // startMatchLabel
            // 
            this.startMatchLabel.AutoSize = true;
            this.startMatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMatchLabel.ForeColor = System.Drawing.Color.Gray;
            this.startMatchLabel.Location = new System.Drawing.Point(43, 26);
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
            this.yesStartMatch.Location = new System.Drawing.Point(25, 141);
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
            this.noStartMatch.Location = new System.Drawing.Point(284, 141);
            this.noStartMatch.Name = "noStartMatch";
            this.noStartMatch.Size = new System.Drawing.Size(49, 31);
            this.noStartMatch.TabIndex = 21;
            this.noStartMatch.Text = "No";
            this.noStartMatch.Visible = false;
            this.noStartMatch.Click += new System.EventHandler(this.noStartMatch_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 361);
            this.Controls.Add(this.noStartMatch);
            this.Controls.Add(this.yesStartMatch);
            this.Controls.Add(this.startMatchLabel);
            this.Controls.Add(this.exitLoginButton);
            this.Controls.Add(this.playerWithOutScoreLabel);
            this.Controls.Add(this.playerWithOutScore);
            this.Controls.Add(this.newPlayerLabel2);
            this.Controls.Add(this.playerLabel3);
            this.Controls.Add(this.playerLabel2);
            this.Controls.Add(this.alertLoginAccount);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.newPlayerLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.loginAccountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginAccountLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label newPlayerLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label alertLoginAccount;
        private System.Windows.Forms.Label playerLabel2;
        private System.Windows.Forms.Label playerLabel3;
        private System.Windows.Forms.Label newPlayerLabel2;
        private System.Windows.Forms.Label playerWithOutScore;
        private System.Windows.Forms.Label playerWithOutScoreLabel;
        private System.Windows.Forms.Label exitLoginButton;
        private System.Windows.Forms.Label startMatchLabel;
        private System.Windows.Forms.Label yesStartMatch;
        private System.Windows.Forms.Label noStartMatch;
    }
}