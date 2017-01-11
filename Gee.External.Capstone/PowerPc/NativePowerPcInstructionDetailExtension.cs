using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	public static class NativePowerPcInstructionDetailExtension {
		public static PowerPcInstructionDetail AsPowerPcInstructionDetail(this NativePowerPcInstructionDetail @this) {
			var @object = new PowerPcInstructionDetail();
            @object.BranchCode = (PowerPcBranchCondition) @this.BranchCode;
            @object.BranchHint = (PowerPcBranchHint) @this.BranchHint;
            @object.OperandCount = @this.OperandCount;
			@object.Operands = @this.ManagedOperands
				.Select(m => m.AsPowerPcInstructionOperand())
				.ToArray();
			@object.UpdateCr0 = @this.UpdateCr0;
			return @object;
		}
	}
}
