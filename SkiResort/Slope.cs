using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResort {
	public class Slope {
		public long ID { get; private set; }
		public string Name { get; private set; }
		public List<Skiier> OnSlope = new List<Skiier>(); // List of the Skiiers on the Slope
	}
}
