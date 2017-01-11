using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc
{
	public sealed class PowerPcInstructionOperand {

		public PowerPcRegister? RegisterValue { get; internal set; }
		public int? ImmediateValue { get; internal set; }
		public PowerPcInstructionMemoryOperandValue MemoryValue { get; internal set; }
		public PowerPcInstructionConditionalRegisterOperandValue ConditionalRegisterValue { get; internal set; }

		/// <summary>
		///     Get Operand's Type.
		/// </summary>
		public PowerPcInstructionOperandType Type { get; internal set; }
		internal PowerPcInstructionOperand() { }
	}
}
