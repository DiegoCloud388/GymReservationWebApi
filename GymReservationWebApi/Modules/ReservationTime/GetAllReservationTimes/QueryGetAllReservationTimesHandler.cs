using GymReservationWebApi.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GymReservationWebApi.Modules.ReservationTime.GetAllReservationTimes
{
    public class QueryGetAllReservationTimesHandler : IRequestHandler<QueryGetAllReservationTimes, IList<ResultGetAllReservationTimes>>
    {
        private readonly ReservationDbContext dbContext;

        public QueryGetAllReservationTimesHandler(ReservationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IList<ResultGetAllReservationTimes>> Handle(QueryGetAllReservationTimes request, CancellationToken cancellationToken)
        {
            var query = dbContext.ReservationTime.AsQueryable();

            if (request.OnlyActive)
                query.Where(e => e.EntityState == 1);

            var result = await query.Select(e => new ResultGetAllReservationTimes
            {
                Id = e.Id,
                StartTime = e.StartTime.ToString(),
                EndTime = e.EndTime.ToString(),
            }).ToListAsync(cancellationToken);

            return result;
        }
    }
}
