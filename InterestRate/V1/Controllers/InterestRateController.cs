using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InterestRate.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class InterestRateController : ControllerBase
    {
        [HttpGet]
        [Route("taxaJuros")]
        public async Task<float> GetInterestRate() => 0.01f;
    }
}
