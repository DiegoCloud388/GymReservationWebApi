using MediatR;

namespace GymReservationWebApi.Modules.GymReservation.GetReservationForDate
{
    public class QueryGetReservationForDate : IRequest<IList<ResultGetReservationForDate>>
    {
        public DateTime SelectedDate { get; set; }

        public QueryGetReservationForDate(DateTime selectedDate)
        {
            SelectedDate = selectedDate;
        }
    }
}
