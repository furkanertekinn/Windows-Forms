using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisUygulama
{
    public class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "Furkan",
                soyisim = "Ertekin",
                kullaniciAdi = "furkan.ertekin",
                sifre = "1",
                aciklama = "Furkan Ertekin Kullanıcı profil bilgisi",
            });

            KullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "Osman",
                soyisim = "Ertekin",
                kullaniciAdi = "osman.ertekin",
                sifre = "2",
                aciklama = "Osman Ertekin Kullanıcı profil bilgisi",
            });


        }



    }
}
