using System;
using System.Collections.Generic;
using Let.Models;

namespace Let {
	public class Let {

		private static Let instance;
		List<Putnik> putnici = CommonFunction.KreiranjePutnika();

		private Let() { }

		public static Let Instance {
			get {
				if (instance == null)
				{
					instance = new Let();
				}
				return instance;
			}
		}

		public void Start()
		{
			Console.WriteLine($"Putnici ulaze");
			Console.WriteLine($"Piloti ulaze");

			List<Pilot> piloti = CommonFunction.KreiranjePilota();
			Console.WriteLine($"Avion polece");
			Console.WriteLine($"Avion slece");

			double sum = 0;
			foreach (var putnik in putnici)
			{
				if (putnik.prtljag.IsLost && putnik.prtljag is PredatiPrtljag)
				{
					sum += putnik.prtljag.Tezina;
					Console.WriteLine($"Putnik {putnik.Ime} {putnik.Prezime} je izgubio predati prtljag tezine {putnik.prtljag.Tezina:0.##} kg");
				}
			}

			Console.WriteLine(sum > 0
				? $"Ukupna tezina prtljaga koja je izgubljena je {sum:0.##}kg"
				: "Niko nije izgubio prtljag");
		}
	}
}
