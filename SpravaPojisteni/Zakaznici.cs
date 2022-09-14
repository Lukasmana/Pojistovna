using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaPojisteni
{
    internal class Zakaznici
    {

        private Pojistovna pojistovna;

   
        public Zakaznici()
        {
            pojistovna = new Pojistovna();
        }

        public void PridejZakaznika()
        {
            Console.WriteLine("Zadejte jméno: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Špatne zadané jméno:" +
                    "zadejte prosim znovu: ");
            }

            string prijmeni;
            Console.WriteLine("Zadejte příjmení: ");
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Špatne zadané příjmení:" +
                    "zadejte prosim znovu: ");
            }

            Console.WriteLine("Zadejte Telefoní číslo: ");
            float telefon = float.Parse(Console.ReadLine());
         
            while (telefon > 999999999)
            {
                Console.WriteLine("špatné telefoní čislo \n" +
                    "zadejte prosim znovu: ");
                telefon = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            while (vek > 100)
            {
                Console.WriteLine("Nevhodný věk čislo \n" +
                    "zadejte prosim znovu: ");
                vek = int.Parse(Console.ReadLine());
            }


            pojistovna.PridejZakaznika(jmeno,prijmeni,telefon,vek);
        }
        public void VypisZakazniky()
        {
            List<Zaznam> zaznamy = pojistovna.VypisZakazniky();
            foreach (Zaznam a in zaznamy)
                Console.WriteLine(a);
        }
        public void NajdiZachaznika()
        {
            List<Zaznam> zaznamy = pojistovna.VypisZakazniky();
            Console.WriteLine("Zadejte jemno vyhledávaného zákaznika: ");
            string zadaneJmeno = Console.ReadLine();
            
            
            Console.WriteLine("Zadejte přijmeni vyhledávaného zákaznika: ");
            string zadanePrijmeni = Console.ReadLine().Trim();

            Console.WriteLine("Nalezeny tyto záznamy: \n");
                foreach (Zaznam z in zaznamy)
                if (zadaneJmeno == z.Jmeno)
                {
                    if (zadanePrijmeni == z.Prijmeni)
                    { 
                    Console.WriteLine(z);
                    break;
                    }
                }
                else
                {
                    Console.WriteLine("Nebyly nalezeny žádné záznamy.");
                }
                
        }
    }
}
