using GymReservationWebApi.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GymReservationWebApi.Modules.GymReservation.GetReservationForDay
{
    public class QueryGetReservationForDayHandler : IRequestHandler<QueryGetReservationForDay, IList<ResultGetReservationForDay>>
    {
        private readonly ReservationDbContext dbContext;

        public QueryGetReservationForDayHandler(ReservationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IList<ResultGetReservationForDay>> Handle(QueryGetReservationForDay request, 
            CancellationToken cancellationToken)
        {
            IList<ResultGetReservationForDay>? resultReservationTimes = null;

            var queryGymReservation = dbContext.GymReservations
                .Where(e => e.ReservationDate == DateOnly.FromDateTime(request.SelectedDay.Date));

            var queryReservationTimes = dbContext.ReservationTime.AsQueryable();

            resultReservationTimes = await queryReservationTimes.Select(d => new ResultGetReservationForDay()
            {
                Id = d.Id,
                StartTime = d.StartTime.ToString(),
                EndTime = d.EndTime.ToString(),
                IsReserved = false
            }).ToListAsync(cancellationToken);

            foreach ( var reservationTime in resultReservationTimes ) 
            {
                if(queryGymReservation != null)
                {
                    if (queryGymReservation.Any(d => d.ReservationTimeId == reservationTime.Id))
                    {
                        reservationTime.IsReserved = true;
                    }
                }                
            }

            return resultReservationTimes;
        }
    }
}
