using GymReservationWebApi.Entities.Identity;

namespace GymReservationWebApi.Entities
{
    public class GymReservation
    {
        public int Id { get; set; }

        #region Sign properties

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public int EntityState { get; set; }

        #endregion

        public DateOnly ReservationDate { get; set; }

        public int ReservationTimeId { get; set; }

        public int ReservationStateId { get; set; }

        public int ReservationServiceId { get; set; }


        public CtlgReservationTime ReservationTime { get; set; }

        public CtlgReservationState ReservationState { get; set; }

        public CtlgReservationService ReservationService { get; set; }

        public User User { get; set; }
    }
}
