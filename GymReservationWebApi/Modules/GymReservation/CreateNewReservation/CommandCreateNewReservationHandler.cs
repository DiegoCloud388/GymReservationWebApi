using GymReservationWebApi.Context;
using GymReservationWebApi.Entities;
using GymReservationWebApi.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
            //EntityEntry<Entities.GymReservation> result = null;

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

                if(command.StartDate == command.EndDate)
                    reservation.ReservationDate = DateOnly.FromDateTime(command.StartDate);

                //while(command.EndDate.Day >= command.StartDate.Day)
                //{
                //    reservation.ReservationDate = DateOnly.FromDateTime(command.StartDate);

                //    result = await dbContext.GymReservations.AddAsync(reservation);

                //    command.StartDate = command.StartDate.AddDays(1);
                //}

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
