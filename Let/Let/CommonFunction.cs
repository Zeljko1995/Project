using System;
using System.Collections.Generic;
using System.Text;
using Let.Models;

namespace Let {
	public class CommonFunction {
		public static List<Putnik> KreiranjePutnika()
		{
			var putnici = new List<Putnik>()
			{
				new Putnik("Marko", "Markovic"),
				new Putnik("Ivan", "Ivanovic"),
				new Putnik("Ana", "Markovic"),
				new Putnik("Maja", "Ristic"),
				new Putnik("Jovan", "Jovanovic"),
				new Putnik("Petar", "Markovic"),
				new Putnik("Ena", "Markovic"),
				new Putnik("Tea", "Markovic"),
				new Putnik("Aco", "Markovic"),
				new Putnik("Una", "Markovic"),
			};
			return putnici;
		}


		public static List<Pilot> KreiranjePilota()
		{
			var piloti = new List<Pilot>()
			{
				new Pilot("Marko", "Markovic"),
				new Pilot("Ivan", "Ivanovic"),
			};
			foreach (var pilot in piloti)
				pilot.ValidatePilot();

			return piloti;
		}

		public static bool CalculateChance(int chance)
		{
			var random = new Random();
			var number = random.Next(0, 101);

			return chance > number;
		}
	}
}
