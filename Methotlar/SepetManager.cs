using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikjler sepete eklendi ; "+ urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokadeti)
        {
            Console.WriteLine("tebrikler ürün eklendi:"+ urunAdi);
        }
    }
}
