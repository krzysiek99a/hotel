using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    internal class Pokoj
    {
        public static int licznik = 1;
        public int ID { get; set; }
        public int IleOsob { get; set; }
        public decimal Cena { get; set; }
        public bool CzyWolne { get; set; }

        public Pokoj(int ileOsob, decimal cena)
        {
            ID = licznik;
            IleOsob = ileOsob;
            Cena = cena;
            CzyWolne = true;
            licznik++;
        }

       
    }
}
