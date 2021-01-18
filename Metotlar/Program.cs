using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi";

            Console.WriteLine("Hello World!");

            Urun urun1 = new Urun
            {
                Adi = "Elma",
                Fiyati = 15,
                Aciklama = "Amasya elmasi"
            };

            Urun urun2 = new Urun
            {
                Adi = "Karpuz",
                Fiyati = 80,
                Aciklama = "Diyarbakir karpuzu"
            };

            Urun[] urunler = new Urun[] { urun1, urun2 };

            Console.WriteLine("-------------Donguler-------------");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urun: " + urun.Adi + " " +
                                  urun.Fiyati + " TL. " +
                                  urun.Aciklama);
            }

            Console.WriteLine("-------------Metotlar-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 15, 10);
            sepetManager.Ekle2("Elma", "Yesil elma", 20, 10);
            sepetManager.Ekle2("Karpuz", "Amasya elmasi", 25, 10);


        }
    }
}
