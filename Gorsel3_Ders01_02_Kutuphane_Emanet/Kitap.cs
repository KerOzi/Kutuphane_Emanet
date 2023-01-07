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
    public partial class Kitap : Form
    {
        public Kitap()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Kitap_Load(object sender, EventArgs e)
        {
            dgv_kitaplar.DataSource = 
                vt.Select("select kitapNo,kitapAdi,geldiMi from kitap");
            dgv_kitaplar.Columns["kitapNo"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_kitapAdi.Text == "")
            {
                MessageBox.Show("Kitap Adı Boş Bırakılamaz !!!");
                return;
            }
            string geldiMi = chbx_geldiMi.Checked ? "1" : "0";
            object kayitSay = vt.Insert(@"insert into kitap(kitapAdi,geldiMi)
                values('"+tx_kitapAdi.Text+"',"+geldiMi+")");
            if ((int)kayitSay > 0)
            {
                Kitap_Load(sender, e);
                MessageBox.Show("Kayıt Eklendi...");
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_kitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz...");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from kitap where kitapNo="+dgv_kitaplar.SelectedRows[0].Cells["kitapNo"].Value);
            if (kayitSay > 0)
            {
                Kitap_Load(sender, e);
                MessageBox.Show("Kayıt Silindi...");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_kitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek satırı seçiniz...");
                return;
            }
            if (tx_kitapAdi.Text.Length < 3)
            {
                MessageBox.Show("Kitap Adı En Az 3 Karakter Olmalıdır !!!");
                return;
            }
            string geldiMi = chbx_geldiMi.Checked ? "1" : "0";
            int kayitSay = vt.UpdateDelete(@"update kitap set 
            kitapAdi='"+tx_kitapAdi.Text+"', geldiMi = "+geldiMi+
        "where kitapNo = " + dgv_kitaplar.SelectedRows[0].Cells["kitapNo"].Value);
            if (kayitSay > 0)
            {
                Kitap_Load(sender, e);
                MessageBox.Show("Kayıt Güncellendi...");
            }
        }

        private void dgv_kitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_kitaplar.SelectedRows.Count == 0)
            {
                return;
            }
            tx_kitapAdi.Text = dgv_kitaplar.SelectedRows[0].Cells["kitapAdi"].Value.ToString();
            string geldiMi = dgv_kitaplar.SelectedRows[0].Cells["geldiMi"].Value.ToString();
            chbx_geldiMi.Checked = geldiMi == "1" ? true : false;

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_kitapAdi.Text = "";
            chbx_geldiMi.Checked = false;
            if (dgv_kitaplar.SelectedRows.Count != 0)
                dgv_kitaplar.SelectedRows[0].Selected = false;
        }

        private void dgv_kitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
