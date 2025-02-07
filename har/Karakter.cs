using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
	internal class Karakter
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public Karakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public Karakter(string nev, int ero)
		{
			this.nev = nev;
			this.szint = 1;
			this.eletero = 100;
			this.ero = ero;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public void Tamadas()
		{
            Console.WriteLine($"{this.nev} támad {this.ero} erővel");
        }

		public void Gyogyulas(int mennyiseg)
		{
            Console.WriteLine($"{this.nev} gyógult {mennyiseg} életet");
            this.eletero += mennyiseg;
		}

		public void Szintlepes()
		{
            this.szint += 1;
			this.ero += 1;
			Console.WriteLine($"{this.nev} szintet lépett\n{this.nev} szintje: {this.szint}\n{this.nev} ereje: {this.ero}\n");
		}

		public override string ToString()
		{
			return $"Karakter neve: {this.nev}\nKarakter szintje: {this.szint}\nKarakter életereje: {this.eletero}\nKarakter ereje: {this.ero}\n";
		}
	}
}
