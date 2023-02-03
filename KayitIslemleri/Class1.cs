using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsKontrolerInceleme2
{
    public static class SanalDataBase
    {
        public static List<musteri> musteriler { get; set; }

        static SanalDataBase()
        {
            musteriler = new List<musteri>();
        }

    }
}
