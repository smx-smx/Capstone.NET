using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	public sealed class PowerPcInstructionDetail {
		public PowerPcBranchCode BranchCode { get; internal set; }
		public PowerPcBranchHint BranchHint { get; internal set; }
		public bool UpdateCr0 { get; internal set; }
		public byte OperandCount { get; internal set; }
		public NativePowerPcInstructionOperand[] Operands { get; internal set; }
		internal PowerPcInstructionDetail() { }
	}
}
