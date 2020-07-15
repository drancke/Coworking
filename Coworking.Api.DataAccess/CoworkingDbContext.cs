using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess
{
   public class CoworkingDbContext : DbContext,ICoworkingDbContext
    {

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<Office2RoomEntity> Office2Rooms { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<Room2ServiceEntity> Room2Services { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<BookingEntity> bookingEntities { get; set; }


        public CoworkingDbContext(DbContextOptions options) :base(options)
        {
       
        }

        public CoworkingDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<AdminEntity>());
            RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<RoomEntity>());
            OfficeEntityConfig.SetEntityBuilder(modelBuilder.Entity<OfficeEntity>());
            BookingEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingEntity>());
            ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<ServiceEntity>());
            Office2RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<Office2RoomEntity>());
            Room2ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<Room2ServiceEntity>());
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
