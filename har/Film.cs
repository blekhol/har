using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = 120;
			this.mufaj = "Ismeretlen";
			this.megjelent = false;
		}

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }

		public void Jatszas()
		{
            Console.WriteLine("A film elkezdődött");
        }

		public void MufajModositas(string ujMufaj)
		{
			this.mufaj = ujMufaj;
		}

		public void HosszNovelese(int percek)
		{
			this.hosszPercekben += percek;
		}

		public override string ToString()
		{
			return $"Film címe: {this.cim}\nFilm rendezője: {this.rendezo}\nFilm hossza: {this.hosszPercekben}\nFilm műfaja: {this.mufaj}\nMegjelent-e már a film: {this.megjelent}\n";
		}
	}
}
