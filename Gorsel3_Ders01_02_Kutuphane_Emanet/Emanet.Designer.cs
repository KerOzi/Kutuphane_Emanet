namespace Gorsel3_Ders01_02_Kutuphane_Emanet
{
    partial class Emanet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.cbx_uye = new System.Windows.Forms.ComboBox();
            this.cbx_kitap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_emanetVerilenKitaplar = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.anaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emanetVerilenKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.CustomFormat = "dd.MM.yyyy";
            this.dtp_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tarih.Location = new System.Drawing.Point(56, 94);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(156, 20);
            this.dtp_tarih.TabIndex = 0;
            // 
            // cbx_uye
            // 
            this.cbx_uye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_uye.FormattingEnabled = true;
            this.cbx_uye.Location = new System.Drawing.Point(56, 27);
            this.cbx_uye.Name = "cbx_uye";
            this.cbx_uye.Size = new System.Drawing.Size(156, 21);
            this.cbx_uye.TabIndex = 1;
            this.cbx_uye.SelectedIndexChanged += new System.EventHandler(this.cbx_uye_SelectedIndexChanged);
            // 
            // cbx_kitap
            // 
            this.cbx_kitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_kitap.FormattingEnabled = true;
            this.cbx_kitap.Location = new System.Drawing.Point(56, 62);
            this.cbx_kitap.Name = "cbx_kitap";
            this.cbx_kitap.Size = new System.Drawing.Size(156, 21);
            this.cbx_kitap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Emanet Verilen Kitaplar :";
            // 
            // dgv_emanetVerilenKitaplar
            // 
            this.dgv_emanetVerilenKitaplar.AllowUserToAddRows = false;
            this.dgv_emanetVerilenKitaplar.AllowUserToDeleteRows = false;
            this.dgv_emanetVerilenKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emanetVerilenKitaplar.Location = new System.Drawing.Point(218, 27);
            this.dgv_emanetVerilenKitaplar.MultiSelect = false;
            this.dgv_emanetVerilenKitaplar.Name = "dgv_emanetVerilenKitaplar";
            this.dgv_emanetVerilenKitaplar.ReadOnly = true;
            this.dgv_emanetVerilenKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emanetVerilenKitaplar.Size = new System.Drawing.Size(365, 233);
            this.dgv_emanetVerilenKitaplar.TabIndex = 3;
            this.dgv_emanetVerilenKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emanetVerilenKitaplar_CellContentClick);
            this.dgv_emanetVerilenKitaplar.SelectionChanged += new System.EventHandler(this.dgv_emanetVerilenKitaplar_SelectionChanged);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(56, 129);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(137, 129);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(56, 158);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(137, 158);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // anaSayfa
            // 
            this.anaSayfa.Location = new System.Drawing.Point(93, 187);
            this.anaSayfa.Name = "anaSayfa";
            this.anaSayfa.Size = new System.Drawing.Size(75, 23);
            this.anaSayfa.TabIndex = 5;
            this.anaSayfa.Text = "Ana Sayfa";
            this.anaSayfa.UseVisualStyleBackColor = true;
            this.anaSayfa.Click += new System.EventHandler(this.anaSayfa_Click);
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 279);
            this.Controls.Add(this.anaSayfa);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dgv_emanetVerilenKitaplar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_kitap);
            this.Controls.Add(this.cbx_uye);
            this.Controls.Add(this.dtp_tarih);
            this.Name = "Emanet";
            this.Text = "Emanet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emanetVerilenKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.ComboBox cbx_uye;
        private System.Windows.Forms.ComboBox cbx_kitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_emanetVerilenKitaplar;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button anaSayfa;
    }
}

