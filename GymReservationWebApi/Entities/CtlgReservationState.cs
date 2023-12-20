namespace GymReservationWebApi.Entities
{
    public class CtlgReservationState
    {
        public int Id { get; set; }

        #region Sign properties

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public int EntityState { get; set; }

        #endregion

        public string Name { get; set; }
    }
}
