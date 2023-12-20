namespace GymReservationWebApi.Modules.Identity.LoginUser
{
    public class ResultLoginUser
    {
        public string AccessToken { get; set; }

        public DateTime Expiration { get; set; }
    }
}
