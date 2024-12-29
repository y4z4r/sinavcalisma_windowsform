namespace sinavcalisma
{
    partial class anaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            gb_obilgileri = new GroupBox();
            checkBox_kabulbeyani = new CheckBox();
            label_bilgi = new Label();
            textBox_ono = new TextBox();
            textBox_adsoy = new TextBox();
            label_ono = new Label();
            label_adsoy = new Label();
            Btn_soru1 = new Button();
            Btn_soru3 = new Button();
            Btn_soru2 = new Button();
            gb_obilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // gb_obilgileri
            // 
            gb_obilgileri.Controls.Add(checkBox_kabulbeyani);
            gb_obilgileri.Controls.Add(label_bilgi);
            gb_obilgileri.Controls.Add(textBox_ono);
            gb_obilgileri.Controls.Add(textBox_adsoy);
            gb_obilgileri.Controls.Add(label_ono);
            gb_obilgileri.Controls.Add(label_adsoy);
            resources.ApplyResources(gb_obilgileri, "gb_obilgileri");
            gb_obilgileri.Name = "gb_obilgileri";
            gb_obilgileri.TabStop = false;
            // 
            // checkBox_kabulbeyani
            // 
            resources.ApplyResources(checkBox_kabulbeyani, "checkBox_kabulbeyani");
            checkBox_kabulbeyani.Checked = true;
            checkBox_kabulbeyani.CheckState = CheckState.Checked;
            checkBox_kabulbeyani.Name = "checkBox_kabulbeyani";
            checkBox_kabulbeyani.UseVisualStyleBackColor = true;
            // 
            // label_bilgi
            // 
            resources.ApplyResources(label_bilgi, "label_bilgi");
            label_bilgi.Name = "label_bilgi";
            // 
            // textBox_ono
            // 
            resources.ApplyResources(textBox_ono, "textBox_ono");
            textBox_ono.Name = "textBox_ono";
            textBox_ono.TextChanged += textBox_ono_TextChanged;
            // 
            // textBox_adsoy
            // 
            resources.ApplyResources(textBox_adsoy, "textBox_adsoy");
            textBox_adsoy.Name = "textBox_adsoy";
            // 
            // label_ono
            // 
            resources.ApplyResources(label_ono, "label_ono");
            label_ono.Name = "label_ono";
            // 
            // label_adsoy
            // 
            resources.ApplyResources(label_adsoy, "label_adsoy");
            label_adsoy.Name = "label_adsoy";
            // 
            // Btn_soru1
            // 
            Btn_soru1.BackColor = SystemColors.ActiveBorder;
            resources.ApplyResources(Btn_soru1, "Btn_soru1");
            Btn_soru1.Name = "Btn_soru1";
            Btn_soru1.UseVisualStyleBackColor = false;
            Btn_soru1.Click += Btn_soru1_Click;
            // 
            // Btn_soru3
            // 
            Btn_soru3.BackColor = SystemColors.ActiveBorder;
            resources.ApplyResources(Btn_soru3, "Btn_soru3");
            Btn_soru3.Name = "Btn_soru3";
            Btn_soru3.UseVisualStyleBackColor = false;
            Btn_soru3.Click += Btn_soru3_Click;
            // 
            // Btn_soru2
            // 
            Btn_soru2.BackColor = SystemColors.ActiveBorder;
            resources.ApplyResources(Btn_soru2, "Btn_soru2");
            Btn_soru2.Name = "Btn_soru2";
            Btn_soru2.UseVisualStyleBackColor = false;
            Btn_soru2.Click += Btn_soru2_Click;
            // 
            // anaForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_soru2);
            Controls.Add(Btn_soru3);
            Controls.Add(Btn_soru1);
            Controls.Add(gb_obilgileri);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "anaForm";
            Load += Form1_Load;
            gb_obilgileri.ResumeLayout(false);
            gb_obilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_obilgileri;
        private Label label_adsoy;
        private Label label_bilgi;
        private TextBox textBox_adsoy;
        private Label label_ono;
        private CheckBox checkBox_kabulbeyani;
        private Button Btn_soru1;
        private Button Btn_soru3;
        private Button Btn_soru2;
        private TextBox textBox_ono;
    }
}
