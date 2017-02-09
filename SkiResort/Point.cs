using System;
using System.Collections.Generic;

namespace SkiResort {
	public class Point : IPlace {
		public int Skiiers { get; private set; }
		public string Name { get; private set; }

		List<IPlace> Places;

		Point(string name, List<IPlace> places) {
			this.Name = name;
			this.Places = places;
		}

		internal int TakeLoad(int capacity) { // Passengers gets taken by a lift
			throw new NotImplementedException();
		}

		internal void GiveLoad(int passengers) { // Skiiers arrive by lift
			// Should split out passengers into the various ques and slopes...
			throw new NotImplementedException();
		}
	}
}
