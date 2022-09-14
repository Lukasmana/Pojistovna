using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaPojisteni
{
    internal class Pojistovna
    {

        private List<Zaznam> zakazniku = new List<Zaznam>();


        public Pojistovna()
        {
            zakazniku = new List<Zaznam>();
        }
        public void PridejZakaznika(string jmeno, string prijmeni, float telefon , int vek)
        {
            zakazniku.Add(new Zaznam(jmeno,prijmeni,telefon,vek) );
            Console.WriteLine("\nŮspěně byl přídán nový zákaznik\n ");
        }

        public List<Zaznam> VypisZakazniky()
        {
            List<Zaznam> seznam = new List<Zaznam>();
            foreach (Zaznam i in zakazniku)
            {          
                seznam.Add(i);
            }
            return seznam;

        }
        public List<Zaznam> NajdiZachaznika()
        {
            List<Zaznam> seznam = new List<Zaznam>();
            foreach (Zaznam i in zakazniku)
            {
                seznam.Add(i);
            }
            return seznam;

        }

    }
}
