using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
S použitím objektově orientovaného programování vytvořte aplikaci, ve které figuruje nákladní auto, 
které převáží písek. Toto auto má nosnost 3 tuny a jeho náklad je zpočátku prázdný.

Nechte auto postupně:

naložit 10 tun
naložit 500 kg
vyložit 300 kg
vyložit 1 tunu
Jak asi tušíte, naložení a vyložení nákladu bude probíhat pomocí metod, které si před změnou váhy nákladu nejprve ověří, 
zda je v autě dost místa nebo zda nevykládáme více, než je naloženo. V případě chyby se náklad nevloží/nevyloží.

Po dokončení nakládání a vykládání nechte vypsat kolik je v autě kg nákladu, mělo by vám vyjít 200 kg.
*/

namespace OOP
{
	public class OOP_NakladniAuto
	{
		public static void Main3()
		{
			Console.WriteLine("///Program nákladní auto///");
			NakladniAuto nakladniauto = new NakladniAuto();
			Console.WriteLine("\n(nákladní auto má počáteční náklad prázdný)"); 

			Console.WriteLine("\n1.úkon: naložení 10 t");
			Console.WriteLine("Naložení nákladního auta je: {0} kg", (nakladniauto.Nalozeni (10000)));
			Console.WriteLine("\n2.úkon: naložení 500 kg");
			Console.WriteLine("Naložení nákladního auta je: {0} kg", (nakladniauto.Nalozeni(500)));
			Console.WriteLine("\n3.úkon: vyložení 300 kg");
			Console.WriteLine("Naložení nákladního auta je: {0} kg", (nakladniauto.Vylozeni(300)));
			Console.WriteLine("\n4.úkon: vyložení 1 t");
			Console.WriteLine("Naložení nákladního auta je: {0} kg", (nakladniauto.Vylozeni(1000)));

			Console.ReadKey();
		}
	}

	public class NakladniAuto
	{
		public int nosnost;

		int naklad = 0;

		public int Nalozeni (int nalozeni)
		{
			if (nalozeni > 3000)
			{
				Console.WriteLine("Byla překročena nosnost 3 tuny!");
				return naklad;
			}
			else
			{
				naklad = naklad + nalozeni;
				return naklad;
			}
		}

		public int Vylozeni (int vylozeni)
		{
			if (vylozeni > naklad)
			{
				Console.WriteLine("Nelze vyložit více než-li je naloženo!");
				return naklad;
			}
			else
			{
				naklad = naklad - vylozeni;
				return naklad;
			}
		}
		
		
		}
	}

