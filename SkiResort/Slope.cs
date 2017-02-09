using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SkiResort {
	public class Slope : IPlace {
		public string Name { get; private set; }
		public int Que { get; private set; }
		public int TimeMax { get; private set; }
		public int TimeMin { get; private set; }
		public int Weight { get; private set; }

		private Resort Resort;
		private Thread thisThread;
		private Random rnd = new Random();
		public Slope(string name, Resort resort, int timeMax, int timeMin, int weight) {
			this.Name = name;
			this.Resort = resort;
			this.TimeMax = timeMax;
			this.TimeMin = timeMin;
			this.Weight = weight;
		}

		public void Run() {
			while(Resort.IsOpen) {
				Thread.Sleep(new TimeSpan(0, rnd.Next(TimeMin, TimeMax), 0));
				if (Que > 0) {
					Que--;
				}
			}
		}

		public void TakePassenger(int Passenger) {
			Que += Passenger;
		}
	}
}
