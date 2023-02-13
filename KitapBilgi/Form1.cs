using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsComboBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //items.Add metotu kullanılarak değerler ComboBox a eklendi
            //comboBoxDoldurV1();

            comboBoxDoldurV2();
        }

        void comboBoxDoldurV2()
        {
            cmbUrunListe.DataSource = dataBase.urunTablo;
        }

        void comboBoxDoldurV1()
        {
            foreach (var item in dataBase.urunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o1 = cmbUrunListe.SelectedItem;
            urun u1 = (urun)o1;

            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = u1.urunAdi;
            txtKategori.Text = u1.urunKategori;
            txtStokAdet.Text = u1.stokAdet.ToString();
            txtYazar.Text = u1.yazar;
            txtUrunAciklama.Text = u1.aciklama;

        }
    }
}
