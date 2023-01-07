namespace Gorsel3_Ders01_02_Kutuphane_Emanet
{
    partial class Kitap
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
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dgv_kitaplar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_kitapAdi = new System.Windows.Forms.TextBox();
            this.chbx_geldiMi = new System.Windows.Forms.CheckBox();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(138, 126);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(58, 24);
            this.btn_temizle.TabIndex = 13;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(38, 125);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(58, 25);
            this.btn_guncelle.TabIndex = 14;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(138, 94);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(58, 25);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(38, 94);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(58, 25);
            this.btn_ekle.TabIndex = 16;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dgv_kitaplar
            // 
            this.dgv_kitaplar.AllowUserToAddRows = false;
            this.dgv_kitaplar.AllowUserToDeleteRows = false;
            this.dgv_kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kitaplar.Location = new System.Drawing.Point(202, 30);
            this.dgv_kitaplar.MultiSelect = false;
            this.dgv_kitaplar.Name = "dgv_kitaplar";
            this.dgv_kitaplar.ReadOnly = true;
            this.dgv_kitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kitaplar.Size = new System.Drawing.Size(309, 248);
            this.dgv_kitaplar.TabIndex = 12;
            this.dgv_kitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kitaplar_CellContentClick);
            this.dgv_kitaplar.SelectionChanged += new System.EventHandler(this.dgv_kitaplar_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kitaplar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geldi Mi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kitap Adı :";
            // 
            // tx_kitapAdi
            // 
            this.tx_kitapAdi.Location = new System.Drawing.Point(96, 23);
            this.tx_kitapAdi.Name = "tx_kitapAdi";
            this.tx_kitapAdi.Size = new System.Drawing.Size(100, 20);
            this.tx_kitapAdi.TabIndex = 17;
            // 
            // chbx_geldiMi
            // 
            this.chbx_geldiMi.AutoSize = true;
            this.chbx_geldiMi.Location = new System.Drawing.Point(96, 59);
            this.chbx_geldiMi.Name = "chbx_geldiMi";
            this.chbx_geldiMi.Size = new System.Drawing.Size(15, 14);
            this.chbx_geldiMi.TabIndex = 18;
            this.chbx_geldiMi.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(78, 156);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(77, 23);
            this.btn_geri.TabIndex = 19;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 291);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.chbx_geldiMi);
            this.Controls.Add(this.tx_kitapAdi);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dgv_kitaplar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Kitap";
            this.Text = "Kitap";
            this.Load += new System.EventHandler(this.Kitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dgv_kitaplar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_kitapAdi;
        private System.Windows.Forms.CheckBox chbx_geldiMi;
        private System.Windows.Forms.Button btn_geri;
    }
}