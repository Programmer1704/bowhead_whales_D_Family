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
    public partial class Sravnenie : Form
    {
        public Sravnenie()
        {
            InitializeComponent();
            timer1.Interval = 4000;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poisk_po_izobrazh ppi = new Poisk_po_izobrazh();
            this.Hide();
            ppi.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Itog frm = new Itog();
            this.Hide();
            frm.Show();
            timer1.Stop();
        }

        private void Sravnenie_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\User\Videos\Гифка с Gifius.ru.gif";
            axWindowsMediaPlayer1.uiMode = "none";
        }
    }
}
