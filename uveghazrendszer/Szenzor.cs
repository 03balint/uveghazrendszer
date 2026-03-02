using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uveghazrendszer
{
    internal class Szenzor
    {
        string azonosito;
        string tipus;
        Cella cella;
        double mertErtek;
        DateTime meresIdopont;

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        internal Cella Cella { get => cella; set => cella = value; }
        public double MertErtek { get => mertErtek; set => mertErtek = value; }
        public DateTime MeresIdopont { get => meresIdopont; set => meresIdopont = value; }

        public Szenzor(string azonosito, string tipus, Cella cella, double mertErtek, DateTime meresIdopont)
        {
            this.azonosito = azonosito;
            this.tipus = tipus;
            this.cella = cella;
            this.mertErtek = mertErtek;
            this.meresIdopont = meresIdopont;
        }

        public void Meres(double ertek)
        {
            mertErtek = ertek;
            meresIdopont = DateTime.Now;
        }

        public void Kiir()
        {
            Console.WriteLine($"Szenzor: {Tipus}");
            Console.WriteLine($"Mért Cella: ({this.cella.Poz})");
            Console.WriteLine($"Mért érték: {mertErtek}");
            Console.WriteLine($"Időpont: {meresIdopont}");
        }
    }
}
