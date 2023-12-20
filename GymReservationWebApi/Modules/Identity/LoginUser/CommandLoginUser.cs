using MediatR;
using System.ComponentModel.DataAnnotations;

namespace GymReservationWebApi.Modules.Identity.LoginUser
{
    public class CommandLoginUser : IRequest<ResultLoginUser>
    {
        [Required(ErrorMessage = "Email je povinné pole")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Heslo je povinné pole")]
        public string Password { get; set; }

        public bool RememberLogin { get; set; }

        public CommandLoginUser(string email, string password, bool rememberLogin)
        {
            Email = email;
            Password = password;
            RememberLogin = rememberLogin;
        }
    }
}
