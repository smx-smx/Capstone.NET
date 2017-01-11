using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc
{
	public static class NativePowerPcInstructionConditionalRegisterOperandValueExtension
	{
		public static PowerPcInstructionConditionalRegisterOperandValue AsPowerPcInstructionConditionalRegisterOperandValue(this NativePowerPcInstructionConditionRegisterOperandValue @this)
		{
			var @object = new PowerPcInstructionConditionalRegisterOperandValue();
			@object.BranchCondition = (PowerPcBranchCondition)@this.BranchCondition;
			@object.Register = (PowerPcRegister)@this.Register;
			@object.Scale = @this.Scale;
			return @object;
		}
	}
}
