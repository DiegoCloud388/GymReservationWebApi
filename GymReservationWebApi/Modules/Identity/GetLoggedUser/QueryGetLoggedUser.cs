using MediatR;

namespace GymReservationWebApi.Modules.Identity.GetLoggedUser
{
    public class QueryGetLoggedUser : IRequest<ResultLoggedUser>
    {
        public string Email { get; set; }

        public QueryGetLoggedUser(string email)
        {
            Email = email;
        }
    }
}
