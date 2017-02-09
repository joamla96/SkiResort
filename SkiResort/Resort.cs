using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResort {
	class Resort {
		public Dictionary<long, Lift> Lifts;
		public Dictionary<long, Slope> Slopes;

		public List<string> Events = new List<string>();

		public bool IsOpen = false;
		public Resort() {
			Lifts = new Dictionary<long, Lift>();
			Slopes = new Dictionary<long, Slope>();

			this.IsOpen = true;
		}


	}
}
