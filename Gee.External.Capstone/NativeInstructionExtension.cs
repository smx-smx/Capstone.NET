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
            Func<Instruction<TArchitectureInstruction, TArchitectureRegister, TArchitectureGroup, TArchitectureDetail>> ctor
            ) {
            //var @object = new Instruction<TArchitectureInstruction, TArchitectureRegister, TArchitectureGroup, TArchitectureDetail>();
            var @object = ctor();
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
            Func<Instruction<ArmInstruction, ArmRegister, ArmInstructionGroup, ArmInstructionDetail>> ctor) {
            //var @object = @this.AsInstruction<ArmInstruction, ArmRegister, ArmInstructionGroup, ArmInstructionDetail>();
            var @object = ctor();
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
            Func<Instruction<Arm64Instruction, Arm64Register, Arm64InstructionGroup, Arm64InstructionDetail>> ctor)
        {
            //var @object = @this.AsInstruction<Arm64Instruction, Arm64Register, Arm64InstructionGroup, Arm64InstructionDetail>();
            var @object = ctor();
            @object.Id = (Arm64Instruction) @this.Id;
            return @object;
        }

		public static Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail> AsPowerPcInstruction(
            this NativeInstruction @this,
            Func<Instruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail>> ctor)
        {
            //var @object = @this.AsInstruction<PowerPcInstruction, PowerPcRegister, PowerPcInstructionGroup, PowerPcInstructionDetail>();
            var @object = ctor();
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
            Func<Instruction<X86Instruction, X86Register, X86InstructionGroup, X86InstructionDetail>> ctor) {
            //var @object = @this.AsInstruction<X86Instruction, X86Register, X86InstructionGroup, X86InstructionDetail>();
            var @object = ctor();
            @object.Id = (X86Instruction) @this.Id;

            return @object;
        }
    }
}