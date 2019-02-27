using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KulasTeodorZadatakZaKraj.KlasaVozilo
{
    class Vozilo
    {
        int BrojTockova, maxBrzina;
        string vrsta;

        public void setBrojTockova(int brojKotaca)
        {
            this.BrojTockova = brojKotaca;
        }

        public int getBrojTockova()
        {
            return this.BrojTockova;
        }

        public void setVrsta(string vrsta)
        {
            this.vrsta = vrsta;
        }

        public string getVrsta()
        {
            return this.vrsta;
        }

        public void setmaxBrzina(int maxBrzina)
        {
            this.maxBrzina = maxBrzina;
        }

        public int getmaxBrzina()
        {
            return this.maxBrzina;
        }

        public override string ToString()
        {
            return "Vrsta: " + vrsta + "\nBroj tockova: " + BrojTockova + "\nMax brzina: " + maxBrzina;
        }



    }
}
