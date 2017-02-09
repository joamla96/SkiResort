using System;

namespace SkiResort {
	public static class KeyGenerator {
		public static long NextID {
			get {
				return GetID();
			}
		}

		private static long GetID() {
			DateTime Now = DateTime.Now;
			Random rnd = new Random();

			return long.Parse(rnd.Next(1, 1000).ToString() + // Some random numbers first :)
				Now.Year.ToString() +
				Now.Month.ToString() +
				Now.Day.ToString() +
				Now.Hour.ToString() +
				Now.Minute.ToString() +
				Now.Second.ToString() +
				Now.Millisecond.ToString());
		}
	}
}