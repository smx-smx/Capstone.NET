using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	internal sealed class CapstonePowerPcDisassembler : CapstoneDisassembler<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail> {

        Func<Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail>> instrCreator;

        internal CapstonePowerPcDisassembler(
            DisassembleMode mode, 
            Func<Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail>> instrCreator) 
            : base(DisassembleArchitecture.PowerPc, mode)
        {
            this.instrCreator = instrCreator;
        }

		protected override Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail> CreateInstruction(NativeInstruction nativeInstruction) {
			var @object = nativeInstruction.AsPowerPcInstruction(instrCreator);

			// Get Native Instruction's Managed Independent Detail.
			//
			// Retrieves the native instruction's managed independent detail once to avoid having to allocate
			// new memory every time it is retrieved.
			var nativeIndependentInstructionDetail = nativeInstruction.ManagedIndependentDetail;
			if (nativeIndependentInstructionDetail != null) {
				@object.ArchitectureDetail = nativeInstruction.NativePowerPcDetail.AsPowerPcInstructionDetail();
				@object.IndependentDetail = nativeIndependentInstructionDetail.Value.AsPowerPcIndependentInstructionDetail();
			}

			return @object;
		}
	}
}
