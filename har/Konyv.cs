using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadaseve;
		private int oldalszam;
		private int ar;

		public Konyv(string cim, string szerzo, int kiadaseve, int oldalszam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadaseve = kiadaseve;
			this.oldalszam = oldalszam;
			this.ar = ar;
		}

		public Konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadaseve = DateTime.Now.Year;
			this.oldalszam = 200;
			this.ar = 3000;
		}

		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int Kiadaseve { get => kiadaseve; set => kiadaseve = value; }
		public int Oldalszam { get => oldalszam; set => oldalszam = value; }
		public int Ar { get => ar; set => ar = value; }

		public void Arnoveles(int osszeg)
		{
			this.ar = osszeg;
		}

		public void Kedvezmeny(double szazalek)
		{
			this.ar = Convert.ToInt32(this.ar * szazalek / 100);
		}

		public int HanyOldalMaradt(int elolvasott)
		{
			return this.oldalszam - elolvasott;
		}

		public override string ToString()
		{
			return $"Könyv címe: {this.cim}\nKönyv szerzője: {this.szerzo}\nKönyv kiadási éve: {this.kiadaseve}\nKönyv oldalszáma: {this.oldalszam}\nKönyv ára: {this.ar}";
		}
	}
}
