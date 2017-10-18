using System;

namespace Calculator
{

    public class Calculator
    {
        private Func<int, int, int> _сalculatorType;

        public Calculator(Func<int, int, int> сalculatorType)
        {
            _сalculatorType = сalculatorType;
        }

        public int Calculate(int x, int y)
        {
            return _сalculatorType(x, y);
        }

    }
}
