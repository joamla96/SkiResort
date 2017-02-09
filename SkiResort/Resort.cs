using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResort {
	public class Resort {
		public Dictionary<long, LiftLine> Lifts;
		public  Dictionary<long, Slope> Slopes;

		public List<string> Events = new List<string>();

		public bool IsOpen = false;
		public Resort() {
			Lifts = new Dictionary<long, LiftLine>();
			Slopes = new Dictionary<long, Slope>();

			IsOpen = true;
		}


	}
}
