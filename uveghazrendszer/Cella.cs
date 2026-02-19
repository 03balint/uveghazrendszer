using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uveghazrendszer
{
	internal class Cella
	{
		private Pozicio poz;
		private NovenyFaj noveny;
		private int egyedSzam;
		List<Riasztas> riasztasok;
		List<Szenzor> szenzorok;

		public Cella(Pozicio poz)
		{
			NovenyFaj noveny = null;
			this.poz = poz;
			egyedSzam = 0;
			riasztasok = new List<Riasztas>();
			szenzorok = new List<Szenzor>();
		}

		public int Egyedszam { get => egyedSzam; set => egyedSzam = value; }
		internal Pozicio Poz { get => poz; set => poz = value; }
		internal NovenyFaj Noveny { get => noveny; set => noveny = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
		public bool UresCella 
		{ 
			get {
				return this.noveny == null;
					} 
		}

		public bool Beultet(NovenyFaj noveny, int egyedSzam)
		{
			if (this.UresCella)
			{
				this.noveny = noveny;
				this.egyedSzam = egyedSzam;
				return true;
			}
			else if(this.Noveny == noveny)
			{
				this.egyedSzam += egyedSzam;
				return true;
			}
			else { return false; }

		}

		
	}
}
