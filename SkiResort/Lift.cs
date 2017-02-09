using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// This class manages all the lifts

namespace SkiResort {
	public class Lift {
		LiftLine Line;
		int Passengers;
		Thread myThread;

		public Lift(LiftLine line) {
			this.Line = line;

			myThread = new Thread(Run);
			myThread.Start();
		}

		public void Run() {
			Passengers = Line.TakeLoad();
			Thread.Sleep(new TimeSpan(0, Line.LiftTime, 0));
			Line.To.TakePassenger(Passengers);			
		}
	}
}
