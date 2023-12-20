namespace GymReservationWebApi.Modules.GymReservation.GetReservationForDay
{
    public class ResultGetReservationForDay
    {
        public int Id { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public bool IsReserved { get; set; }
    }
}
