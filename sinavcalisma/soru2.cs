using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavcalisma
{
    public partial class soru2 : Form
    {
        public soru2()
        {
            InitializeComponent();
        }

        int ayran = 20;
        int baklava = 50;
        int ham = 100;
        int kola = 30;
        int pizza = 80;
        int su = 10;
        int sutlac = 40;
        int tiramisu = 50;
        int tost = 30;
        int toplam;
        string sip;
        private void Btn_fiyat_Click(object sender, EventArgs e)
        {
            checkBox_ayran.Enabled = true;
            checkBox_baklava.Enabled = true;
            checkBox_ham.Enabled = true;
            checkBox_kola.Enabled = true;
            checkBox_pizza.Enabled = true;
            checkBox_su.Enabled = true;
            checkBox_sutlac.Enabled = true;
            checkBox_tiramisu.Enabled = true;
            checkBox_tost.Enabled = true;

            Btn_siparisolustur.Enabled = true;

            label_ayran.Enabled = true;
            label_baklava.Enabled = true;
            label_ham.Enabled = true;
            label_kola.Enabled = true;
            label_pizza.Enabled = true;
            label_su.Enabled = true;
            label_sutlac.Enabled = true;
            label_tiramisu.Enabled = true;
            label_tost.Enabled = true;

            label_ayran.Text = ayran + " TL";
            label_baklava.Text = baklava + " TL";
            label_ham.Text = ham + " TL";
            label_kola.Text = kola + " TL";
            label_pizza.Text = pizza + " TL";
            label_su.Text = su + " TL";
            label_sutlac.Text = sutlac + " TL";
            label_tiramisu.Text = tiramisu + " TL";
            label_tost.Text = tost + " Tl";
        }

        private void Btn_siparisolustur_Click(object sender, EventArgs e)
        {
            toplam = 0;
            sip = null;

            if (checkBox_ayran.Checked ==true)
            {
                toplam = toplam + ayran;
                sip = sip + " Ayran,";
            }
            if (checkBox_baklava.Checked ==true)
            {
                toplam = toplam + baklava;
                sip = sip + " Baklava,";
            }
            if (checkBox_ham.Checked ==true)
            {
                toplam = toplam + ham;
                sip = sip + " Hamburger,";
            }
            if (checkBox_kola.Checked ==true)
            {
                toplam = toplam + kola;
                sip = sip + " Kola,";            
            }
            if (checkBox_pizza.Checked ==true)
            {
                toplam = toplam + pizza;
                sip = sip + " Pizza,";
            }
            if (checkBox_su.Checked == true)
            {
                toplam = toplam + su;
                sip = sip + " Su,";
            }
            if (checkBox_sutlac.Checked == true)
            {
                toplam = toplam + sutlac;
                sip = sip + " Sütlaç,";
            }
            if (checkBox_tiramisu.Checked == true)
            {
                toplam = toplam + tiramisu;
                sip = sip + " Tiramisu,";
            }
            if (checkBox_tost.Checked == true)
            {
                toplam = toplam + tost;
                sip = sip + " Tost,";
            }
            sip = sip.Remove(sip.Length - 1);
            sip = sip.Remove(0, 1);
            rText_sip.Text = "Sipariş Özeti:\n" + "\n" + sip + " sipariş edildi." + "\n" + "\n" + toplam + " TL";
            

        }
    }
}
