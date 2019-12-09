using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.Day4
{
    public static class PasswordValidator
    {
        public static bool IsValid(int password)
        {
            throw new NotImplementedException();

            return HasAdjacentDigits(password) && HasIncreasingDigits(password);
        }

        public static bool HasAdjacentDigits(int password)
        {
            throw new NotImplementedException();
        }

        public static bool HasIncreasingDigits(int password)
        {
            throw new NotImplementedException();

            var prevMod10 = password % 10;
            var div10 = password / 10;
            var nextMod10 = div10 % 10;

            while (div10 > 0)
            {
                if (!(prevMod10 >= nextMod10))
                {
                    return false;
                }

                div10 /= 10;
            }

            return true;
        }
    }
}
