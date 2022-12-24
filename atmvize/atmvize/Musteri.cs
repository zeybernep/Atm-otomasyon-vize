using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace atmvize
{
    internal class Musteri:KullaniciHesap
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }

        private static Musteri musteriler = new Musteri();
       

       

    }
}
