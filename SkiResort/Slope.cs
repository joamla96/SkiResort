﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResort {
	public class Slope : IPlace {
		public string Name { get; private set; }
		public int OnSlope { get; private set; }
		public int Weight { get; private set; }
		public Slope() {

		}
	}
}
