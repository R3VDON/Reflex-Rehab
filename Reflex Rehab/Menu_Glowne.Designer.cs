﻿namespace Reflex_Rehab{
    partial class Menu_Glowne{
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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelMainMenuHeader = new System.Windows.Forms.Panel();
            this.panelMainMenuButtons = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMainMenuFooter = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            this.panelMainMenuButtons.SuspendLayout();
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
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMainMenu.Controls.Add(this.panelMainMenuFooter);
            this.panelMainMenu.Controls.Add(this.panelMainMenuButtons);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 200);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(250, 785);
            this.panelMainMenu.TabIndex = 2;
            // 
            // panelMainMenuHeader
            // 
            this.panelMainMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMainMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenuHeader.Name = "panelMainMenuHeader";
            this.panelMainMenuHeader.Size = new System.Drawing.Size(1264, 200);
            this.panelMainMenuHeader.TabIndex = 2;
            // 
            // panelMainMenuButtons
            // 
            this.panelMainMenuButtons.Controls.Add(this.btnExit);
            this.panelMainMenuButtons.Controls.Add(this.btnHelp);
            this.panelMainMenuButtons.Controls.Add(this.btnSettings);
            this.panelMainMenuButtons.Controls.Add(this.btnStartGame);
            this.panelMainMenuButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenuButtons.Name = "panelMainMenuButtons";
            this.panelMainMenuButtons.Size = new System.Drawing.Size(250, 400);
            this.panelMainMenuButtons.TabIndex = 5;
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
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panelMainMenuFooter
            // 
            this.panelMainMenuFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelMainMenuFooter.Location = new System.Drawing.Point(0, 400);
            this.panelMainMenuFooter.Name = "panelMainMenuFooter";
            this.panelMainMenuFooter.Size = new System.Drawing.Size(250, 385);
            this.panelMainMenuFooter.TabIndex = 6;
            // 
            // Menu_Glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelMainMenuHeader);
            this.HelpButton = true;
            this.Name = "Menu_Glowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reflex Rehab";
            this.Load += new System.EventHandler(this.Menu_Glowne_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelMainMenuHeader;
        private System.Windows.Forms.Panel panelMainMenuButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelMainMenuFooter;
    }
}

