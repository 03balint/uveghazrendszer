namespace uveghazrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Kezelo k =new Kezelo("Kovács Péter","kpeter", Szerepkor.ADMIN);
			Kezelo k1 = new Kezelo("Nagy Anna", "nanna", Szerepkor.KERTESZ);

            NovenyFaj paradicsom=new NovenyFaj("Paradicsom",100,10,10);
			NovenyFaj salata = new NovenyFaj("Saláta", 90, 10, 4);
			//Cella cella = new Cella(new Pozicio(0, 0));			
			//Console.WriteLine(cella.UresCella);

			//cella.Beultet(n1, 5);
			//Console.WriteLine(cella.UresCella);

			UveghazRacs uveghaz=new UveghazRacs(4);
            uveghaz.Kiiratas();
            uveghaz.Telepit(1,1,paradicsom,4);
			uveghaz.Telepit(4,2, salata, 1);
			uveghaz.Kiiratas();

			uveghaz.Noveles(1, 1, 10);
			uveghaz.Kiiratas();

			uveghaz.Csokkentes(4, 2, 1);
		}
    }
}
