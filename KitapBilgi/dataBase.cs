using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsComboBoxInceleme
{
    public static class dataBase
    {
        public static List<urun> urunTablo = new List<urun>()
        {
            new urun(){id=1, urunAdi="Bir Ömür Nasıl Yaşanır?", stokAdet=20, urunKategori="Roman", aciklama=@"Cesur olun. Kendinizi rahat hissettiğiniz alanın dışında pencereler açın. Farklı dünyalarla ancak böyle tanışırsınız. Ben hep yerimde dursaydım, dünyamı değiştirecek insanları aramasaydım, bugün tanıdığınız ben olmazdım. Bir insanın bittiği an, miskinliğe esir olduğu andır. İnsan, konforundan vazgeçmeyi göze almalıdır. Kendi dünyasını yerinden kendisi oynatmalıdır.", yazar="İlber Ortaylı", urunResim=@"C:\resimWindowsForms\1.jpg.jpg"},
            new urun(){id=2, urunAdi="Metastaz", stokAdet=18, urunKategori="Roman", aciklama=@"Menzilci polisler ilk kez göreceğiniz fotoğraflarında ne yapıyordu?
AKP’li Bakan’ın tarikat şeyhinden özel ricası neydi?
Devlette FETÖ’den boşalan koltuklara hangi tarikat nasıl yerleşti?
Nedir bu hüsnü şehadet ve FETÖ borsası?
Hangi cemaat kim için Cumhurbaşkanı’na mektup yazarak kefil oldu?
Genelkurmay Başkanı’nın “sahip çıkın” dediği isimler neden tutuklandı?
“Kurda kuşa yem etmeyin” denilen işadamı nasıl hapisten çıktı?
FETÖ operasyonlarından çıkarılan ""imtiyazlı ortaklar"" kim?
Hâkim rüşvet alırken gizli bir operasyonla nasıl yakalandı?
Hangi gazeteci kendisini MİT’çi diye tanıtıp dolandırıcılık yaptı?
Çektirdiği fotoğrafları davaları etkilemek için kullanan ismin
arkasında kimler var?
FETÖ operasyonu yapan savcının odasını AKP’liler mi bastı?
Erdoğan'ın tehdit edildiği toplantıdan yara almadan çıkan ünlüler kim?
Üstü kapatılan telefon görüşmelerinde neler konuşuldu?
", yazar="Barış Pehlivan Ve Barış Terkoğlu", urunResim=@"C:\resimWindowsForms\2.jpg.jpg"},
            new urun(){ id=3, urunAdi="Şeker Portakalı", stokAdet=15, urunKategori="Roman", aciklama=@"Yazarlıkta karar kılıncaya kadar, boks antrenörlüğünden ressam ve heykeltıraşlara modellik yapmaya, muz plantasyonlarında hamallıktan gece kulüplerinde garsonluğa kadar çeşitli işlerde çalışan Jose Mauro de Vasconcelos’un başyapıtı Şeker Portakalı, *günün birinde acıyı keşfeden küçük bir çocuğun öyküsü*dür. Çok yoksul bir ailenin oğlu olarak dünyaya gelen, dokuz yaşında yüzme öğrenirken bir gün yüzme şampiyonu olmanın hayalini kuran Vasconcelos’un çocukluğundan derin izler taşıyan Şeker Portakalı, yaşamın beklenmedik değişimleri karşısında büyük sarsıntılar yaşayan küçük Zeze’nin başından geçenleri anlatır. Vasconcelos, tam on iki günde yazdığı bu romanı *yirmi yıldan fazla bir zaman yüreğinde taşıdığını* söyler.", yazar="Jose Mauro de Vasconcelos", urunResim = @"C:\resimWindowsForms\3.jpg"},
        };
    }
}
