using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResort {
	public class Resort {
		public Dictionary<long, LiftLine> Lifts;
		public  Dictionary<long, Slope> Slopes;

		public List<string> Events = new List<string>();

		public bool IsOpen = false;
		public Resort() {
			Lifts = new Dictionary<long, LiftLine>();
			Slopes = new Dictionary<long, Slope>();

			Slope AB1 = new Slope("AB1", this, 8 ,2, 20);
			Slope AB2 = new Slope("AB2", this, 8 ,2, 20);

			Slope BC1 = new Slope("AB1", this, 4, 15, 100);

			LiftLine L_AB1 = new LiftLine("L_AB1", this, 2, 10, 25, 50);
			LiftLine L_AB2 = new LiftLine("L_AB2", this, 2, 10, 25, 50);

			LiftLine L_BC1 = new LiftLine("L_BC1", this, 1, 20, 10, 100);

			List<IPlace> IPA = new List<IPlace>();
			List<IPlace> IPB = new List<IPlace>();
			List<IPlace> IPC = new List<IPlace>();
			IPA.Add(L_AB1);
			IPA.Add(L_AB2);

			IPB.Add(L_BC1);
			IPB.Add(AB1);
			IPB.Add(AB2);

			IPC.Add(BC1);

			Point A = new Point("A", IPA);
			Point B = new Point("B", IPB);
			Point C = new Point("C", IPC);

			L_AB1.From = A;
			L_AB1.To = B;

			L_AB2.From = A;
			L_AB2.To = B;

			L_BC1.From = B;
			L_BC1.To = C;

			AB1.To = A;
			AB2.To = A;
			BC1.To = B;

			IsOpen = true;
		}


	}
}
