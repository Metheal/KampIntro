using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi! "
                + "Bankamiza Hosgeldiniz "
                + musteri.Ad + " "
                + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            //musteriyi databaseden cikarma kodu buraya
            Console.WriteLine("Musteri kayittan silindi!");
            Console.WriteLine("Hoscakalin "
                + musteri.Ad + " "
                + musteri.Soyad);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri adi soyadi: "
                    + musteri.Ad + " "
                    + musteri.Soyad);
            }
        }
    }
}
