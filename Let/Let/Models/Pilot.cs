namespace Let.Models {
	public class Pilot : Osoba {
		public static int NoLicenceChance = 5;
		public static bool NoLicence = CommonFunction.CalculateChance(NoLicenceChance);

		public Pilot(string ime, string prezime)
		{
			Ime = ime;
			Prezime = prezime;
		}

		public void ValidatePilot()
		{
			if (NoLicence)
				throw new NemaLicencuException();
		}
	}
}
