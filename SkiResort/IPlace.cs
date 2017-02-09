namespace SkiResort {
	public interface IPlace {
		int Weight { get; }
		int Que { get; }

		void TakePassenger(int Passengers);
	}
}