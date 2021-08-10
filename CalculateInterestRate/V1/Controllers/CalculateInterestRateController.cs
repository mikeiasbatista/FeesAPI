using System.Threading.Tasks;
using CalculateInterestRate.V1.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculateInterestRate.V1.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class CalculateInterestRateController : ControllerBase
    {
        public InterestRateService interestRateService = null;
        public CodeService codeService = null;

        public CalculateInterestRateController()
        {
            this.interestRateService = new InterestRateService();
            this.codeService = new CodeService();
        }

        [HttpGet]
        [Route("calculajuros")]
        public async Task<double> Calculate(decimal valorinicial, int meses)
        {
            return await this.interestRateService.CalculateInterestRate(valorinicial, meses);
        }

        [HttpGet]
        [Route("showmethecode")]
        public async Task<string> ShowMeTheCode()
        {
            return await this.codeService.GetCodeUrl();
        }
    }
}
