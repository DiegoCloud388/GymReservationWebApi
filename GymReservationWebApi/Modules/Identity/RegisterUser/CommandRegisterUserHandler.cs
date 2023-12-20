using GymReservationWebApi.Context;
using GymReservationWebApi.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GymReservationWebApi.Modules.Identity.RegisterUser
{
    public class CommandRegisterUserHandler : IRequestHandler<CommandRegisterUser, ResultRegisterUser>
    {
        private readonly ReservationDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CommandRegisterUserHandler(ReservationDbContext dbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<ResultRegisterUser> Handle(CommandRegisterUser command, CancellationToken cancellationToken)
        {
            var userExists = await userManager.FindByNameAsync(command.Email);
            if (userExists == null)
            {
                User user = new User()
                {
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    UserName = command.Email,
                    Email = command.Email,
                    CreatorUserId = "1",
                    CreationDate = DateTime.Now,
                    IsActive = true,
                    AutomaticLogonEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                var result = await userManager.CreateAsync(user, command.Password);

                if (result.Succeeded)
                {
                    var userEntity = await dbContext.Users.Where(x => x.Id == user.Id).SingleAsync();

                    await dbContext.SaveChangesAsync();

                    return new ResultRegisterUser()
                    {
                        FirstName = userEntity.FirstName,
                        LastName = userEntity.LastName,
                        EmailAddress = userEntity.Email
                    };
                }
                else
                {
                    string message = string.Join(", ", result.Errors.Select(x => $"{x.Code}: {x.Description}"));
                    throw new Exception(message);
                }
            }
            else
            {
                return new ResultRegisterUser();
            }
        }
    }
}
