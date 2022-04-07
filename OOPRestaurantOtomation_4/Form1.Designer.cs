
namespace OOPRestaurantOtomation_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menüler";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(12, 113);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(314, 26);
            this.cmbMenuler.TabIndex = 1;
            this.cmbMenuler.SelectedIndexChanged += new System.EventHandler(this.cmbMenuler_SelectedIndexChanged);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(16, 22);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(123, 24);
            this.txtIsim.TabIndex = 2;
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.Location = new System.Drawing.Point(16, 186);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(95, 22);
            this.rdbBuyuk.TabIndex = 3;
            this.rdbBuyuk.Text = "Büyük boy";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.Location = new System.Drawing.Point(16, 251);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(83, 22);
            this.rdbOrta.TabIndex = 3;
            this.rdbOrta.Text = "Orta boy";
            this.rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.Checked = true;
            this.rdbKucuk.Location = new System.Drawing.Point(16, 317);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(96, 22);
            this.rdbKucuk.TabIndex = 3;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Kücük boy";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(355, 156);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(98, 22);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Tag = "1.80";
            this.checkBox9.Text = "Ballı hardal";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(192, 156);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(70, 22);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Tag = "1.20";
            this.checkBox6.Text = "Ranch";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(22, 156);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(70, 22);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "0.75";
            this.checkBox3.Text = "Hardal";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(355, 105);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(117, 22);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Tag = "2.50";
            this.checkBox8.Text = "Sarımsaklı m.";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(192, 105);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(82, 22);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "0.80";
            this.checkBox5.Text = "Barbekü";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 22);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "0.50";
            this.checkBox2.Text = "Mayonez";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(355, 55);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(73, 22);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Tag = "1.50";
            this.checkBox7.Text = "Buffalo";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(192, 55);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 22);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "0.60";
            this.checkBox4.Text = "Acısos";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0.50";
            this.checkBox1.Text = "Ketcap";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblAciklama
            // 
            this.lblAciklama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAciklama.Location = new System.Drawing.Point(13, 609);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(487, 168);
            this.lblAciklama.TabIndex = 5;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(292, 49);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(63, 24);
            this.nmrAdet.TabIndex = 6;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adet";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 18;
            this.lstSiparisler.Location = new System.Drawing.Point(527, 22);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(902, 346);
            this.lstSiparisler.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(545, 394);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 33);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(1271, 404);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(142, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1441, 786);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbKucuk);
            this.Controls.Add(this.rdbOrta);
            this.Controls.Add(this.rdbBuyuk);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.RadioButton rdbBuyuk;
        private System.Windows.Forms.RadioButton rdbOrta;
        private System.Windows.Forms.RadioButton rdbKucuk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
    }
}

