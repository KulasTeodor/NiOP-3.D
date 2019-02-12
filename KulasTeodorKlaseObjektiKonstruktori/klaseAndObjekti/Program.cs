using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avijon = new Vozilo();

            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");

            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine("Vrsta: " + avijon.getVrsta() + " Oznaka: " +
                avijon.getOznaka() + "\nLeti: " + avijon.getLeti() + "\nPlovi: "+ avijon.getPliva()
                + "\nVozi: " + avijon.getVozi() + "\nBroj kotača: "+avijon.getBrojKotaca() + "\n");
            
            Console.WriteLine(kamijon.ToString());

            Console.WriteLine(avijon.ispis());

			Vozilo unos = new Vozilo();
			bool novo = true;

			do
			{
				Console.WriteLine("\nKojoj vrsti pripada Vase vozilo: ");
				unos.setVrsta(Console.ReadLine().ToString());
				Console.WriteLine("Koliko kotaca ima Vase vozilo: ");
				unos.setBrojKotaca(Convert.ToInt32(Console.ReadLine()));
				Console.WriteLine("Moze li letjeti(true/false): ");
				unos.setLeti(bool.Parse(Console.ReadLine()));
				Console.WriteLine("Moze li plivati(true/false): ");
				unos.setPliva(bool.Parse(Console.ReadLine()));
				Console.WriteLine("Moze li voziti(true/false): ");
				unos.setVozi(bool.Parse(Console.ReadLine()));
				Console.WriteLine("Oznaka Vaseg vozila: ");
				unos.setOznaka(Console.ReadLine().ToString());

				Console.WriteLine(unos.ispis());

				Console.WriteLine("\nZelite li upisati jos neko vozilo(true/false) ? ");
				novo = bool.Parse(Console.ReadLine());

			} while (novo == true);

            Console.ReadLine();
        }
    }

    
}
