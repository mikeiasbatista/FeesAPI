using System;
using System.Net.Http;
using System.Threading.Tasks;
using Extensions;

namespace CalculateInterestRate.V1.Services
{
    public class InterestRateService
    {
        private const string INTEREST_RATE_URL = "http://localhost:5000/v1/interestrate/taxaJuros";

        internal async Task<double> CalculateInterestRate(decimal vlrInicial, int tempo)
        {
            var juros = await GetInterestRate();

            var value = Convert.ToDouble(1.00M + juros);
            value = Math.Pow(value, tempo);

            var result = Convert.ToDecimal(value) * vlrInicial;

            // Truncado (sem arredondamento) em duas casas decimais
            return Convert.ToDouble(result.TruncateWithPrecision(2));
        }

        private async Task<decimal> GetInterestRate()
        {
            var httpClient = HttpClientFactory.Create();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(INTEREST_RATE_URL);

            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                return await content.ReadAsAsync<decimal>();
            }

            throw new Exception($"Houve um erro ao obter o juros({ httpResponseMessage.StatusCode.GetHashCode() }): { httpResponseMessage.Content }");
        }
    }
}
