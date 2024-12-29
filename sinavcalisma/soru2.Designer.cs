namespace sinavcalisma
{
    partial class soru2
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
            Btn_fiyat = new Button();
            groupBox_cafe = new GroupBox();
            rText_sip = new RichTextBox();
            Btn_siparisolustur = new Button();
            groupBox_tatlilar = new GroupBox();
            label_sutlac = new Label();
            label_baklava = new Label();
            label_tiramisu = new Label();
            checkBox_sutlac = new CheckBox();
            checkBox_baklava = new CheckBox();
            checkBox_tiramisu = new CheckBox();
            groupBox_icecekler = new GroupBox();
            label_su = new Label();
            label_ayran = new Label();
            label_kola = new Label();
            checkBox_su = new CheckBox();
            checkBox_ayran = new CheckBox();
            checkBox_kola = new CheckBox();
            groupBox_yiyecekler = new GroupBox();
            label_pizza = new Label();
            label_ham = new Label();
            label_tost = new Label();
            checkBox_pizza = new CheckBox();
            checkBox_ham = new CheckBox();
            checkBox_tost = new CheckBox();
            groupBox_cafe.SuspendLayout();
            groupBox_tatlilar.SuspendLayout();
            groupBox_icecekler.SuspendLayout();
            groupBox_yiyecekler.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_fiyat
            // 
            Btn_fiyat.Location = new Point(12, 12);
            Btn_fiyat.Name = "Btn_fiyat";
            Btn_fiyat.Size = new Size(360, 23);
            Btn_fiyat.TabIndex = 0;
            Btn_fiyat.Text = "Fiyat Belirle";
            Btn_fiyat.UseVisualStyleBackColor = true;
            Btn_fiyat.Click += Btn_fiyat_Click;
            // 
            // groupBox_cafe
            // 
            groupBox_cafe.Controls.Add(rText_sip);
            groupBox_cafe.Controls.Add(Btn_siparisolustur);
            groupBox_cafe.Controls.Add(groupBox_tatlilar);
            groupBox_cafe.Controls.Add(groupBox_icecekler);
            groupBox_cafe.Controls.Add(groupBox_yiyecekler);
            groupBox_cafe.Location = new Point(12, 41);
            groupBox_cafe.Name = "groupBox_cafe";
            groupBox_cafe.Size = new Size(360, 508);
            groupBox_cafe.TabIndex = 1;
            groupBox_cafe.TabStop = false;
            groupBox_cafe.Text = "Cafe";
            // 
            // rText_sip
            // 
            rText_sip.Enabled = false;
            rText_sip.Location = new Point(6, 367);
            rText_sip.Name = "rText_sip";
            rText_sip.Size = new Size(348, 135);
            rText_sip.TabIndex = 4;
            rText_sip.Text = "Sipariş Özeti:\n\n...sipariş edildi.\n\nToplam Tutar 0 TL";
            // 
            // Btn_siparisolustur
            // 
            Btn_siparisolustur.Enabled = false;
            Btn_siparisolustur.Location = new Point(6, 338);
            Btn_siparisolustur.Name = "Btn_siparisolustur";
            Btn_siparisolustur.Size = new Size(348, 23);
            Btn_siparisolustur.TabIndex = 3;
            Btn_siparisolustur.Text = "Sipariş Oluştur";
            Btn_siparisolustur.UseVisualStyleBackColor = true;
            Btn_siparisolustur.Click += Btn_siparisolustur_Click;
            // 
            // groupBox_tatlilar
            // 
            groupBox_tatlilar.Controls.Add(label_sutlac);
            groupBox_tatlilar.Controls.Add(label_baklava);
            groupBox_tatlilar.Controls.Add(label_tiramisu);
            groupBox_tatlilar.Controls.Add(checkBox_sutlac);
            groupBox_tatlilar.Controls.Add(checkBox_baklava);
            groupBox_tatlilar.Controls.Add(checkBox_tiramisu);
            groupBox_tatlilar.Location = new Point(6, 232);
            groupBox_tatlilar.Name = "groupBox_tatlilar";
            groupBox_tatlilar.Size = new Size(350, 100);
            groupBox_tatlilar.TabIndex = 2;
            groupBox_tatlilar.TabStop = false;
            groupBox_tatlilar.Text = "Tatlılar";
            // 
            // label_sutlac
            // 
            label_sutlac.AutoSize = true;
            label_sutlac.Enabled = false;
            label_sutlac.Location = new Point(267, 73);
            label_sutlac.Name = "label_sutlac";
            label_sutlac.Size = new Size(28, 15);
            label_sutlac.TabIndex = 11;
            label_sutlac.Text = "0 TL";
            // 
            // label_baklava
            // 
            label_baklava.AutoSize = true;
            label_baklava.Enabled = false;
            label_baklava.Location = new Point(267, 48);
            label_baklava.Name = "label_baklava";
            label_baklava.Size = new Size(28, 15);
            label_baklava.TabIndex = 10;
            label_baklava.Text = "0 TL";
            // 
            // label_tiramisu
            // 
            label_tiramisu.AutoSize = true;
            label_tiramisu.Enabled = false;
            label_tiramisu.Location = new Point(267, 23);
            label_tiramisu.Name = "label_tiramisu";
            label_tiramisu.Size = new Size(28, 15);
            label_tiramisu.TabIndex = 9;
            label_tiramisu.Text = "0 TL";
            // 
            // checkBox_sutlac
            // 
            checkBox_sutlac.AutoSize = true;
            checkBox_sutlac.Enabled = false;
            checkBox_sutlac.Location = new Point(6, 72);
            checkBox_sutlac.Name = "checkBox_sutlac";
            checkBox_sutlac.Size = new Size(58, 19);
            checkBox_sutlac.TabIndex = 2;
            checkBox_sutlac.Text = "Sütlaç";
            checkBox_sutlac.UseVisualStyleBackColor = true;
            // 
            // checkBox_baklava
            // 
            checkBox_baklava.AutoSize = true;
            checkBox_baklava.Enabled = false;
            checkBox_baklava.Location = new Point(6, 47);
            checkBox_baklava.Name = "checkBox_baklava";
            checkBox_baklava.Size = new Size(66, 19);
            checkBox_baklava.TabIndex = 1;
            checkBox_baklava.Text = "Baklava";
            checkBox_baklava.UseVisualStyleBackColor = true;
            // 
            // checkBox_tiramisu
            // 
            checkBox_tiramisu.AutoSize = true;
            checkBox_tiramisu.Enabled = false;
            checkBox_tiramisu.Location = new Point(6, 22);
            checkBox_tiramisu.Name = "checkBox_tiramisu";
            checkBox_tiramisu.Size = new Size(71, 19);
            checkBox_tiramisu.TabIndex = 0;
            checkBox_tiramisu.Text = "Tiramisu";
            checkBox_tiramisu.UseVisualStyleBackColor = true;
            // 
            // groupBox_icecekler
            // 
            groupBox_icecekler.Controls.Add(label_su);
            groupBox_icecekler.Controls.Add(label_ayran);
            groupBox_icecekler.Controls.Add(label_kola);
            groupBox_icecekler.Controls.Add(checkBox_su);
            groupBox_icecekler.Controls.Add(checkBox_ayran);
            groupBox_icecekler.Controls.Add(checkBox_kola);
            groupBox_icecekler.Location = new Point(4, 126);
            groupBox_icecekler.Name = "groupBox_icecekler";
            groupBox_icecekler.Size = new Size(350, 100);
            groupBox_icecekler.TabIndex = 1;
            groupBox_icecekler.TabStop = false;
            groupBox_icecekler.Text = "İçecekler";
            // 
            // label_su
            // 
            label_su.AutoSize = true;
            label_su.Enabled = false;
            label_su.Location = new Point(269, 73);
            label_su.Name = "label_su";
            label_su.Size = new Size(28, 15);
            label_su.TabIndex = 8;
            label_su.Text = "0 TL";
            // 
            // label_ayran
            // 
            label_ayran.AutoSize = true;
            label_ayran.Enabled = false;
            label_ayran.Location = new Point(269, 48);
            label_ayran.Name = "label_ayran";
            label_ayran.Size = new Size(28, 15);
            label_ayran.TabIndex = 7;
            label_ayran.Text = "0 TL";
            // 
            // label_kola
            // 
            label_kola.AutoSize = true;
            label_kola.Enabled = false;
            label_kola.Location = new Point(269, 23);
            label_kola.Name = "label_kola";
            label_kola.Size = new Size(28, 15);
            label_kola.TabIndex = 6;
            label_kola.Text = "0 TL";
            // 
            // checkBox_su
            // 
            checkBox_su.AutoSize = true;
            checkBox_su.Enabled = false;
            checkBox_su.Location = new Point(6, 72);
            checkBox_su.Name = "checkBox_su";
            checkBox_su.Size = new Size(39, 19);
            checkBox_su.TabIndex = 2;
            checkBox_su.Text = "Su";
            checkBox_su.UseVisualStyleBackColor = true;
            // 
            // checkBox_ayran
            // 
            checkBox_ayran.AutoSize = true;
            checkBox_ayran.Enabled = false;
            checkBox_ayran.Location = new Point(6, 47);
            checkBox_ayran.Name = "checkBox_ayran";
            checkBox_ayran.Size = new Size(57, 19);
            checkBox_ayran.TabIndex = 1;
            checkBox_ayran.Text = "Ayran";
            checkBox_ayran.UseVisualStyleBackColor = true;
            // 
            // checkBox_kola
            // 
            checkBox_kola.AutoSize = true;
            checkBox_kola.Enabled = false;
            checkBox_kola.Location = new Point(6, 22);
            checkBox_kola.Name = "checkBox_kola";
            checkBox_kola.Size = new Size(49, 19);
            checkBox_kola.TabIndex = 0;
            checkBox_kola.Text = "Kola";
            checkBox_kola.UseVisualStyleBackColor = true;
            // 
            // groupBox_yiyecekler
            // 
            groupBox_yiyecekler.Controls.Add(label_pizza);
            groupBox_yiyecekler.Controls.Add(label_ham);
            groupBox_yiyecekler.Controls.Add(label_tost);
            groupBox_yiyecekler.Controls.Add(checkBox_pizza);
            groupBox_yiyecekler.Controls.Add(checkBox_ham);
            groupBox_yiyecekler.Controls.Add(checkBox_tost);
            groupBox_yiyecekler.Location = new Point(6, 22);
            groupBox_yiyecekler.Name = "groupBox_yiyecekler";
            groupBox_yiyecekler.Size = new Size(350, 100);
            groupBox_yiyecekler.TabIndex = 0;
            groupBox_yiyecekler.TabStop = false;
            groupBox_yiyecekler.Text = "Yiyecekler";
            // 
            // label_pizza
            // 
            label_pizza.AutoSize = true;
            label_pizza.Enabled = false;
            label_pizza.Location = new Point(267, 71);
            label_pizza.Name = "label_pizza";
            label_pizza.Size = new Size(28, 15);
            label_pizza.TabIndex = 5;
            label_pizza.Text = "0 TL";
            // 
            // label_ham
            // 
            label_ham.AutoSize = true;
            label_ham.Enabled = false;
            label_ham.Location = new Point(267, 46);
            label_ham.Name = "label_ham";
            label_ham.Size = new Size(28, 15);
            label_ham.TabIndex = 4;
            label_ham.Text = "0 TL";
            // 
            // label_tost
            // 
            label_tost.AutoSize = true;
            label_tost.Enabled = false;
            label_tost.Location = new Point(267, 23);
            label_tost.Name = "label_tost";
            label_tost.Size = new Size(28, 15);
            label_tost.TabIndex = 3;
            label_tost.Text = "0 TL";
            // 
            // checkBox_pizza
            // 
            checkBox_pizza.AutoSize = true;
            checkBox_pizza.Enabled = false;
            checkBox_pizza.Location = new Point(6, 70);
            checkBox_pizza.Name = "checkBox_pizza";
            checkBox_pizza.Size = new Size(52, 19);
            checkBox_pizza.TabIndex = 2;
            checkBox_pizza.Text = "Pizza";
            checkBox_pizza.UseVisualStyleBackColor = true;
            // 
            // checkBox_ham
            // 
            checkBox_ham.AutoSize = true;
            checkBox_ham.Enabled = false;
            checkBox_ham.Location = new Point(6, 45);
            checkBox_ham.Name = "checkBox_ham";
            checkBox_ham.Size = new Size(87, 19);
            checkBox_ham.TabIndex = 1;
            checkBox_ham.Text = "Hamburger";
            checkBox_ham.UseVisualStyleBackColor = true;
            // 
            // checkBox_tost
            // 
            checkBox_tost.AutoSize = true;
            checkBox_tost.Enabled = false;
            checkBox_tost.Location = new Point(6, 22);
            checkBox_tost.Name = "checkBox_tost";
            checkBox_tost.Size = new Size(47, 19);
            checkBox_tost.TabIndex = 0;
            checkBox_tost.Text = "Tost";
            checkBox_tost.UseVisualStyleBackColor = true;
            // 
            // soru2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(384, 561);
            Controls.Add(groupBox_cafe);
            Controls.Add(Btn_fiyat);
            MaximizeBox = false;
            Name = "soru2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ostim Teknik Üniversitesi - MYO - BGP205 - 2023-2024 Güz Dönemi - Ara Sınav (17.11.2023)";
            groupBox_cafe.ResumeLayout(false);
            groupBox_tatlilar.ResumeLayout(false);
            groupBox_tatlilar.PerformLayout();
            groupBox_icecekler.ResumeLayout(false);
            groupBox_icecekler.PerformLayout();
            groupBox_yiyecekler.ResumeLayout(false);
            groupBox_yiyecekler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_fiyat;
        private GroupBox groupBox_tatlilar;
        private GroupBox groupBox_icecekler;
        private CheckBox checkBox_ayran;
        private CheckBox checkBox_kola;
        private GroupBox groupBox_yiyecekler;
        private CheckBox checkBox_pizza;
        private CheckBox checkBox_ham;
        private CheckBox checkBox_tost;
        private RichTextBox rText_sip;
        private Button Btn_siparisolustur;
        private CheckBox checkBox_sutlac;
        private CheckBox checkBox_baklava;
        private CheckBox checkBox_tiramisu;
        private CheckBox checkBox_su;
        internal GroupBox groupBox_cafe;
        private Label label_sutlac;
        private Label label_baklava;
        private Label label_tiramisu;
        private Label label_su;
        private Label label_ayran;
        private Label label_kola;
        private Label label_pizza;
        private Label label_ham;
        private Label label_tost;
    }
}