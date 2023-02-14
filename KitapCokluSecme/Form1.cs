using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsComboBoxInceleme;

namespace WindowsFormsListBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBoxDoldurV1();
            listBoxDoldurV2();
        }

        private void listBoxDoldurV2()
        {
            lstUrunler.DisplayMember = "urunAdi";
            //lstUrunler.ValueMember = "id";
            lstUrunler.DataSource = dataBase.urunTablo;

        }

        void listBoxDoldurV1()
        {
            foreach (var item in dataBase.urunTablo)
            {
                lstUrunler.Items.Add(item);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = lstUrunler.SelectedItems.Count;

            if (urunSecimAdet == 1)
            {
                ListBox lbox = (ListBox)sender;
                Urun u1 = (Urun)lbox.SelectedItem;

                pctUrunResim.Image = Image.FromFile(u1.urunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

                txtUrunAdi.Text = u1.urunAdi;
                txtKategori.Text = u1.urunKategori;
                txtStokAdet.Text = u1.stokAdet.ToString();
                txtYazar.Text = u1.yazar;
                txtUrunAciklama.Text = u1.aciklama;
            }

            else if (urunSecimAdet > 1)
            {
                List<Urun> secilenUrunListe = new List<Urun>();

                foreach (var item in lstUrunler.SelectedItems)
                {
                    secilenUrunListe.Add(item as Urun);
                }

                UrunSecimKullanici secimKullanici = new UrunSecimKullanici(secilenUrunListe.ToArray());
                secimKullanici.ShowDialog();
            }

            else
            {
                MessageBox.Show("Lütfen detayını görmek istediğiniz ürünü seçiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtStokAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunAciklama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
