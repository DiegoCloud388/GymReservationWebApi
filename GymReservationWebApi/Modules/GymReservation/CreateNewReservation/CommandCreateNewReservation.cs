using MediatR;

namespace GymReservationWebApi.Modules.GymReservation.CreateNewReservation
{
    public class CommandCreateNewReservation : IRequest<ResultCreateNewReservation>
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string UserId { get; set; }

        public int ReservationServiceId { get; set; }

        public int ReservationTimeId { get; set; }

        public CommandCreateNewReservation(DateTime startDate, DateTime endDate, string userId, int reservationServiceId, int reservationTimeId)
        {
            StartDate = startDate;
            EndDate = endDate;
            UserId = userId;
            ReservationServiceId = reservationServiceId;
            ReservationTimeId = reservationTimeId;
        }
    }
}
