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

        private int[] _program;
        private int _position;

        public int[] Run(int[] program)
        {
            _program = (int[]) program.Clone();
            _position = 0;

            var opcode = _program[_position];

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

                _position += STEP_SIZE;
                opcode = _program[_position];
            }

            return _program;
        }

        private void ExecuteAdd()
        {
            var input1Position = _program[_position + OFFSET_INPUT1];
            var input2Position = _program[_position + OFFSET_INPUT2];
            var outputPosition = _program[_position + OFFSET_OUTPUT];

            var input1 = _program[input1Position];
            var input2 = _program[input2Position];

            var output = input1 + input2;

            _program[outputPosition] = output;
        }

        private void ExecuteMultiply()
        {
            var input1Position = _program[_position + OFFSET_INPUT1];
            var input2Position = _program[_position + OFFSET_INPUT2];
            var outputPosition = _program[_position + OFFSET_OUTPUT];

            var input1 = _program[input1Position];
            var input2 = _program[input2Position];

            var output = input1 * input2;

            _program[outputPosition] = output;
        }
    }
}
