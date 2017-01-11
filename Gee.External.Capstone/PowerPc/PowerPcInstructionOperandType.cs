namespace Gee.External.Capstone.PowerPc
{
	public enum PowerPcInstructionOperandType
	{
		Invalid = 0, // = CS_OP_INVALID (Uninitialized).
		Register, // = CS_OP_REG (Register operand).
		Immediate, // = CS_OP_IMM (Immediate operand).
		Memory, // = CS_OP_MEM (Memory operand).
		ConditionalRegister = 64,    // Condition Register field
	}
}