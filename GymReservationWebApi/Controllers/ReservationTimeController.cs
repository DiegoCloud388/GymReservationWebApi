using GymReservationWebApi.Modules.ReservationTime.GetAllReservationTimes;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymReservationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ReservationTimeController : ControllerBase
    {
        private readonly IMediator mediator;

        public ReservationTimeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Get all reservation times
        /// </summary>
        /// <param name="onlyActive"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all-reservation-times")]
        public async Task<ActionResult<IList<ResultGetAllReservationTimes>>> GetAllReservationTimes(
            bool onlyActive = true, CancellationToken cancellationToken = default)
        {
            var query = new QueryGetAllReservationTimes(onlyActive);

            var result = await mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
