using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulasTeodorZadatakZaKraj.KlasaVozilo;

namespace KulasTeodorZadatakZaKraj
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Unesite zeljenu brzinu.");

            Vozilo motocikl = new Vozilo();

            motocikl.setBrojTockova(2);
            motocikl.setVrsta("Cesna");
            motocikl.setmaxBrzina(Convert.ToInt32(Console.ReadLine())); 

            Vozilo automobil = new Vozilo();
            automobil.setBrojTockova(4);
            automobil.setVrsta("Cesna");
            automobil.setmaxBrzina((int)(motocikl.getmaxBrzina() * 0.3));

            Console.WriteLine("\nMotocikl:");
            Console.WriteLine(motocikl.ToString());

            Console.WriteLine("\nAutomobil:");
            Console.WriteLine(automobil.ToString());


            Console.ReadLine();

        }
    }
}
