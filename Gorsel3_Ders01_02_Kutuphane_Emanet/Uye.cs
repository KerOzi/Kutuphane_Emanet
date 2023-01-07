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
    public partial class Uye : Form
    {
        public Uye()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Uye_Load(object sender, EventArgs e)
        {

            dgv_uyeler.DataSource =
                vt.Select("select uyeNo,uyeAdi,uyeSoyadi,cinsiyet,telefon,ePosta,adresNo from uyeler");
            dgv_uyeler.Columns["uyeNo"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            object kayitSay =
               vt.Insert(@"insert into uyeler(uyeAdi,uyeSoyadi,cinsiyet,telefon,ePosta,adresNo)
                values('"+txt_uyeAd.Text+"','"+txt_uyeSoyad.Text+"','"+txt_cinsiyet.Text+"','"+txt_telefon.Text+"','"+txt_eposta.Text+"','"+txt_adresNo.Text+"')");
            if (Convert.ToInt32(kayitSay) > 0)
            {
                Uye_Load(null, null);
                MessageBox.Show("Üye Eklendi eklendi...");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek kaydı seçiniz...");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from uyeler where uyeNo=" +
                dgv_uyeler.SelectedRows[0].Cells["uyeNo"].Value);
            if (kayitSay > 0)
            {
                Uye_Load(null, null);
                MessageBox.Show("Kayıt Silindi...");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek kaydı seçiniz...");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update  uyeler
                                    set uyeAdi ='" + txt_uyeAd.Text + @"',
	                                    uyeSoyadi='" + txt_uyeSoyad.Text + @"',
	                                    cinsiyet ='" + txt_cinsiyet.Text + @"',
                                        telefon ='" + txt_telefon.Text + @"',
                                        ePosta ='" + txt_eposta.Text + @"',
                                        adresNo ='" + txt_adresNo.Text + @"'
                                    where uyeNo ="
            + dgv_uyeler.SelectedRows[0].Cells["uyeNo"].Value);
            if (kayitSay > 0)
            {
                Uye_Load(null, null);
                MessageBox.Show("Kayıt Güncellendi...");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_uyeAd.Text = "";
            txt_uyeSoyad.Text = "";
            txt_cinsiyet.Text = "";
            txt_telefon.Text = "";
            txt_eposta.Text = "";
            txt_adresNo.Text = "";
            if (dgv_uyeler.SelectedRows.Count != 0)
                dgv_uyeler.SelectedRows[0].Selected = false;
        }

        private void dgv_uyeler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_uyeler.SelectedRows.Count == 0)
            {
                return;
            }
            txt_uyeAd.Text = dgv_uyeler.SelectedRows[0].Cells["uyeAdi"].Value.ToString();
            txt_uyeSoyad.Text = dgv_uyeler.SelectedRows[0].Cells["uyeSoyadi"].Value.ToString();
            txt_cinsiyet.Text = dgv_uyeler.SelectedRows[0].Cells["cinsiyet"].Value.ToString();
            txt_telefon.Text = dgv_uyeler.SelectedRows[0].Cells["telefon"].Value.ToString();
            txt_eposta.Text = dgv_uyeler.SelectedRows[0].Cells["ePosta"].Value.ToString();
            txt_adresNo.Text = dgv_uyeler.SelectedRows[0].Cells["adresNo"].Value.ToString();

        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
             AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
