uusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Vytvořte aplikaci, evidující dva lidi. Každý člověk má jméno, věk a přítele. Každý člověk se také umí představit a to tak, 
že vypíše své jméno, věk a jméno svého kamaráda. Vytvořte v aplikaci 2 lidi, kteří se navzájem kamarádí, a nechte je se představit.
*/

namespace OOP
{
	public class OOP_EvidenceLidi
	{


        public static void Main()
		{


			Console.WriteLine("///Program evidence lidí///");


            //Clovek clovek1 = new Clovek("Jan",16,"Jana");
            Clovek clovek1 = new Clovek ();
            Console.WriteLine("První člověk");
            Console.Write("Zadejte jméno: ");
			clovek1.jmeno = Console.ReadLine();
			Console.Write("Zadejte věk: ");
			clovek1.vek = Int32.Parse(Console.ReadLine());
			Console.Write("Zadejte jméno přítele: ");
			clovek1.pritel = Console.ReadLine();


            Clovek clovek2 = new Clovek("Karel", 40, "Lucie");
	

			clovek1.Pozdrav(clovek1.jmeno, clovek1.vek, clovek1.pritel);
            clovek2.Pozdrav(clovek2.jmeno, clovek2.vek, clovek2.pritel);
			Console.WriteLine(clovek1.Pozdrav2(clovek1.jmeno, clovek1.vek, clovek1.pritel));

            Console.ReadKey();
		}
	}

	public class Clovek 
	{



        //konstruktor
        public Clovek (string jmeno, int vek, string pritel)
		{
			this.jmeno = jmeno;
			this.vek = vek;
			this.pritel = pritel;
		}

        //konstruktor 2
        public Clovek()
        {

        }


        //atributy
        public string jmeno;
        public int vek;
        public string pritel;

        //metoda
        public void Pozdrav(string jmeno, int vek, string pritel)
        {
			Console.WriteLine ("Ahoj, jmenuji se {0}, je mi {1} let a můj přítel se jmenuje {2}.", jmeno, vek, pritel);
		}

		//metoda2
		public string Pozdrav2(string jmeno, int vek, string pritel)
		{
			return String.Format("Ahoj, jmenuji se {0}, je mi {1} let a můj přítel se jmenuje {2}.", jmeno, vek, pritel);
		}
	}
}