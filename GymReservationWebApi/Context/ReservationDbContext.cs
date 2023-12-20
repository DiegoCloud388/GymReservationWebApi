using GymReservationWebApi.Converters;
using GymReservationWebApi.Entities;
using GymReservationWebApi.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymReservationWebApi.Context
{
    public class ReservationDbContext : IdentityDbContext<User>
    {
        public DbSet<GymReservation> GymReservations { get; set; }

        public DbSet<CtlgReservationState> ReservationStates { get; set; }

        public DbSet<CtlgReservationService> ReservationServices { get; set; }

        public DbSet<CtlgReservationTime> ReservationTime { get; set; }

        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
        {            
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            base.ConfigureConventions(builder);

            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>();

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CtlgReservationState>().HasData(
                new CtlgReservationState
                {
                    CreatedBy = "system", CreatedDate = DateTime.Now, EntityState = 1, Id = 1, Name = "Reservováno"
                },
                new CtlgReservationState
                {
                    CreatedBy = "system", CreatedDate = DateTime.Now, EntityState = 1, Id = 2, Name = "Zrušeno"
                });

            builder.Entity<CtlgReservationService>().HasData(
                new CtlgReservationService
                { 
                    CreatedBy = "system", CreatedDate = DateTime.Now, EntityState = 1, Id = 1, Name = "Volejbal" 
                },
                new CtlgReservationService
                {
                    CreatedBy = "system", CreatedDate = DateTime.Now, EntityState = 1, Id = 2, Name = "Stolní tenis"
                },
                new CtlgReservationService
                { 
                    CreatedBy = "system", CreatedDate = DateTime.Now, EntityState = 1, Id = 3, Name = "Nohejbal"
                });

            builder.Entity<CtlgReservationTime>().HasData(
                new CtlgReservationTime
                { 
                    CreatedBy = "system", 
                    CreatedDate = DateTime.Now, 
                    EntityState = 1, 
                    Id = 1,
                    StartTime = new TimeOnly(8, 0, 0), 
                    EndTime = new TimeOnly(8, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system", 
                    CreatedDate = DateTime.Now, 
                    EntityState = 1, 
                    Id = 2, 
                    StartTime = new TimeOnly(9, 0, 0), 
                    EndTime = new TimeOnly(9, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 3,
                    StartTime = new TimeOnly(10, 0, 0),
                    EndTime = new TimeOnly(10, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 4,
                    StartTime = new TimeOnly(11, 0, 0),
                    EndTime = new TimeOnly(11, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 5,
                    StartTime = new TimeOnly(12, 0, 0),
                    EndTime = new TimeOnly(12, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 6,
                    StartTime = new TimeOnly(13, 0, 0),
                    EndTime = new TimeOnly(13, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 7,
                    StartTime = new TimeOnly(14, 0, 0),
                    EndTime = new TimeOnly(14, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 8,
                    StartTime = new TimeOnly(15, 0, 0),
                    EndTime = new TimeOnly(15, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 9,
                    StartTime = new TimeOnly(16, 0, 0),
                    EndTime = new TimeOnly(16, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 10,
                    StartTime = new TimeOnly(17, 0, 0),
                    EndTime = new TimeOnly(17, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 11,
                    StartTime = new TimeOnly(18, 0, 0),
                    EndTime = new TimeOnly(18, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 12,
                    StartTime = new TimeOnly(19, 0, 0),
                    EndTime = new TimeOnly(19, 30, 0)
                },
                new CtlgReservationTime
                {
                    CreatedBy = "system",
                    CreatedDate = DateTime.Now,
                    EntityState = 1,
                    Id = 13,
                    StartTime = new TimeOnly(20, 0, 0),
                    EndTime = new TimeOnly(20, 30, 0)
                });

            base.OnModelCreating(builder);
        }
    }
}
