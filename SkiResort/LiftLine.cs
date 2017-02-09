using System;
using System.Collections.Generic;
using System.Threading;

// This class manages all the lifts

namespace SkiResort {
	public class LiftLine {
		public Point From { get; private set; }
		public Point To { get; private set; }
		public TimeSpan Frequency { get; private set; }
		public TimeSpan LiftTime { get; private set; }
		public int Capacity { get; private set; }
		public string Name { get; private set; }

		Resort Resort;
		Thread thisThread;
		List<Lift> Lifts = new List<Lift>(); // My lifts in progress

		public LiftLine(string name, Resort resort, Point from, Point to, TimeSpan frequency, TimeSpan lifttime, int capacity) {
			this.Name = name;
			this.Resort = resort;
			this.From = from;
			this.To = to;
			this.Frequency = frequency;
			this.LiftTime = lifttime;
			this.Capacity = capacity;

			thisThread = new Thread(Run);
			thisThread.Start();
		}

		public void Run() {
			while (Resort.IsOpen) {
				Lift newLift = new Lift(this);
				Lifts.Add(newLift);
				Thread.Sleep(Frequency);
			}
		}
	}
}
