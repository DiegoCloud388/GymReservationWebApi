using Microsoft.AspNetCore.Identity;

namespace GymReservationWebApi.Entities.Identity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Comment { get; set; }

        public string CreatorUserId { get; set; }

        public DateTime CreationDate { get; set; }

        public string? LastModifierUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public bool IsActive { get; set; }

        public bool AutomaticLogonEnabled { get; set; }
    }
}
