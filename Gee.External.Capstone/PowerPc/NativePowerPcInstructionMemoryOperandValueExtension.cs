using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc
{
	public static class NativePowerPcInstructionOperandExtension
	{
		public static PowerPcInstructionOperand AsPowerPcInstructionOperand(this NativePowerPcInstructionOperand @this)
		{
			var @object = new PowerPcInstructionOperand();
			@object.Type = (PowerPcInstructionOperandType)@this.Type;

			// Set Values.
			//
			// ...
			switch (@object.Type)
			{
			case PowerPcInstructionOperandType.Immediate:
				@object.ImmediateValue = @this.Value.Immediate;
				break;
			case PowerPcInstructionOperandType.Memory:
				@object.MemoryValue = @this.Value.Memory.AsPowerPcInstructionMemoryOperandValue();
				break;
			case PowerPcInstructionOperandType.Register:
				@object.RegisterValue = (PowerPcRegister)@this.Value.Register;
				break;
			case PowerPcInstructionOperandType.ConditionalRegister:
				@object.ConditionalRegisterValue = @this.Value.ConditionRegister.AsPowerPcInstructionConditionalRegisterOperandValue();
				break;
			}

			return @object;
		}
	}
}
