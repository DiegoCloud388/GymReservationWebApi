using MediatR;

namespace GymReservationWebApi.Modules.GymReservation.GetReservationByUser
{
    public class QueryGetReservationByUser : IRequest<IList<ResultGetReservationByUser>>
    {
        public bool OnlyActive { get; set; }

        public string UserId { get; set; }

        public QueryGetReservationByUser(bool onlyActive, string userId)
        {
            OnlyActive = onlyActive;
            UserId = userId;
        }
    }
}
