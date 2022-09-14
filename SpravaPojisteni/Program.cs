
using SpravaPojisteni;

Zakaznici seznam = new Zakaznici();

Console.WriteLine(
  "--------------------------\n " +
    "| Evidence Pojištěných |" +
"\n--------------------------\n");


Console.WriteLine("Vyberte si akci\n" +
    "\n----------------------------\n"+
    "1 - Přidat nového pojištěného\n" +
    "2 - Vypsat všechny pojištěné\n" +
    "3 - Vyhledat pojištěného\n" +
    "4 - konec\n" +
    "----------------------------\n");


string vstup = Console.ReadLine();

while ((vstup != "1") && (vstup != "2") && (vstup != "3") && (vstup != "4"))

{
    Console.WriteLine("\nŠpatné zadání ! \n ");

    Console.WriteLine("Vyberte si akci\n" +
    "\n----------------------------\n" +
    "1 - Přidat nového pojištěného\n" +
    "2 - Vypsat všechny pojištěné\n" +
    "3 - Vyhledat pojištěného\n" +
    "4 - konec\n" +
    "----------------------------\n");

    vstup = Console.ReadLine();

}

int zadani = int.Parse(vstup);

while (zadani != 4)
{
   
    switch (zadani)
    {

        case 1:
            Console.WriteLine("\nProvadím zadání : Přidat nového pojištěného\n ");          
            seznam.PridejZakaznika();
            break;
        case 2:
            Console.WriteLine("\nProvadím zadání : Výpis všech pojištěného\n ");
            seznam.VypisZakazniky();
            break;
        case 3:
            Console.WriteLine("\nProvadím zadání : Vyhledávání pojištěného\n ");
            seznam.NajdiZachaznika();
            break;
        default:
            Console.WriteLine("\nŠpatné zadání ! \n ");
            break;
  }

 

    Console.WriteLine("Vyberte si akci\n" +
       "\n----------------------------\n" +
       "1 - Přidat nového pojištěného\n" +
       "2 - Vypsat všechny pojištěné\n" +
       "3 - Vyhledat pojištěného\n" +
       "4 - konec\n" +
       "----------------------------\n");

    vstup = Console.ReadLine();
    zadani = int.Parse(vstup);
    Console.WriteLine("\n");
    Console.WriteLine("["+ zadani + "]");
  

}

Console.WriteLine("\nKonec aplikace");
Console.WriteLine("Děkuji a přeji příjemný den :) ");
Console.WriteLine("\nPro ukončení zmáčkněte \"Enter\" ");
Console.ReadKey();
