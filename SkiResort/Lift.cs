using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class manages all the lifts

namespace SkiResort {
	class Lift : IPlace {
		public int Chance { get; set; }

		public TimeSpan Wait { get; set; }

		public Lift(int chance, TimeSpan wait) {
			this.Chance = chance;
			this.Wait = wait;
		}
	}
}
