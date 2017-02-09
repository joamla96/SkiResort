using System;

namespace SkiResort {
	class Point {
		public long ID { get; private set; }
		public string Name { get; private set; }

		Point(string name) {
			this.ID = KeyGenerator.NextID;
			this.Name = name;
		}
	}
}
