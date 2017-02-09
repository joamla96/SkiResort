using System;
using System.Threading;
using SkiResort;
using System.Collections.Generic;

namespace UserInterface.CLI {
	class Program {
		private bool running = true;
		Resort ResortA = new Resort();
		static void Main(string[] args) {
			Program program = new Program();
			program.Run();
		}

		private void Run() {
			while (running) {
				Console.Clear();

				Console.WriteLine("Skiiers on Slopes:");
				if (ResortA.Slopes.Count > 0) {
					int TotalSkiiers = 0;
					foreach (KeyValuePair<long, Slope> Slope in ResortA.Slopes) {
						Console.Write(Slope.Value.Name + ": ");
						Console.WriteLine(Slope.Value.Skiiers.ToString());
						TotalSkiiers = Slope.Value.Skiiers.Count;
					}
					Console.WriteLine("Total Skiiers: " + TotalSkiiers);
				} else Console.WriteLine("No Slopes Created.");

				Console.WriteLine("\nSkiiers in Ques: ", "");
				if (ResortA.LiftLines.Count > 0) {
					int TotalInQue = 0;
					foreach (KeyValuePair<long, LiftLine> Entry in ResortA.LiftLines) {
						LiftLine Lift = Entry.Value;
						Console.Write(Lift.Name + ": ");
						Console.WriteLine(Lift.InQue.ToString());
						TotalInQue += Lift.InQue.Count;
					}
					Console.WriteLine("Total in Que: " + TotalInQue);


					Console.WriteLine("\nSkiiers in Lifts:", "");
					int TotalInLifts = 0;
					foreach (KeyValuePair<long, LiftLine> Entry in ResortA.LiftLines) {
						LiftLine Lift = Entry.Value;
						Console.Write(Lift.Name + ": ");
						Console.WriteLine(Lift.InLifts.ToString());
						TotalInLifts += Lift.InLifts;
					}
					Console.WriteLine("Total in Lifts: " + TotalInLifts);
				} else Console.WriteLine("No LiftLines Created.", "");

				Console.WriteLine("");
				List<string> Events = new List<string>(ResortA.Eventlog);
				Events.Reverse();
				foreach(string Event in Events) {
					Console.WriteLine(Event);
				}

				Thread.Sleep(1000);
			}
		}

		private void MonitorExit() {
			while (running) {
				ConsoleKeyInfo pk = Console.ReadKey();
				if (pk.Key == ConsoleKey.Escape) {
					ResortA.IsOpen = false;
				}
			}
		}
	}
}
