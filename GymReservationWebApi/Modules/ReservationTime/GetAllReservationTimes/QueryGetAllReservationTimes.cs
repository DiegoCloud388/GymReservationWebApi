using MediatR;

namespace GymReservationWebApi.Modules.ReservationTime.GetAllReservationTimes
{
    public class QueryGetAllReservationTimes : IRequest<IList<ResultGetAllReservationTimes>>
    {
        public bool OnlyActive { get; set; }

        public QueryGetAllReservationTimes(bool onlyActive)
        {
            OnlyActive = onlyActive;
        }
    }
}
