using System;
using System.Collections.Generic;

namespace AdventOfCode2019.Day4
{
    public class PasswordValidator
    {
        private readonly List<Func<int, bool>> _rules;

        public PasswordValidator()
        {
            _rules = new List<Func<int, bool>>();
        }

        public void AddRule(Func<int, bool> rule)
        {
            _rules.Add(rule);
        }

        public bool Validate(int password)
        {
            var isValid = true;

            foreach (var rule in _rules)
            {
                isValid = isValid && rule.Invoke(password);
            }

            return isValid;
        }
    }
}
