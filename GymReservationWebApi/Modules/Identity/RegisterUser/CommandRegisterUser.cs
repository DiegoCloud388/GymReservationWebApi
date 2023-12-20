using MediatR;
using System.ComponentModel.DataAnnotations;

namespace GymReservationWebApi.Modules.Identity.RegisterUser
{
    public class CommandRegisterUser : IRequest<ResultRegisterUser>
    {
        [Required(ErrorMessage = "Jméno je povinné pole")]
        [MaxLength(256, ErrorMessage = "Jméno může mít maximálné 256 znaků")]
        [MinLength(2, ErrorMessage = "Jméno musí mít minimálně 2 znaky")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Příjmení je povinné pole")]
        [MaxLength(256, ErrorMessage = "Příjmení může mít maximálné 256 znaků")]
        [MinLength(2, ErrorMessage = "Příjmení musí mít minimálně 2 znaky")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Heslo je povinné pole")]
        [MinLength(4, ErrorMessage = "Heslo musí mít minimálně 4 znaky")]
        public string Password { get; set; }

        [MaxLength(256, ErrorMessage = "Email může mít maximálné 256 znaků")]
        public string Email { get; set; }

        public CommandRegisterUser(string firstName, string lastName, string password, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
        }
    }
}
