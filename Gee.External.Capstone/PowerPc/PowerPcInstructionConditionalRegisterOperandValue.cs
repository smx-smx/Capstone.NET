namespace Gee.External.Capstone.PowerPc
{
	public sealed class PowerPcInstructionConditionalRegisterOperandValue
	{
		public PowerPcRegister Register { get; internal set; }
		public uint Scale { get; internal set; }
		public PowerPcBranchCondition BranchCondition { get; internal set; }

		/// <summary>
		///     Create a PowerPc Instruction Conditional Register Operand Value.
		/// </summary>
		internal PowerPcInstructionConditionalRegisterOperandValue() { }
	}
}