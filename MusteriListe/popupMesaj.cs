using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFakeDataveGridView
{
    public partial class popupMesaj : Form
    {
        Musteri musteriData;
        public popupMesaj(Musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupMesaj_Load(object sender, EventArgs e)
        {
            txtIsim.Text = musteriData.isim;
            txtSoyisim.Text = musteriData.soyisim;
            txtTamAd.Text = musteriData.tamAdi;

            txtEmail.Text = musteriData.emailAdress;
            txtTelefon.Text = musteriData.telefonNo;
            txtIlilce.Text = $"{musteriData.il} / {musteriData.ilce}";
            txtAdres.Text = musteriData.adres; 
        }
    }
}
