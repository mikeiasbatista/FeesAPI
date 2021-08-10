using Extensions;
using System;

namespace Helper
{
    public static class CalculationHelper
    {
        public static double CalculateCompoundInterest(decimal juros, decimal vlrInicial, int tempo)
        {
            var value = Convert.ToDouble(1.00M + juros);
            value = Math.Pow(value, tempo);

            var result = Convert.ToDecimal(value) * vlrInicial;

            // Truncado (sem arredondamento) em duas casas decimais
            return Convert.ToDouble(result.TruncateWithPrecision(2));
        }
    }
}
