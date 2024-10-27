using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflex_Rehab{
    public partial class Ekran_Glowny : Form{
        private Button currentBtn;
        private Button previousBtn;

        public Ekran_Glowny(){
            InitializeComponent();
        }

        private void Menu_Glowne_Load(object sender, EventArgs e){

        }

        private void addUserControl(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            panelGame.Controls.Clear();
            panelGame.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnStartGame_Click(object sender, EventArgs e){
            panelMainMenuButtons.Hide();
            panelDifficultySelectionMenu.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e) {

        }
        private void btnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void btnEasy_Click(object sender, EventArgs e) {
            Poziom_Latwy poziom_Latwy = new Poziom_Latwy();
            addUserControl(poziom_Latwy);
            panelMainMenu.Hide();
            panelMainMenuHeader.Hide();
            panelMainMenuButtons.Hide();
            panelDifficultySelectionMenu.Hide();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e) {
            panelDifficultySelectionMenu.Hide();
            panelMainMenuButtons.Show();
        }
    }
}
