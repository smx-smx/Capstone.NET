using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc
{
	public static class NativePowerPcInstructionMemoryOperandValueExtension
	{
		public static PowerPcInstructionMemoryOperandValue AsPowerPcInstructionMemoryOperandValue(this NativePowerPcInstructionMemoryOperandValue @this)
		{
			var @object = new PowerPcInstructionMemoryOperandValue();
			@object.BaseRegister = (PowerPcRegister)@this.BaseRegister;
			@object.Displacement = @this.Displacement;
			return @object;
		}
	}
}
