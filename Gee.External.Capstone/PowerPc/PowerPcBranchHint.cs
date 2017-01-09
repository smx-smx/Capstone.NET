using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	public enum PowerPcBranchHint {
		INVALID = 0, // no hint
		PLUS,    // PLUS hint
		MINUS,   // MINUS hint
	}
}
