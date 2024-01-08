namespace GymReservationWebApi.Modules.GymReservation.GetReservationForDate
{
    public class ResultGetReservationForDate
    {
        public int Id { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public bool IsReserved { get; set; }
    }
}
