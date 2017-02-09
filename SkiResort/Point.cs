using System;

namespace SkiResort {
	public class Point {
		public string Name { get; private set; }

		Point(string name) {
			this.Name = name;
		}
	}
}
