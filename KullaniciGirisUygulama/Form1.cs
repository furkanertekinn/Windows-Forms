using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            kullanici bulunanKullanici = sanalDatabase.KullaniciTablo.Find(i => i.kullaniciAdi == kullaniciAdi && i.sifre == sifre);

            // kullaniciAdi == "admin " && sifre == "123"

            if (bulunanKullanici != null)
            {
                anaForm anaForm1 = new anaForm(bulunanKullanici);
                anaForm1.Show();
            }

            else
            {
                // windows form içerisinde nasıl kullanıcıya bir popun gösteririz bunu çok ufak bir şekilde inceleyelim.
                // ayrı bir konu olarak eğitim içinde bulacaksınız.

                MessageBox.Show("Hatalı kullanıcı bilgileri", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {

            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}
