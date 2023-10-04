using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    internal class Klient
    {
        static int licznik = 1;

        public Klient(string imie, string nazwisko )
        {
            Imie = imie;
            Nazwisko = nazwisko;
            IDK = licznik;
            licznik++;
        }

        public string Imie { get; set; }
        public string Nazwisko { get; set;}
        public int IDK {  get; set; }


    }
}
