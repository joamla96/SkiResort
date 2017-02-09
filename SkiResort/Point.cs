using System;
using System.Collections.Generic;

namespace SkiResort {
	public class Point : IPlace {
		public string Name { get; private set; }
	
		Point(string name) {
			this.Name = name;
		}

		internal int TakeLoad(int capacity) {
			throw new NotImplementedException();
		}

		internal void GiveLoad(int passengers) {
			throw new NotImplementedException();
		}
	}
}
