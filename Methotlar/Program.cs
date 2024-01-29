using System;
namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double Fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır kaprpuzu";

            Urun[]urunler= new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");



            }



            Console.WriteLine("------------------Methotlar-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,10);
            sepetManager.Ekle2("elma", "elma armut", 12,20);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzuy", 12,8);
        }
    }
}

