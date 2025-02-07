using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//könyv
			Konyv k = new Konyv("Beszterce ostroma", "Mikszáth Kálmán", 1895, 297, 600);
			Console.WriteLine(k + "\n");
            k.Arnoveles(800);
            Console.WriteLine($"Könyv új ára: {k.Ar}");
			k.Kedvezmeny(30.0);
			Console.WriteLine($"Könyv kedvezmjényes ára: {k.Ar}");
			Console.WriteLine($"Hátramaradt oldalak: {k.HanyOldalMaradt(133)}"); ;

			Console.WriteLine("\n=============");

			//film
			Film f = new Film("Gázt!", "Nicolas Winding Refn", 100, "Akciófilm", true);
			Film f2 = new Film("ASD", "harhar");
			Console.WriteLine(f);
			Console.WriteLine(f2);

			f.Jatszas();
			f2.MufajModositas("Akciófilm");
			Console.WriteLine($"A második film új műfaja: {f2.Mufaj}");
			f2.HosszNovelese(42);
			Console.WriteLine($"A második film új műfaja: {f2.HosszPercekben}");


			Console.ReadKey();
        }
	}
}
