using System;
using System.Collections.Generic;

namespace SkiResort {
	public class Point : IPlace {
		public int Skiiers { get; private set; }
		public string Name { get; private set; }
		public int Weight { get; private set; }
		public int Que { get; }

		List<IPlace> Places;
		Random rnd = new Random();

		public Point(string name, List<IPlace> places) {
			this.Name = name;
			this.Places = places;
		}

		public void TakePassenger(int passengers) { // Skiiers arrive by lift
			int TotalWeight = 0;
			Dictionary<int, IPlace> WeightedPlaces = new Dictionary<int, IPlace>();
			foreach (IPlace Place in Places) {
				for(int i = 0; i < Place.Weight; i++) {
					WeightedPlaces.Add(TotalWeight, Place);
					TotalWeight++;
				}
			}

			for(int i = 0; i < passengers; i++) {
				WeightedPlaces[rnd.Next(0, TotalWeight)].TakePassenger(1);
			}
		}
	}
}
