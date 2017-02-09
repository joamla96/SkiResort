using System;
using System.Collections.Generic;

namespace SkiResort {
	public class Point : IPlace {
		public int Skiiers { get; private set; }
		public string Name { get; private set; }
		public int Weight { get; private set; }
		public int Que { get; }

		List<IPlace> Places;

		public Point(string name, List<IPlace> places) {
			this.Name = name;
			this.Places = places;
		}

		public void TakePassenger(int passengers) { // Skiiers arrive by lift
			// Should split out passengers into the various ques and slopes...
			throw new NotImplementedException();
		}
	}
}
