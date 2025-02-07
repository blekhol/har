using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
	internal class Urhajo
	{
		private string nev;
		private int gyorsasag;
		private int utaskapacitas;
		private int uzemanyagSzint;

		public Urhajo(string nev, int gyorsasag, int utaskapacitas, int uzemanyagSzint)
		{
			this.nev = nev;
			this.gyorsasag = gyorsasag;
			this.utaskapacitas = utaskapacitas;
			this.uzemanyagSzint = uzemanyagSzint;
		}

		public Urhajo(string nev, int utaskapacitas)
		{
			this.nev = nev;
			this.gyorsasag = 0;
			this.utaskapacitas = utaskapacitas;
			this.uzemanyagSzint = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Gyorsasag { get => gyorsasag; set => gyorsasag = value; }
		public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
		public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

		public void Indulas()
		{
			this.gyorsasag += 60;
			this.uzemanyagSzint -= 10;
            Console.WriteLine($"{this.nev} elindult, sebessége {this.gyorsasag} km/h, új üzemanyagszint: {this.uzemanyagSzint}%\n");
        }

		public void Tankolas(int mennyiseg)
		{
			if(this.uzemanyagSzint + mennyiseg < 100)
			{
				this.uzemanyagSzint += mennyiseg;
			}
			else
			{
				this.uzemanyagSzint = 100;
			}
			Console.WriteLine($"{this.nev} tankolt, új üzemanyagszint: {this.uzemanyagSzint}%\n");
		}

		public void Landolas()
		{
			this.gyorsasag = 0;
			Console.WriteLine($"{this.nev} landolt, sebessége {this.gyorsasag}\n");
		}

		public override string ToString()
		{
			return $"Űrhajó neve: {this.nev}\nüzemanyagszint: {this.uzemanyagSzint}";
		}
	}
}
