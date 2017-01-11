using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	[Flags]
	public enum PowerPcBranchCondition {
		Invalid			= 0,
		LessThan		= (0 << 5) | 12,
		LessOrEqual		= (1 << 5) | 4,
		Equal			= (2 << 5) | 12,
		GreaterOrEqual	= (0 << 5) | 4,
		GreaterThan		= (1 << 5) | 12,
		NotEqual		= (2 << 5) | 4,
		Unordered		= (3 << 5) | 12,
		NotUnordered	= (3 << 5) | 4,

		// extra conditions
		SummaryOverflow = (4 << 5) | 12,  // summary overflow
		NotSummaryOverflow = (4 << 5) | 4,   // not summary overflow
	}
}
