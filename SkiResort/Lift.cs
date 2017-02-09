using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class manages all the lifts

namespace SkiResort {
	class Lift {
		public int PeoplePerLift; // How many can go in 1 lift
		public int TimeInLift; // In ms
		public int TimePerLift; // in MS

		public string Name { get; private set; }

		public Point Destination { get; set; } // Point object for destination

		public int InQue = 0;
	}
}
