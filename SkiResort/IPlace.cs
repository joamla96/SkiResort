using System;
using System.Collections.Generic;

namespace SkiResort {
	public interface IPlace {
		TimeSpan Wait { get; set; }
		int Chance { get; set; }
	}
}