namespace Let.Models {
	public class Putnik : Osoba {
		public static int NoFlyChance = 10;
		public bool NoFly = CommonFunction.CalculateChance(NoFlyChance);
		public Prtljag prtljag;

		public Putnik(string ime, string prezime)
		{
			Ime = ime;
			Prezime = prezime;
			var tezinaPrtljaga = rnd.NextDouble() * (5 - 1) + 1;
			prtljag = tezinaPrtljaga < 2 ? (Prtljag)new RucniPrtljag(tezinaPrtljaga) : new PredatiPrtljag(tezinaPrtljaga);
		}
	}
}
