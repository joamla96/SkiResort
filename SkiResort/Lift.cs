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

		public long ID { get; private set; }
		public string Name { get; private set; }

		public int DestinationID { get; set; } // ID of the Slope we're going to.

		public int InQue = 0;
	}
}
