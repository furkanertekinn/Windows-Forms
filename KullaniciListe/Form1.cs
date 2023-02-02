using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxUygulama
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

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int islemSonuc = yeniMusteriEkle(new Musteri()
            {
                id = Guid.NewGuid(),
                isim = txtIsim.Text,
                soyisim = txtSoyisim.Text,
                emailAdres = txtEmailAdres.Text,
                telefonNumarasi = txtTelefonNo.Text,
            });

            if (islemSonuc > 0)
            {
                DialogResult res = MessageBox.Show("Müşteri ekleme işlemi başarılı , yeni müşteri kaydı eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam müşteri kayıt adedi" + SanalDataBase.musteriler.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Müşteri adet bilgisi ";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                }
                else if (res == DialogResult.No)
                {

                }

                ekranTemizle();
                ekranListele();
            }
            else
            {
                MessageBox.Show("Hata : Kayıt yenileme işlemi yapılamadı.");
            }
        }

        private void ekranListele()
        {
            lstMusteriler.DataSource = SanalDataBase.musteriler;
        }

        private void ekranTemizle()
        {
            txtIsim.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
            txtEmailAdres.Text = string.Empty;
            txtTelefonNo.Text = string.Empty;
        }

        private int yeniMusteriEkle(Musteri data)
        {
            SanalDataBase.musteriler.Add(data);
            return 1;
        }
    }
}
