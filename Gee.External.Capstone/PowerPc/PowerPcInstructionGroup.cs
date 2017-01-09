using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	public enum PowerPcInstructionGroup {
		Invalid = 0, // = CS_GRP_INVALID

		//> Generic groups
		// all jump instructions (conditional+direct+indirect jumps)
		JUMP,	// = CS_GRP_JUMP

		//> Architecture-specific groups
		ALTIVEC = 128,
		MODE32,
		MODE64,
		BOOKE,
		NOTBOOKE,
		SPE,
		VSX,
		E500,
		PPC4XX,
		PPC6XX,
	}
}
