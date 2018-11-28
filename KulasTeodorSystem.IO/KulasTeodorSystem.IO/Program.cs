using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulasTeodorSystem.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"C:\Users\Učenik\Documents";
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");

                //isto ovako se moze pisat:
                //string[] putanja = Directory.GetFiles(putanja);
              


                foreach (string datoteka in Directory.GetFiles(putanja)) 
                {
                    Console.WriteLine(datoteka);
                }
            }

            //kreiranje i brisanje mape
            string mapa1 = putanja + "\\test";

            if(Directory.Exists(mapa1))
            {

                Console.WriteLine("\nMapa izbrisana.");
                Directory.Delete(mapa1);
            }
            else
            {
                Console.WriteLine("\nMapa kreirana");
                Directory.CreateDirectory(mapa1);
            }

            //ispis podmapi

            if (Directory.Exists(putanja))
            {
                Console.WriteLine("\nPodmape: ");
                foreach (string datoteka in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }

            Console.ReadKey();
        }
    }
}
