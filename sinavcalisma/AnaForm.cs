namespace sinavcalisma
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void textBox_ono_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_ono.Text, out _) && textBox_ono.Text != "")
            {
                MessageBox.Show("Lütfen sadece sayý girin.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ono.Text = new string(textBox_ono.Text.Where(char.IsDigit).ToArray());
                textBox_ono.SelectionStart = textBox_ono.Text.Length;
            }
        }

        private void Btn_soru1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_adsoy.Text) || string.IsNullOrWhiteSpace(textBox_ono.Text))
            {
                MessageBox.Show("Lütfen Gerekli Kutucuklarý Doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                soru1 soru1 = new soru1();
                soru1.Show();
                this.Hide();
                soru1.FormClosed += (s, args) => this.Show();
                soru1.Show();
            }
        }
        private void Btn_soru2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_adsoy.Text) || string.IsNullOrWhiteSpace(textBox_ono.Text))
            {
                MessageBox.Show("Lütfen Gerekli Kutucuklarý Doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                soru2 soru2 = new soru2();
                soru2.Show();
                this.Hide();
                soru2.groupBox_cafe.Text ="Cafe " + textBox_ono.Text;
                soru2.FormClosed += (s, args) => this.Show();
                soru2.Show();
            }
        }
        private void Btn_soru3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_adsoy.Text) || string.IsNullOrWhiteSpace(textBox_ono.Text))
            {
                MessageBox.Show("Lütfen Gerekli Kutucuklarý Doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                soru3 soru3 = new soru3();
                soru3.Show();
                this.Hide();
                soru3.FormClosed += (s, args) => this.Show();
                soru3.Show();
            }
        }
    }
}
