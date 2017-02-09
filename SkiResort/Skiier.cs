using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResort {
	public class Skiier {
		public double ID { get; private set; }

		public Skiier() {
			ID = KeyGenerator.NextID;
		}
	}
}
