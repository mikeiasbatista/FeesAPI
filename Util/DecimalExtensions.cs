using System;

namespace Extensions
{
    public static class DecimalExtensions
    {
        public static decimal TruncateWithPrecision(this decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal tmp = Math.Truncate(step * value);
            return tmp / step;
        }
    }
}
