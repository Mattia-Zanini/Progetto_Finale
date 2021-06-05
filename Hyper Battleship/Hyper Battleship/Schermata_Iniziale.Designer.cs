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
            this.titoloGioco1 = new System.Windows.Forms.Label();
            this.classificaGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.classificaGridView)).BeginInit();
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
            // classificaGridView
            // 
            this.classificaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classificaGridView.Location = new System.Drawing.Point(876, 218);
            this.classificaGridView.Name = "classificaGridView";
            this.classificaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classificaGridView.Size = new System.Drawing.Size(260, 95);
            this.classificaGridView.TabIndex = 14;
            this.classificaGridView.Visible = false;
            // 
            // Schermata_Iniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.classificaGridView);
            this.Controls.Add(this.quitText);
            this.Controls.Add(this.classificaLabel);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.titoloGioco2);
            this.Controls.Add(this.titoloGioco1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Schermata_Iniziale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hyper Battleship";
            ((System.ComponentModel.ISupportInitialize)(this.classificaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titoloGioco2;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Label classificaLabel;
        private System.Windows.Forms.Label quitText;
        private System.Windows.Forms.Label titoloGioco1;
        private System.Windows.Forms.DataGridView classificaGridView;
    }
}