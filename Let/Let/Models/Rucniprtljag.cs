namespace Let.Models {
	public class RucniPrtljag : Prtljag {
		public static int ChanceForLost = 10;

		public RucniPrtljag(double tezinaPrtljaga)
		{
			IsLost = CommonFunction.CalculateChance(ChanceForLost);
			Tezina = tezinaPrtljaga;
		}
	}
}
