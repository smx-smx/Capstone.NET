using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	[Flags]
	public enum PowerPcBranchCode {
		INVALID = 0,
		LT = (0 << 5) | 12,
		LE = (1 << 5) | 4,
		EQ = (2 << 5) | 12,
		GE = (0 << 5) | 4,
		GT = (1 << 5) | 12,
		NE = (2 << 5) | 4,
		UN = (3 << 5) | 12,
		NU = (3 << 5) | 4,

		// extra conditions
		SO = (4 << 5) | 12,  // summary overflow
		NS = (4 << 5) | 4,   // not summary overflow
	}
}
