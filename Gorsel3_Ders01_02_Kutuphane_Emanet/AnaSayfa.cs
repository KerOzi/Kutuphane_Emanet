using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel3_Ders01_02_Kutuphane_Emanet
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Uye_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.Show();
            this.Hide();
        }

        private void btn_kitap_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Show();
            this.Hide();
        }

        private void btn_Emanet_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.Show();
            this.Hide();
        }
    }
}
