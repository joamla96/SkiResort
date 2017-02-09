using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// This class manages all the lifts

namespace SkiResort {
	class Lift {
		LiftLine Line;
		int Passengers;
		Thread myThread;

		public Lift(LiftLine line) {
			this.Line = line;

			myThread = new Thread(Run);
			myThread.Start();
		}

		public void Run() {
			Passengers = Line.From.TakeLoad(Line.Capacity);
			Thread.Sleep(Line.LiftTime);
			Line.To.GiveLoad(Passengers);			
		}
	}
}
