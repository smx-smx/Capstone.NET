﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gee.External.Capstone.PowerPc {
	public class CapstonePowerPcDisassembler : CapstoneDisassembler<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail> {

        public CapstonePowerPcDisassembler(DisassembleMode mode)
            : base(DisassembleArchitecture.PowerPc, mode)
        {
        }

        public override Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail> CreateManagedInstruction()
        {
            return new Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail>();
        }

        protected override Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail> CreateInstruction(NativeInstruction nativeInstruction) {
			var @object = nativeInstruction.AsPowerPcInstruction(this);

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
