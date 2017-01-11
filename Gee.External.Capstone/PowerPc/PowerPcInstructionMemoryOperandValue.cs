namespace Gee.External.Capstone.PowerPc
{
	public sealed class PowerPcInstructionMemoryOperandValue
	{
		/// <summary>
		///     Get Operand Value's Base Register.
		/// </summary>
		public PowerPcRegister BaseRegister { get; internal set; }

		/// <summary>
		///     Get Operand Value's Displacement Value.
		/// </summary>
		public int Displacement { get; internal set; }

		/// <summary>
		///     Create a PowerPc Instruction Memory Operand Value.
		/// </summary>
		internal PowerPcInstructionMemoryOperandValue() { }
	}
}