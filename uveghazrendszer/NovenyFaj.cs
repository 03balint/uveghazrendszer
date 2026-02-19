using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uveghazrendszer
{
	internal class NovenyFaj
	{
		private string nev;
		private int vizigeny; //max 100, azon tull egészség romlik
		private int egeszsegiAllapot; //0-10, ahol 0: elpusztult
		private int optimalisSuruseg;

		public NovenyFaj( string nev, int vizigeny, int egeszsegiAllapot, int optimalisSuruseg)
		{

			this.nev = nev;
			this.vizigeny = vizigeny;
			this.egeszsegiAllapot = egeszsegiAllapot;
			this.optimalisSuruseg = optimalisSuruseg;
		}

		public string Azonosito { get => this.nev.Substring(0,3);}
		public string Nev { get => nev; set => nev = value; }
		public int Vizigeny { get => vizigeny; set => vizigeny = value; }
		public int EgeszsegiAllapot { get => egeszsegiAllapot; set => egeszsegiAllapot = value; }
		public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }

		public override string ToString()
		{
			return $"{this.nev} ({this.Azonosito}) {this.vizigeny} {this.egeszsegiAllapot}";
		}
	}
}
