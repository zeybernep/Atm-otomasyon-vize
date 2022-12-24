using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace atmvize
{
    internal class Banka
    {
        public string BankaAdi { get; set; }
        public List<KullaniciHesap> kullanicilar = new List<KullaniciHesap>();
        public List<Musteri> musteriler = new List<Musteri>();
        
    }
}
