using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflex_Rehab
{
    public partial class Menu_Glowne : Form
    {
        public Menu_Glowne()
        {
            InitializeComponent();
        }

        private void Menu_Glowne_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poziom_Trudnosci poziom_Trudnosci = new Poziom_Trudnosci();
            poziom_Trudnosci.Show();
        }
    }
}
