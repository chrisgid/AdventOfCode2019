namespace AdventOfCode2019.Day2
{
    public class Computer
    {
        private const int OPCODE_ADD = 1;
        private const int OPCODE_MULTIPLY = 2;
        private const int OPCODE_HALT = 99;
        private const int STEP_SIZE = 4;

        private const int OFFSET_INPUT1 = 1;
        private const int OFFSET_INPUT2 = 2;
        private const int OFFSET_OUTPUT = 3;

        private int[] _memory;
        private int _instructionPointer;

        public int Run(int[] program, int input1, int input2)
        {
            _memory = (int[]) program.Clone();
            _memory[1] = input1;
            _memory[2] = input2;
            _instructionPointer = 0;

            var opcode = _memory[_instructionPointer];

            while (opcode != OPCODE_HALT)
            {
                switch (opcode)
                {
                    case OPCODE_ADD:
                        ExecuteAdd();
                        break;
                    case OPCODE_MULTIPLY:
                        ExecuteMultiply();
                        break;
                }

                _instructionPointer += STEP_SIZE;
                opcode = _memory[_instructionPointer];
            }

            return _memory[0];
        }

        public int[] GetMemory()
        {
            return _memory;
        }

        private void ExecuteAdd()
        {
            var input1Position = _memory[_instructionPointer + OFFSET_INPUT1];
            var input2Position = _memory[_instructionPointer + OFFSET_INPUT2];
            var outputPosition = _memory[_instructionPointer + OFFSET_OUTPUT];

            var input1 = _memory[input1Position];
            var input2 = _memory[input2Position];

            var output = input1 + input2;

            _memory[outputPosition] = output;
        }

        private void ExecuteMultiply()
        {
            var input1Position = _memory[_instructionPointer + OFFSET_INPUT1];
            var input2Position = _memory[_instructionPointer + OFFSET_INPUT2];
            var outputPosition = _memory[_instructionPointer + OFFSET_OUTPUT];

            var input1 = _memory[input1Position];
            var input2 = _memory[input2Position];

            var output = input1 * input2;

            _memory[outputPosition] = output;
        }
    }
}
