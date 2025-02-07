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
			Konyv k = new Konyv("Beszterce ostroma", "Mikszáth Kálmán", 1895, 297, 600);
			Console.WriteLine(k + "\n");
            k.Arnoveles(800);
            Console.WriteLine($"Könyv új ára: {k.Ar}");
			k.Kedvezmeny(30.0);
			Console.WriteLine($"Könyv kedvezmjényes ára: {k.Ar}");
			Console.WriteLine($"Hátramaradt oldalak: {k.HanyOldalMaradt(133)}"); ;

			Console.ReadKey();
        }
	}
}
