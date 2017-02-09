using System;
using System.Collections.Generic;

namespace SkiResort {
	public class Point : IPlace {

		public TimeSpan Wait = new TimeSpan(0,0,0,0,10);


		List<Skiier> Skiiers = new List<Skiier>();
		public string Name { get; private set; }
	
		Point(string name) {
			this.Name = name;
		}
	}
}
