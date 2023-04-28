using HKCR.Application.Common.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HKCR.API.Controllers
{
    [ApiController]

    public class CarController : ControllerBase
    {
        [HttpPost]
        [Route("/api/v1/cars")]
        public async Task<ResponseDto> AddCarDetails([FromBody] CarRequestDto model)
        {
            var result = await AddCarDetails(model);
            return result;
        }
    }
}
