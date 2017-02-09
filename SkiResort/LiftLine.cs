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

		Thread thisThread;

		public LiftLine(string name, Point from, Point to, TimeSpan frequency, TimeSpan lifttime, int capacity) {
			this.Name = name;
			this.From = from;
			this.To = to;
			this.Frequency = frequency;
			this.LiftTime = lifttime;
			this.Capacity = capacity;

			thisThread = new Thread(Run);
			thisThread.Start();
		}

		public void Run() {
			int Passengers = From.TakeLoad(Capacity);

			Thread.Sleep(Frequency);
		}
	}
}
