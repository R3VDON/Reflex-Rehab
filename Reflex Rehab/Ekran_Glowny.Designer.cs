namespace Reflex_Rehab{
    partial class Ekran_Glowny{
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent(){
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelDifficultySelectionMenu = new System.Windows.Forms.Panel();
            this.panelMainMenuButtons = new System.Windows.Forms.Panel();
            this.panelMainMenuHeader = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            this.panelDifficultySelectionMenu.SuspendLayout();
            this.panelMainMenuButtons.SuspendLayout();
            this.panelMainMenuHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnStartGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartGame.Location = new System.Drawing.Point(0, 0);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(250, 100);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Rozpocznij Grę";
            this.btnStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(0, 300);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 100);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Wyjdź";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHelp.Location = new System.Drawing.Point(0, 200);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(250, 100);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Pomoc";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Location = new System.Drawing.Point(0, 100);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(250, 100);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Ustawienia";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnBackToMainMenu.FlatAppearance.BorderSize = 0;
            this.btnBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBackToMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(0, 300);
            this.btnBackToMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(250, 100);
            this.btnBackToMainMenu.TabIndex = 4;
            this.btnBackToMainMenu.Text = "Powrót";
            this.btnBackToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnEasy.FlatAppearance.BorderSize = 0;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEasy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEasy.Location = new System.Drawing.Point(0, 0);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(0);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(250, 100);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Łatwy";
            this.btnEasy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(0, 100);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(250, 100);
            this.btnMedium.TabIndex = 2;
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(0, 200);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(250, 100);
            this.btnHard.TabIndex = 3;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMainMenu.Controls.Add(this.panelDifficultySelectionMenu);
            this.panelMainMenu.Controls.Add(this.panelMainMenuButtons);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 200);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(250, 785);
            this.panelMainMenu.TabIndex = 2;
            // 
            // panelDifficultySelectionMenu
            // 
            this.panelDifficultySelectionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelDifficultySelectionMenu.Controls.Add(this.btnEasy);
            this.panelDifficultySelectionMenu.Controls.Add(this.btnBackToMainMenu);
            this.panelDifficultySelectionMenu.Location = new System.Drawing.Point(0, 0);
            this.panelDifficultySelectionMenu.Name = "panelDifficultySelectionMenu";
            this.panelDifficultySelectionMenu.Size = new System.Drawing.Size(250, 785);
            this.panelDifficultySelectionMenu.TabIndex = 6;
            this.panelDifficultySelectionMenu.Visible = false;
            // 
            // panelMainMenuButtons
            // 
            this.panelMainMenuButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelMainMenuButtons.Controls.Add(this.btnExit);
            this.panelMainMenuButtons.Controls.Add(this.btnHelp);
            this.panelMainMenuButtons.Controls.Add(this.btnSettings);
            this.panelMainMenuButtons.Controls.Add(this.btnStartGame);
            this.panelMainMenuButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenuButtons.Name = "panelMainMenuButtons";
            this.panelMainMenuButtons.Size = new System.Drawing.Size(250, 785);
            this.panelMainMenuButtons.TabIndex = 5;
            // 
            // panelMainMenuHeader
            // 
            this.panelMainMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMainMenuHeader.Controls.Add(this.panelGame);
            this.panelMainMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenuHeader.Name = "panelMainMenuHeader";
            this.panelMainMenuHeader.Size = new System.Drawing.Size(1264, 200);
            this.panelMainMenuHeader.TabIndex = 2;
            // 
            // panelGame
            // 
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1264, 985);
            this.panelGame.TabIndex = 3;
            // 
            // Ekran_Glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelMainMenuHeader);
            this.HelpButton = true;
            this.Name = "Ekran_Glowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reflex Rehab";
            this.Load += new System.EventHandler(this.Menu_Glowne_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelDifficultySelectionMenu.ResumeLayout(false);
            this.panelMainMenuButtons.ResumeLayout(false);
            this.panelMainMenuHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelMainMenuHeader;
        private System.Windows.Forms.Panel panelMainMenuButtons;
        private System.Windows.Forms.Panel panelDifficultySelectionMenu;
        private System.Windows.Forms.Panel panelGame;
    }
}

