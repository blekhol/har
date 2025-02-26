﻿using System;
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
			Console.WriteLine($"A második film frissített hossza: {f2.HosszPercekben}");

			//karakter
			Karakter k1 = new Karakter("asd", 50, 57, 11);
			Karakter k2 = new Karakter("harharharharhar", 7);
			Console.WriteLine(k1);
			Console.WriteLine(k2);

			k1.Tamadas();
			k1.Gyogyulas(43);
			k2.Szintlepes();

			//űrhajó
			Urhajo h1 = new Urhajo("hajó1", 53, 4, 67);
			Urhajo h2 = new Urhajo("hajó2", 8);
			Console.WriteLine(h1);
			Console.WriteLine(h2);

			Console.WriteLine();

			h1.Landolas();
			h2.Indulas();
			h2.Tankolas(4);

			//küldetés
			KemKuldetes kuld1 = new KemKuldetes("Bombariadó", "Magyarország", 1, 100);
			KemKuldetes kuld2 = new KemKuldetes("Banán operáció", "Mongólia");
			Console.WriteLine(kuld1);
			Console.WriteLine(kuld2);

			Console.WriteLine();

			kuld1.KuldetesInditasa();
			kuld1.VeszelySzintNovelese(1);
			kuld2.SikerEselyNovelese(17);

			Console.ReadKey();
        }
	}
}
