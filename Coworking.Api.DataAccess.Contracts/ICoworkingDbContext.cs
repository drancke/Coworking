using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts
{
    public interface ICoworkingDbContext
    {
         DbSet<UserEntity> Users { get; set; }
         DbSet<AdminEntity> Admins { get; set; }
         DbSet<OfficeEntity> Offices { get; set; }
         DbSet<Office2RoomEntity> Office2Rooms { get; set; }
         DbSet<RoomEntity> Rooms { get; set; }
         DbSet<Room2ServiceEntity> Room2Services { get; set; }
         DbSet<ServiceEntity> Services { get; set; }
         DbSet<BookingEntity> bookingEntities { get; set; }
    }
}
