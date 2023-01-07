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
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_emanetVerilenKitaplar.DataSource
                = vt.Select(@"select e.emanet_id,k.kitapNo,k.kitapAdi,
                u.uyeNo,u.uyeAdi,u.uyeSoyadi,e.emanetTarihi
                from emanet e 
	                join kitap k on e.kitapNo=k.kitapNo
	                join uyeler u on e.uyeNo=u.uyeNo");
            dgv_emanetVerilenKitaplar.Columns["emanet_id"].Visible = false;
            dgv_emanetVerilenKitaplar.Columns["kitapNo"].Visible = false;
            dgv_emanetVerilenKitaplar.Columns["uyeNo"].Visible = false;

            cbx_kitap.DataSource = vt.Select("Select kitapNo,kitapAdi from kitap");
            cbx_kitap.ValueMember = "kitapNo";
            cbx_kitap.DisplayMember = "kitapAdi";

            cbx_uye.DataSource = vt.Select("select uyeNo,uyeAdi+' '+uyeSoyadi adSoyad from uyeler");
            cbx_uye.DisplayMember = "adSoyad";
            cbx_uye.ValueMember = "uyeNo";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cbx_uye.SelectedIndex == -1)
            {
                MessageBox.Show("Üye Seçiniz....");
                return;
            }
            if (cbx_kitap.SelectedIndex == -1)
            {
                MessageBox.Show("Kitap Seçiniz....");
                return;
            }

            object kayitSay = 
                vt.Insert(@"insert into emanet(uyeNo,kitapNo,emanetTarihi)
		              values("+cbx_uye.SelectedValue+","
                      +cbx_kitap.SelectedValue+",'"
                      +dtp_tarih.Value+"')");
            if (Convert.ToInt32(kayitSay) > 0)
            {
                Form1_Load(null,null);
                MessageBox.Show("Emanet eklendi...");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_emanetVerilenKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek kaydı seçiniz...");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from emanet where emanet_id="+
                dgv_emanetVerilenKitaplar.SelectedRows[0].Cells["emanet_id"].Value);
            if (kayitSay > 0)
            {
                Form1_Load(null, null);
                MessageBox.Show("Kayıt Silindi...");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_emanetVerilenKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek kaydı seçiniz...");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update  emanet
                                    set kitapNo =" + cbx_kitap.SelectedValue + @",
	                                    uyeNo=" + cbx_uye.SelectedValue + @",
	                                    emanetTarihi ='" + dtp_tarih.Value + @"'
                                    where emanet_id ="
            + dgv_emanetVerilenKitaplar.SelectedRows[0].Cells["emanet_id"].Value);
            if (kayitSay > 0)
            {
                Form1_Load(null, null);
                MessageBox.Show("Kayıt Güncellendi...");
            }
        }

        private void dgv_emanetVerilenKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_emanetVerilenKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_emanetVerilenKitaplar.SelectedRows.Count == 0)
                return;
            cbx_kitap.SelectedValue = dgv_emanetVerilenKitaplar.SelectedRows[0].Cells["kitapNo"].Value.ToString();
            cbx_uye.SelectedValue = dgv_emanetVerilenKitaplar.SelectedRows[0].Cells["uyeNo"].Value.ToString();
            dtp_tarih.Value = (DateTime)dgv_emanetVerilenKitaplar.SelectedRows[0].Cells["emanetTarihi"].Value;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cbx_kitap.SelectedIndex = -1;
            cbx_uye.SelectedIndex = -1;
            dtp_tarih.Value = DateTime.Now;
            if (dgv_emanetVerilenKitaplar.SelectedRows.Count != 0)
                dgv_emanetVerilenKitaplar.SelectedRows[0].Selected = false;
        }

        private void cbx_uye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
