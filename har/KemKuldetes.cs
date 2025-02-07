using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
	internal class KemKuldetes
	{
		private string kodnev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsely;

		public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsely)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsely = sikerEsely;
		}

		public KemKuldetes(string kodnev, string orszag)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = 5;
			this.sikerEsely = 50;
		}

		public string Kodnev { get => kodnev; set => kodnev = value; }
		public string Orszag { get => orszag; set => orszag = value; }
		public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
		public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

		public void KuldetesInditasa()
		{
            Console.WriteLine($"A {this.kodnev} küldetés elkezdődött. Ország: {this.orszag}.");
        }

		public void VeszelySzintNovelese(int mennyiseg)
		{
			this.veszelySzint += mennyiseg;
            Console.WriteLine($"{this.kodnev} veszélyszintje megnőtt: {this.veszelySzint}");
        }

		public void SikerEselyNovelese(int szazalek)
		{
			this.sikerEsely += szazalek;
			Console.WriteLine($"{this.kodnev} sikeresélye megnőtt: {this.sikerEsely}%");
		}

		public override string ToString()
		{
			return $"Kódnév: {this.kodnev}\nOrszág: {this.orszag}\nVeszély szint: {this.veszelySzint}\nSikeres küldetés esélye: {this.sikerEsely}%\n";
		}
	}
}
