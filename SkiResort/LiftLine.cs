using System;
using System.Collections.Generic;
using System.Threading;

// This class manages all the lifts

namespace SkiResort {
	public class LiftLine {
		public Dictionary<double, Lift> Lifts = new Dictionary<double, Lift>();

		public int PeoplePerLift; // How many can go in 1 lift
		public TimeSpan TimeInLift; // In ms
		public TimeSpan TimePerLift; // in MS

		public long ID { get; private set; }
		public string Name { get; private set; }

		public long DestinationID { get; private set; } // ID of the Slope we're going to.
		public long StartID { get; private set; } // ID of the Slope we're going to.

		public List<Skiier> InQue = new List<Skiier>();
		public int InLifts = 0;

		Thread thisThread;
		Resort Resort;

		public LiftLine(Resort resort, string name, long destID, long startID, int ppl, TimeSpan til, TimeSpan tpl) {
			this.Name = name;
			this.DestinationID = destID;
			this.StartID = startID;

			this.PeoplePerLift = ppl;
			this.TimeInLift = til;
			this.TimePerLift = tpl;

			this.Resort = resort;

			thisThread = new Thread(RunLift);
			thisThread.Start();
		}

		public void RunLift() {
			while (Resort.IsOpen) {
				int InLift;
				if (InQue < PeoplePerLift) {
					InLift = InQue;
					InQue = 0;
				} else {
					InQue = InQue - PeoplePerLift;
					InLift = PeoplePerLift;
				}

				InLifts += 25;
				Lift newLift = new Lift(Resort, this, InLift, TimeInLift, DestinationID);
				Lifts.Add(newLift.ID, newLift); Resort.Event("Lift created by " + this.Name);

				Thread.Sleep(TimePerLift);
			}
		}
	}
}
