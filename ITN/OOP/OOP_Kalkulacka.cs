using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Jednoduchý příklad
Vytvořte třídu kalkulačka, jejíž atributy jsou dvě čísla.Třídě vytvořte metody pro základní početní operace(sčítání, odčítání, násobení, dělení), 
které vracejí vždy výsledek dané operace s atributy třídy.V praxi by metody samozřejmě dělaly nějaké složitější výpočty, ale nám to takto stačí.
Nechte uživatele zadat oba atributy, vytvořte instanci kalkulačky, nastavte jí atributy od uživatele a vypište výsledky jednotlivých operací.
*/

namespace OOP
{
	class OOP_Kalkulacka
	{
		public static void Main8(string[] args)
		{
			Console.WriteLine("///Kalkulacka///");
			Kalkulacka kalkulacka = new Kalkulacka();
			Console.Write("Zadejte první číslo: ");
			kalkulacka.cislo1 = double.Parse(Console.ReadLine());
			Console.Write("Zadejte druhé číslo: ");
			kalkulacka.cislo2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Součet: {0}", kalkulacka.Soucet());
			Console.WriteLine("Rozdíl: {0}", kalkulacka.Rozdil());
			Console.WriteLine("Součin: {0}", kalkulacka.Soucin());
			Console.WriteLine("Podíl: {0}", kalkulacka.Podil());
			Console.ReadKey();
		}
	}

	public class Kalkulacka
	{
		public double cislo1;
		public double cislo2;

		public double Soucet()
		{
			return cislo1 + cislo2;
		}

		public double Rozdil()
		{
			return (cislo1 - cislo2);
		}

		public double Soucin()
		{
			return (cislo1 * cislo2);
		}

		public double Podil()
		{
			return (cislo1 / cislo2);
		}

	}

}
