using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxUygulama
{
    public static class SanalDataBase
    {
        public static List<Musteri> musteriler { get; set; }

        static SanalDataBase()
        {
            musteriler = new List<Musteri>();
        }
    }
}
