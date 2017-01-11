using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	public enum PowerPcBranchHint {
		Invalid = 0, // no hint
		Plus,    // PLUS hint
		Minus,   // MINUS hint
	}
}
