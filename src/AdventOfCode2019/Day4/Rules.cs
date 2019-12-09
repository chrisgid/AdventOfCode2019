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
    }
}
