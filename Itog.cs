using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whale_search
{
    public partial class Itog : Form
    {
        public Itog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Самая высокая схожесть (89.993%) с китом №7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Poisk_po_izobrazh  ppi = new Poisk_po_izobrazh();
            this.Hide();
            ppi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выйти";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
