namespace Let.Models {
	public class PredatiPrtljag : Prtljag {
		public static int ChanceForLost = 30;

		public PredatiPrtljag(double tezinaPrtljaga)
		{
			IsLost = CommonFunction.CalculateChance(ChanceForLost);
			Tezina = tezinaPrtljaga;
		}
	}
}
