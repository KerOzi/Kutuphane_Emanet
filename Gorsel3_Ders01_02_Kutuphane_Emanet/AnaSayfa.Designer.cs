namespace Gorsel3_Ders01_02_Kutuphane_Emanet
{
    partial class AnaSayfa
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
            this.btn_Uye = new System.Windows.Forms.Button();
            this.btn_Emanet = new System.Windows.Forms.Button();
            this.btn_kitap = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Uye
            // 
            this.btn_Uye.Location = new System.Drawing.Point(96, 48);
            this.btn_Uye.Name = "btn_Uye";
            this.btn_Uye.Size = new System.Drawing.Size(75, 25);
            this.btn_Uye.TabIndex = 0;
            this.btn_Uye.Text = "Uye İşlemleri";
            this.btn_Uye.UseVisualStyleBackColor = true;
            this.btn_Uye.Click += new System.EventHandler(this.btn_Uye_Click);
            // 
            // btn_Emanet
            // 
            this.btn_Emanet.Location = new System.Drawing.Point(96, 79);
            this.btn_Emanet.Name = "btn_Emanet";
            this.btn_Emanet.Size = new System.Drawing.Size(75, 23);
            this.btn_Emanet.TabIndex = 1;
            this.btn_Emanet.Text = "Emanet ";
            this.btn_Emanet.UseVisualStyleBackColor = true;
            this.btn_Emanet.Click += new System.EventHandler(this.btn_Emanet_Click);
            // 
            // btn_kitap
            // 
            this.btn_kitap.Location = new System.Drawing.Point(96, 108);
            this.btn_kitap.Name = "btn_kitap";
            this.btn_kitap.Size = new System.Drawing.Size(75, 35);
            this.btn_kitap.TabIndex = 2;
            this.btn_kitap.Text = "Kitap İşlemleri";
            this.btn_kitap.UseVisualStyleBackColor = true;
            this.btn_kitap.Click += new System.EventHandler(this.btn_kitap_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(96, 149);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 35);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Çıkış Yap ";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "---Yapılacak İşlemi Seçiniz---";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_kitap);
            this.Controls.Add(this.btn_Emanet);
            this.Controls.Add(this.btn_Uye);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Uye;
        private System.Windows.Forms.Button btn_Emanet;
        private System.Windows.Forms.Button btn_kitap;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
    }
}