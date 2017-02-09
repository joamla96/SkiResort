using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResort {
	class Resort {
		public Dictionary<long, Lift> Lifts;
		public Dictionary<long, Slope> Slopes;
		public Dictionary<long, Skiier> Skiiers;

		public bool IsOpen = false;
		public Resort() {
			Lifts = new Dictionary<long, Lift>();
			Slopes = new Dictionary<long, Slope>();
			Skiiers = new Dictionary<long, Skiier>();

			this.IsOpen = true;
		}


	}
}
