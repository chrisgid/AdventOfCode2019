namespace AdventOfCode2019.Day4
{
    public static class Rules
    {
        public static bool HasAdjacentDigits(int password)
        {
            var lastDigit = password % 10;
            var passwordMinusLastDigit = password / 10;

            while (passwordMinusLastDigit > 0)
            {
                var nextLastDigit = passwordMinusLastDigit % 10;

                if (lastDigit == nextLastDigit)
                {
                    return true;
                }

                lastDigit = nextLastDigit;

                passwordMinusLastDigit /= 10;
            }

            return false;
        }

        public static bool HasIncreasingDigits(int password)
        {
            var lastDigit = password % 10;
            var passwordMinusLastDigit = password / 10;

            while (passwordMinusLastDigit > 0)
            {
                var nextLastDigit = passwordMinusLastDigit % 10;

                if (lastDigit < nextLastDigit)
                {
                    return false;
                }

                lastDigit = nextLastDigit;

                passwordMinusLastDigit /= 10;
            }

            return true;
        }

        public static bool HasPartTwoAdjacentDigits(int password)
        {
            var lastDigit = password % 10;
            var passwordMinusLastDigit = password / 10;

            var adjacentDigitCount = 1;
            var nextLastDigit = 0;

            while (passwordMinusLastDigit > 0)
            {
                nextLastDigit = passwordMinusLastDigit % 10;

                if (lastDigit == nextLastDigit)
                {
                    adjacentDigitCount++;
                }
                else if (lastDigit != nextLastDigit && adjacentDigitCount == 2)
                {
                    return true;
                }
                else
                {
                    adjacentDigitCount = 1;
                }

                lastDigit = nextLastDigit;

                passwordMinusLastDigit /= 10;
            }

            if (lastDigit == nextLastDigit && adjacentDigitCount == 2)
            {
                return true;
            }

            return false;
        }
    }
}
