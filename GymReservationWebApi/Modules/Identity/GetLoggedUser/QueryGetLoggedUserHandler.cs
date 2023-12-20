using GymReservationWebApi.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using GymReservationWebApi.Context;
using Microsoft.EntityFrameworkCore;

namespace GymReservationWebApi.Modules.Identity.GetLoggedUser
{
    public class QueryGetLoggedUserHandler : IRequestHandler<QueryGetLoggedUser, ResultLoggedUser>
    {
        private readonly ReservationDbContext dbContext;
        private readonly UserManager<User> userManager;

        public QueryGetLoggedUserHandler(ReservationDbContext dbContext, UserManager<User> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public async Task<ResultLoggedUser> Handle(QueryGetLoggedUser request, CancellationToken cancellationToken)
        {
            var query = dbContext.Users.AsQueryable();

            if (request.Email != null) query = query.Where(x => x.Email == request.Email);

            var result = await query.SingleOrDefaultAsync(cancellationToken);

            if (result != null)
            {
                var userId = await userManager.GetUserIdAsync(result);

                return new ResultLoggedUser()
                {
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    Email = result.Email,
                    Comment = result.Comment,
                    CreationDate = result.CreationDate,
                    CreatorUserId = result.CreatorUserId,
                    AutomaticLogonEnabled = result.AutomaticLogonEnabled,
                    IsActive = result.IsActive,
                    LastModificationTime = result.LastModificationTime,
                    LastModifierUserId = result.LastModifierUserId
                };
            }
            else
            {
                return new ResultLoggedUser();
            }
        }
    }
}
