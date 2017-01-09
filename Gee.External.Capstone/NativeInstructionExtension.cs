using Gee.External.Capstone.Arm;
using Gee.External.Capstone.Arm64;
using Gee.External.Capstone.PowerPc;
using Gee.External.Capstone.X86;
using System;

namespace Gee.External.Capstone {
    /// <summary>
    ///     Native Instruction Extension.
    /// </summary>
    public static class NativeInstructionExtension {
        /// <summary>
        ///     Convert a Native Instruction to a Dissembled Instruction.
        /// </summary>
        /// <param name="this">
        ///     A native instruction.
        /// </param>
        /// <returns>
        ///     A dissembled instruction.
        /// </returns>
        public static Instruction<TArchitectureInstruction, TArchitectureRegister, TArchitectureGroup, TArchitectureDetail> AsInstruction<TArchitectureInstruction, TArchitectureRegister, TArchitectureGroup, TArchitectureDetail>(
            this NativeInstruction @this,
            CapstoneDisassembler<TArchitectureInstruction, TArchitectureRegister, TArchitectureGroup, TArchitectureDetail> dasm)
        {
            var @object = dasm.CreateManagedInstruction();
            @object.Address = (long) @this.Address;
            @object.Bytes = @this.ManagedBytes;
            @object.Mnemonic = @this.ManagedMnemonic;
            @object.Operand = @this.ManagedOperand;

            return @object;
        }

        /// <summary>
        ///     Create an ARM Dissembled Instruction.
        /// </summary>
        /// <param name="this">
        ///     A native instruction.
        /// </param>
        /// <returns>
        ///     A dissembled instruction.
        /// </returns>
        public static Instruction<ArmInstruction, ArmRegister, ArmInstructionGroup, ArmInstructionDetail> AsArmInstruction(
            this NativeInstruction @this,
            CapstoneArmDisassembler dasm)
        { 
            var @object = @this.AsInstruction(dasm);
            @object.Id = (ArmInstruction) @this.Id;

            return @object;
        }

        /// <summary>
        ///     Convert a Native Instruction to a ARM64 Dissembled Instruction.
        /// </summary>
        /// <param name="this">
        ///     A native instruction.
        /// </param>
        /// <returns>
        ///     A dissembled instruction.
        /// </returns>
        public static Instruction<Arm64Instruction, Arm64Register, Arm64InstructionGroup, Arm64InstructionDetail> AsArm64Instruction(
            this NativeInstruction @this,
            CapstoneArm64Disassembler dasm)
        {
            var @object = @this.AsInstruction(dasm);
            @object.Id = (Arm64Instruction) @this.Id;
            return @object;
        }

		public static Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail> AsPowerPcInstruction(
            this NativeInstruction @this,
            CapstonePowerPcDisassembler dasm)
        {
            var @object = @this.AsInstruction(dasm);
			@object.Id = (PowerPcInstruction)@this.Id;

			return @object;
		}

		/// <summary>
		///     Convert a Native Instruction to an X86 Dissembled Instruction.
		/// </summary>
		/// <param name="this">
		///     A native instruction.
		/// </param>
		/// <returns>
		///     A dissembled instruction.
		/// </returns>
		public static Instruction<X86Instruction, X86Register, X86InstructionGroup, X86InstructionDetail> AsX86Instruction(
            this NativeInstruction @this,
            CapstoneX86Disassembler dasm)
        {
            var @object = @this.AsInstruction(dasm);
            @object.Id = (X86Instruction) @this.Id;

            return @object;
        }
    }
}