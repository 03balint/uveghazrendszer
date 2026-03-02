using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uveghazrendszer
{
	internal class UveghazRacs
	{
		int meret;
		Cella[,] kert;

		public UveghazRacs(int meret)
		{
			this.meret = meret;
			this.kert = new Cella[this.meret, this.meret];
			Parcellaz();
		}

		private void Parcellaz()
		{
			for (int i = 0; i < this.kert.GetLength(0); i++)
			{
				for (int j = 0; j < this.kert.GetLength(1); j++)
				{
					this.kert[i,j]=new Cella(new Pozicio(i,j));
				}
			}
		}

		public Cella CellaLekerdezes(int x, int y)
		{
			return kert[x-1,y-1];
		}
		
		public void Telepit(int x, int y, NovenyFaj noveny, int egyedSzam)
		{
			bool sikeres=kert[x-1,y-1].Beultet(noveny, egyedSzam);
			if (sikeres)
			{
				Console.WriteLine($"{noveny.Nev} sikeresen beültetve a {x}-{y} ágyásba!");
			}
			else { Console.WriteLine($"{noveny.Nev} nem lett beültetve a {x}-{y} ágyásba!"); }
		}
		
		public void Kiiratas()
		{
			Console.WriteLine("\n-------------------------------------");
			for (int i = 0; i < this.kert.GetLength(0); i++)
			{
				Console.Write("|");
				for (int j = 0; j < this.kert.GetLength(1); j++)
				{
					if (this.kert[i, j].UresCella)
					{
						Console.Write($"  {"ÜRES"}  |");
					}
					else
					{
						Console.Write($"{kert[i, j].Noveny.Azonosito,3} {kert[i,j].Egyedszam,2}db|");
					}
				}
				Console.WriteLine("\n-------------------------------------");
			}
			Console.WriteLine();
		}

		public void Noveles(int x, int y, int mennyiseg)
		{
			kert[x-1,y-1].Noveles(mennyiseg);
			Console.WriteLine($"{x}-{y} ágyás növénye, a(z) {kert[x-1,y-1].Noveny.Nev}, egyedszám: {kert[x - 1, y - 1].Egyedszam}");
			if ( kert[x - 1, y - 1].Noveny.OptimalisSuruseg >  kert[x - 1, y - 1].Egyedszam)
			{
				Console.WriteLine("A növények jól érzik magukat!");
			}
			else
			{
				Console.WriteLine("A növények sokan vannak, nem érzik jól magukat!");
				Csokkentes(x, y, Math.Abs(kert[x - 1, y - 1].Noveny.OptimalisSuruseg - kert[x - 1, y - 1].Egyedszam));
			}

		}

		public void Csokkentes(int x, int y, int mennyiseg) 
		{
			kert[x - 1, y - 1].Csokkentes(mennyiseg);
			Console.WriteLine($"{x}-{y} ágyás növénye, a(z) {kert[x - 1, y - 1].Noveny.Nev}, egyedszám: {kert[x - 1, y - 1].Egyedszam}");

		}

		public void Urit(int x, int y)
		{
			kert[x - 1, y - 1].Urit();
			Console.WriteLine($"{x}-{y} ágyás sikeresen ürtítve!");
		}

        public void Szomszedok(int x, int y)
        {
            string szomszedok = "";

            if (x - 2 >= 0)
            {
                if (!kert[x - 2, y - 1].UresCella)
                    szomszedok += kert[x - 2, y - 1].Noveny.Nev;
                else
                    szomszedok += "üres";
            }
            else
            {
                szomszedok += "nincs";
            }
            szomszedok += ", ";

            if (y - 2 >= 0)
            {
                if (!kert[x - 1, y - 2].UresCella)
                    szomszedok += kert[x - 1, y - 2].Noveny.Nev;
                else
                    szomszedok += "üres";
            }
            else
            {
                szomszedok += "nincs";
            }
            szomszedok += ", ";

            if (y < kert.GetLength(1))
            {
                if (!kert[x - 1, y].UresCella)
                    szomszedok += kert[x - 1, y].Noveny.Nev;
                else
                    szomszedok += "üres";
            }
            else
            {
                szomszedok += "nincs";
            }
            szomszedok += ", ";

            if (x < kert.GetLength(0))
            {
                if (!kert[x, y - 1].UresCella)
                    szomszedok += kert[x, y - 1].Noveny.Nev;
                else
                    szomszedok += "üres";
            }
            else
            {
                szomszedok += "nincs";
            }

            Console.WriteLine(szomszedok);
        }
    }
}
