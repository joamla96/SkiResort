using System;
using System.Collections.Generic;

namespace SkiResort {
	public class Point : IPlace {
		public string Name { get; private set; }
	
		Point(string name) {
			this.Name = name;
		}
	}
}
