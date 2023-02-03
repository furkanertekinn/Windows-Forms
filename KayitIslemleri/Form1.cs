using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsKontrolerInceleme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show("Form üzeinde ki alanları temizlemek istediğinize emin misiniz ?", "Form Temizleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultEnum == DialogResult.Yes)
            {
                //formTemizle();
                formElamanIndexTemizle();
            }
            else
            {
                // işlem iptal edildi.
            }
        }

        private void formElamanIndexTemizle()
        {
            ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
            ((TextBox)this.Controls["txtTelefonNo"]).Text = string.Empty;
        }


        private void formTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) // item control == TextBox
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int sonuc = musteriEkle(new musteri()
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                emailAdres = txtEmailAdres.Text,
                telefonNumarasi = txtTelefonNo.Text,
            });

            if (sonuc > 0)
            {
                DialogResult ress = MessageBox.Show("Kayıt başarılı, yeni kayıt ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ress == DialogResult.Yes)
                {

                }
                else if (ress == DialogResult.No)
                {

                }
            }

            else
            {
                MessageBox.Show("Hatalı kayıt , işlem tamamlanamadı!");
            }

            formTemizle();
        }

        private int musteriEkle(musteri data)
        {
            SanalDataBase.musteriler.Add(data);
            return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOnizlemeKayit onIzlemeKayit = new frmOnizlemeKayit();
            ((TextBox)onIzlemeKayit.Controls["txtIsim"]).Text = txtIsim.Text;
            ((TextBox)onIzlemeKayit.Controls["txtSoyisim"]).Text = txtSoyisim.Text;
            ((TextBox)onIzlemeKayit.Controls["txtEmailAdres"]).Text = txtEmailAdres.Text;
            ((TextBox)onIzlemeKayit.Controls["txtTelefonNo"]).Text = txtTelefonNo.Text;
            onIzlemeKayit.ShowDialog();
        }
    }
}
