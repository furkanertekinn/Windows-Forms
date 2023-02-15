using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFakeDataveGridView
{
    public class dataBase
    {
        public List<Musteri> musteriler = new List<Musteri>();
        public dataBase()
        {

        }

        public List<Musteri> musteriListele()
        {
            for (int i = 0; i < 1000; i++)
            {
                Musteri Temp = new Musteri();
                Temp.id = 1000 + i;
                Temp.isim = FakeData.NameData.GetFirstName();
                Temp.soyisim = FakeData.NameData.GetSurname();
                Temp.tamAdi = $"{Temp.isim} {Temp.soyisim}";
                Temp.emailAdress = FakeData.NetworkData.GetEmail(Temp.isim, Temp.soyisim);
                Temp.telefonNo = FakeData.PhoneNumberData.GetPhoneNumber();
                Temp.il = FakeData.PlaceData.GetCity();
                Temp.ilce = FakeData.PlaceData.GetCountry();
                Temp.adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(Temp);
            }
            return musteriler;
        }
    }
}
