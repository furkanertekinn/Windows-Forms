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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataBase db = new dataBase();
            List<Musteri> musteriListe = db.musteriListele();

            // 1. Data bize lazım ama ekran üzerinde göstermek istemiyoruz. Bu gibi durumlarda Colums koleksiyonu içerisinde ilgili kolanun id değeri
            // veya tip property adı verilerek Visible prop. false edilmesi yeterlidir.

            dgwMusteriListe.DataSource = musteriListe;
            //dgwMusteriListe.Columns[0].Visible = false;
            dgwMusteriListe.Columns["id"].Visible = true;

            // Data Grid View içerisinde bulunan kolonların isimlerini değiştirmek...

            dgwMusteriListe.Columns[0].HeaderText = "Müşteri ID";
            dgwMusteriListe.Columns[1].HeaderText = "Müşteri İsim";
            dgwMusteriListe.Columns[2].HeaderText = "Müşteri Soyisim";
            dgwMusteriListe.Columns[2].Width = 350;
            dgwMusteriListe.Columns[3].HeaderText = "Müşteri Tam Adı";

            // 2. Data bize lazım değil. Hiç bir şekilde ekranda görünmesini veya kullanmak istemiyoruz.

            //var dgwListe = from I in musteriListe
            //               select new
            //               {
            //                   isim = I.isim,
            //                   soyisim = I.soyisim,
            //                   tamAdi = I.tamAdi,

            //               };
            //dgwMusteriListe.DataSource = dgwListe.ToList();
        }

        private void dgwMusteriListe_DoubleClick(object sender, EventArgs e)
        {
            int musteriID = (int)dgwMusteriListe[0, dgwMusteriListe.CurrentCell.RowIndex].Value;

            dataBase db = new dataBase();
            Musteri bulunanMusteri = db.musteriListele().FindAll(i => i.id == musteriID).FirstOrDefault();

            popupMesaj popup = new popupMesaj(bulunanMusteri);
            popup.Show();
        }
    }
}
