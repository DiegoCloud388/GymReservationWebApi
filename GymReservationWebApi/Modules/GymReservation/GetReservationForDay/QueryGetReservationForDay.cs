using MediatR;

namespace GymReservationWebApi.Modules.GymReservation.GetReservationForDay
{
    public class QueryGetReservationForDay : IRequest<IList<ResultGetReservationForDay>>
    {
        public DateTime SelectedDay { get; set; }

        public QueryGetReservationForDay(DateTime selectedDay)
        {
            SelectedDay = selectedDay;
        }
    }
}
