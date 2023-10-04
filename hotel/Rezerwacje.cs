using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    internal class Rezerwacje
    {
        public Rezerwacje(DateTime dataStart, DateTime dataEnd, int pokoj, int klient)
        {
            DataStart = dataStart;
            DataEnd = dataEnd;
            Pokoj = pokoj;
            Klient = klient;
        }

        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
        public int Pokoj {  get; set; }
        public int Klient { get; set; }
    }
}
