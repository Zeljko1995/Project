using System;

namespace Let.Models {

	public class Osoba {
		public string Ime { get; set; }
		public string Prezime { get; set; }

		public static Random rnd = new Random();
		public double Kilaza = rnd.NextDouble() * (100 - 20) + 20;
	}
}
