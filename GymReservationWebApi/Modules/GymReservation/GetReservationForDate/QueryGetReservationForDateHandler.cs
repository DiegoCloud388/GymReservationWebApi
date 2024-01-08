using GymReservationWebApi.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GymReservationWebApi.Modules.GymReservation.GetReservationForDate
{
    public class QueryGetReservationForDateHandler : IRequestHandler<QueryGetReservationForDate, IList<ResultGetReservationForDate>>
    {
        private readonly ReservationDbContext dbContext;

        public QueryGetReservationForDateHandler(ReservationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IList<ResultGetReservationForDate>> Handle(QueryGetReservationForDate request, 
            CancellationToken cancellationToken)
        {
            IList<ResultGetReservationForDate>? resultReservationTimes = null;

            var queryGymReservation = dbContext.GymReservations
                .Where(e => e.ReservationDate == DateOnly.FromDateTime(request.SelectedDate.Date));

            var queryReservationTimes = dbContext.ReservationTime.AsQueryable();

            resultReservationTimes = await queryReservationTimes.Select(d => new ResultGetReservationForDate()
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
