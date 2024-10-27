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

        //private void Btn_Sellect(object btnSender){
            //if (btnSender == null) { 
            
            //}
        //}

        private void BtnStartGame_Click(object sender, EventArgs e){
            panelMainMenuButtons.Hide();
            panelDifficultySelectionMenu.Show();
        }
        private void BtnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e) {

        }
    }
}
