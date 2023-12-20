using GymReservationWebApi.Modules.GymReservation.CreateNewReservation;
using GymReservationWebApi.Modules.GymReservation.GetReservationByUser;
using GymReservationWebApi.Modules.GymReservation.GetReservationForDay;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymReservationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GymReservationController : ControllerBase
    {
        private readonly IMediator mediator;

        public GymReservationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Create new gym reservation
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("create-new-reservation")]
        public async Task<IActionResult> CreateNewReservation(
            [FromBody] CommandCreateNewReservation command, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(command, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Get reservation by user account
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="onlyActive"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-reservation-by-user")]
        public async Task<ActionResult<IList<ResultGetReservationByUser>>> GetReservationByUser(
            string userId, bool onlyActive = true, CancellationToken cancellationToken = default)
        {
            var query = new QueryGetReservationByUser(onlyActive, userId);

            var result = await mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        /// <summary>
        /// Get reservation for selected day and check if is enabled.
        /// </summary>
        /// <param name="selectedDay"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-reservation-for-selected-day")]
        public async Task<ActionResult<IList<ResultGetReservationForDay>>> GetReservationForDay(
            DateTime selectedDay, CancellationToken cancellationToken = default)
        {
            var query = new QueryGetReservationForDay(selectedDay);

            var result = await mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
