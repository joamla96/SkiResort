using System;
using SkiResort;
using System.Threading;

namespace UserInterface.CLI {
	class Program {
		Resort Resort = new Resort();

		bool running = true;
		static void Main(string[] args) {
			Program program = new Program();

			Thread MonitorKeys = new Thread(program.MonitorKeys);
			MonitorKeys.Start();

			program.Run();
		}

		private void Run() {
			while(running) {
				foreach(LiftLine lift in Resort.Lifts) {
					Console.WriteLine(lift.Que);
				}
				Thread.Sleep(250);
			}
		}

		private void MonitorKeys() {
			while(running) {
				ConsoleKeyInfo cki = Console.ReadKey();
				switch(cki.Key) {
					case ConsoleKey.Q:
						running = false;
						break;
				}
			}
		}
	}
}
