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
    public partial class Menu_Glowne : Form{
        private Button currentBtn;
        private Button previousBtn;

        public Menu_Glowne(){
            InitializeComponent();
        }

        private void Menu_Glowne_Load(object sender, EventArgs e){

        }

        //private void Btn_Sellect(object btnSender){
            //if (btnSender == null) { 
            
            //}
        //}

        private void BtnStartGame_Click(object sender, EventArgs e){
            this.Hide();
            Poziom_Trudnosci poziom_Trudnosci = new Poziom_Trudnosci();
            poziom_Trudnosci.Show();
        }
        private void BtnExit_Click(object sender, EventArgs e){
            Application.Exit();
        }
    }
}
