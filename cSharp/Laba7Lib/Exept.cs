using System;

namespace Laba7Lib
{
    public class Exept
    {
        private double _a, _c, _d;
        public double Result { get; set; }
        public Exept(double a, double c, double d)
        {
            _a = a;
            _c = c;
            _d = d;
        }
        public void Func()
        {
            if (_a / 4 + _c == 0)
                throw new DivideByZeroException("Devision by zero");
            if (2 * _c <= _a)
                throw new ArgumentException("Wrong arguments");
            Result = (Math.Log10(2 * _c - _a) + _d - 152) / (_a / 4 + _c);
        }
    }
}
