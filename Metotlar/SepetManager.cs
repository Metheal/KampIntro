using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebriker, Sepete eklendi!: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebriker, Sepete eklendi!: " + urunAdi);
        }
    }
}
