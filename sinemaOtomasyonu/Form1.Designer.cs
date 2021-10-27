
namespace sinemaOtomasyonu
{
    partial class Form1
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
            this.txtkoltukSayı = new System.Windows.Forms.TextBox();
            this.lblBosKoltuk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpRapor = new System.Windows.Forms.GroupBox();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.btnBosKlt = new System.Windows.Forms.Button();
            this.grpSatisİptl = new System.Windows.Forms.GroupBox();
            this.btnBilİplt = new System.Windows.Forms.Button();
            this.btnBilSat = new System.Windows.Forms.Button();
            this.chbxindirim = new System.Windows.Forms.CheckBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.grpRapor.SuspendLayout();
            this.grpSatisİptl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkoltukSayı
            // 
            this.txtkoltukSayı.Location = new System.Drawing.Point(198, 83);
            this.txtkoltukSayı.Name = "txtkoltukSayı";
            this.txtkoltukSayı.Size = new System.Drawing.Size(121, 22);
            this.txtkoltukSayı.TabIndex = 17;
            // 
            // lblBosKoltuk
            // 
            this.lblBosKoltuk.AutoSize = true;
            this.lblBosKoltuk.Location = new System.Drawing.Point(209, 379);
            this.lblBosKoltuk.Name = "lblBosKoltuk";
            this.lblBosKoltuk.Size = new System.Drawing.Size(68, 17);
            this.lblBosKoltuk.TabIndex = 15;
            this.lblBosKoltuk.Text = "...............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Boş Koltuk Sayısı:";
            // 
            // grpRapor
            // 
            this.grpRapor.Controls.Add(this.btnBakiye);
            this.grpRapor.Controls.Add(this.btnBosKlt);
            this.grpRapor.Location = new System.Drawing.Point(376, 165);
            this.grpRapor.Name = "grpRapor";
            this.grpRapor.Size = new System.Drawing.Size(242, 158);
            this.grpRapor.TabIndex = 13;
            this.grpRapor.TabStop = false;
            this.grpRapor.Text = "Rapor";
            // 
            // btnBakiye
            // 
            this.btnBakiye.Location = new System.Drawing.Point(30, 95);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(75, 42);
            this.btnBakiye.TabIndex = 1;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // btnBosKlt
            // 
            this.btnBosKlt.Location = new System.Drawing.Point(141, 95);
            this.btnBosKlt.Name = "btnBosKlt";
            this.btnBosKlt.Size = new System.Drawing.Size(75, 42);
            this.btnBosKlt.TabIndex = 0;
            this.btnBosKlt.Text = "Boş Koltuk";
            this.btnBosKlt.UseVisualStyleBackColor = true;
            this.btnBosKlt.Click += new System.EventHandler(this.btnBosKlt_Click);
            // 
            // grpSatisİptl
            // 
            this.grpSatisİptl.Controls.Add(this.btnBilİplt);
            this.grpSatisİptl.Controls.Add(this.btnBilSat);
            this.grpSatisİptl.Controls.Add(this.chbxindirim);
            this.grpSatisİptl.Location = new System.Drawing.Point(63, 165);
            this.grpSatisİptl.Name = "grpSatisİptl";
            this.grpSatisİptl.Size = new System.Drawing.Size(235, 158);
            this.grpSatisİptl.TabIndex = 12;
            this.grpSatisİptl.TabStop = false;
            this.grpSatisİptl.Text = "Satış İptali";
            // 
            // btnBilİplt
            // 
            this.btnBilİplt.Location = new System.Drawing.Point(119, 95);
            this.btnBilİplt.Name = "btnBilİplt";
            this.btnBilİplt.Size = new System.Drawing.Size(75, 42);
            this.btnBilİplt.TabIndex = 2;
            this.btnBilİplt.Text = "Bilet İptal";
            this.btnBilİplt.UseVisualStyleBackColor = true;
            this.btnBilİplt.Click += new System.EventHandler(this.btnBilİplt_Click);
            // 
            // btnBilSat
            // 
            this.btnBilSat.Location = new System.Drawing.Point(7, 95);
            this.btnBilSat.Name = "btnBilSat";
            this.btnBilSat.Size = new System.Drawing.Size(75, 42);
            this.btnBilSat.TabIndex = 1;
            this.btnBilSat.Text = "Bilet Sat";
            this.btnBilSat.UseVisualStyleBackColor = true;
            this.btnBilSat.Click += new System.EventHandler(this.btnBilSat_Click);
            // 
            // chbxindirim
            // 
            this.chbxindirim.AutoSize = true;
            this.chbxindirim.Location = new System.Drawing.Point(7, 31);
            this.chbxindirim.Name = "chbxindirim";
            this.chbxindirim.Size = new System.Drawing.Size(77, 21);
            this.chbxindirim.TabIndex = 0;
            this.chbxindirim.Text = "İndirimli";
            this.chbxindirim.UseVisualStyleBackColor = true;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(376, 38);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(182, 72);
            this.btnOlustur.TabIndex = 11;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Koltuk Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Salon:";
            // 
            // cmbSalon
            // 
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(198, 35);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(121, 24);
            this.cmbSalon.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.txtkoltukSayı);
            this.Controls.Add(this.lblBosKoltuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpRapor);
            this.Controls.Add(this.grpSatisİptl);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRapor.ResumeLayout(false);
            this.grpSatisİptl.ResumeLayout(false);
            this.grpSatisİptl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkoltukSayı;
        private System.Windows.Forms.Label lblBosKoltuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRapor;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Button btnBosKlt;
        private System.Windows.Forms.GroupBox grpSatisİptl;
        private System.Windows.Forms.Button btnBilİplt;
        private System.Windows.Forms.Button btnBilSat;
        private System.Windows.Forms.CheckBox chbxindirim;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSalon;
    }
}

