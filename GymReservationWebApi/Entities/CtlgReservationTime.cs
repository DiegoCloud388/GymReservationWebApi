namespace GymReservationWebApi.Entities
{
    public class CtlgReservationTime
    {
        public int Id { get; set; }

        #region Sign properties

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public int EntityState { get; set; }

        #endregion

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
    }
}
