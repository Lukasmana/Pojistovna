using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaPojisteni
{
    internal class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public float Telefon {  get; set; }

        public int Vek { get; set; }

        public Zaznam (string jmeno , string prijmeni, float telefon , int vek )
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Vek = vek;
        }
        public override string ToString()
        {
            return Jmeno.Trim() + " " + Prijmeni.Trim() + " " + Vek + " " + Telefon + "\n";
        }

    }
}
