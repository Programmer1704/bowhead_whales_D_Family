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
    public partial class Poisk_po_izobrazh : Form
    {
        public Poisk_po_izobrazh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sravnenie sr = new Sravnenie();
            this.Hide();
            sr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы дейтвительно хотите выйти?";
            String caption = " Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
