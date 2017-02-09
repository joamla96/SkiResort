namespace SkiResort {
	internal interface IPlace {
		int Weight { get; }
		int Que { get; }

		void TakePassenger();
	}
}