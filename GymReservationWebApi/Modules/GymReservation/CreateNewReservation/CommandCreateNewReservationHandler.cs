using GymReservationWebApi.Context;
using GymReservationWebApi.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace GymReservationWebApi.Modules.GymReservation.CreateNewReservation
{
    public class CommandCreateNewReservationHandler : IRequestHandler<CommandCreateNewReservation, ResultCreateNewReservation>
    {
        private readonly ReservationDbContext dbContext;
        private readonly UserManager<User> userManager;

        public CommandCreateNewReservationHandler(ReservationDbContext dbContext, 
            UserManager<User> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public async Task<ResultCreateNewReservation> Handle(CommandCreateNewReservation command, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByIdAsync(command.UserId);

            if(user != null)
            {
                Entities.GymReservation reservation = new Entities.GymReservation
                {
                    CreatedBy = command.UserId.ToString(),
                    CreatedDate = DateTime.UtcNow,
                    EntityState = 1,
                    ReservationStateId = 1,
                    User = user,
                    ReservationTimeId = command.ReservationTimeId,
                    ReservationServiceId = command.ReservationServiceId,
                };

                var result = await dbContext.GymReservations.AddAsync(reservation);

                await dbContext.SaveChangesAsync();

                return new ResultCreateNewReservation { ReservationId = result.Entity.Id };
            }
            else
            {
                return new ResultCreateNewReservation();
            }
        }
    }
}
