using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  Adi = "Ahmet";
            int Yas = 36;


            kurs kurs1 = new kurs();
            kurs1.kursadı = "c#";
            kurs1.kursunegıtmenı = "ahmet";
            kurs1.izlenmeoranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursadı = "java ";
            kurs2.kursunegıtmenı = "kerem";
            kurs2.izlenmeoranı = 70;

            kurs kurs3 = new kurs();
            kurs3.kursadı = "piton ";
            kurs3.kursunegıtmenı = "bilal";
            kurs3.izlenmeoranı = 99;

            kurs[] kursal = new kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kursal)
            {
                Console.WriteLine(kurs.kursadı + " ; " + kurs.kursunegıtmenı + "  ; " + kurs.izlenmeoranı);
            }






            Console.WriteLine("helllo world;");
            Console.ReadKey();
        }

        class kurs
        {
            public string kursadı { get; set; }
            public string kursunegıtmenı { get; set; }

            public int izlenmeoranı { get; set; }


        }
    }
}
