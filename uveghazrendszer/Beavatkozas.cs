using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uveghazrendszer
{
	internal class Beavatkozas
	{
		string tipus;
		DateTime datum;
		Cella celCella;
		string megjegyzes;

        public Beavatkozas(string tipus, DateTime datum, Cella celCella, string megjegyzes)
        {
            this.tipus = tipus;
            this.datum = datum;
            this.celCella = celCella;
            this.megjegyzes = megjegyzes;
        }

        public string Tipus { get => tipus; set => tipus = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
        internal Cella CelCella { get => celCella; set => celCella = value; }

        public void Kiir()
        {
            Console.WriteLine($"Beavatkozás típusa: {tipus}");
            Console.WriteLine($"Dátum: {datum}");
            Console.WriteLine($"Cella: ({celCella.Poz})");
            Console.WriteLine($"Megjegyzés: {megjegyzes}");
        }
    }
}
