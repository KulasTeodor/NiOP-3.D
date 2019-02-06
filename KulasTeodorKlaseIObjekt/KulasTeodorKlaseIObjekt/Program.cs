using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulasTeodorKlaseIObjekt.Klase;

namespace KulasTeodorKlaseIObjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avijon = new Vozilo();

            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVrsta("Cesna");
            avijon.setOznaka("1312");
            avijon.setVozi(true);

            Console.WriteLine("Vrsta: " + avijon.getVrsta() + "Oznaka : " + avijon.getOznaka() + "\n Leti: " + avijon.getLeti() + "\n Vozi: " + avijon.getVozi() + "\n Pliva: "+ avijon.getPliva() + "\n BrojKotaca: " + avijon.getBrojKotaca());

            Vozilo kamion = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine(kamion.ToString);




            Console.ReadLine();
        }
    }
}
