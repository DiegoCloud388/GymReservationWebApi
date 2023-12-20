using GymReservationWebApi.Context;
using GymReservationWebApi.Modules.GymReservation.GetReservationByUser;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GymReservationWebApi.Modules.GymReservation.GetReservationsByUser
{
    public class QueryGetReservationByUserHandler : IRequestHandler<QueryGetReservationByUser, IList<ResultGetReservationByUser>>
    {
        private readonly ReservationDbContext dbContext;

        public QueryGetReservationByUserHandler(ReservationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IList<ResultGetReservationByUser>> Handle(QueryGetReservationByUser request, 
            CancellationToken cancellationToken)
        {
            var query = dbContext.GymReservations.Where(e => e.User.Id == request.UserId);

            if (request.OnlyActive)
                query.Where(e => e.EntityState == 1);

            var result = await query.Select(e => new ResultGetReservationByUser
            {
                Id = e.Id,
                ReservationState = e.ReservationState.Name,
                ReservationService = e.ReservationService.Name
            }).ToListAsync(cancellationToken);

            return result;
        }
    }
}
