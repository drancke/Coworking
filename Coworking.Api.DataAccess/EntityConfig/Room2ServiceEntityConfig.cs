using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
   public class Room2ServiceEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Room2ServiceEntity> entityBuilder)
        {
            entityBuilder.ToTable("Room2Service");

            entityBuilder.HasOne(x => x.Service).WithMany(x => x.Room2Services).HasForeignKey(x => x.IdService);
            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Room2Services).HasForeignKey(x => x.IdRoom);

            entityBuilder.HasKey(x => new { x.IdService, x.IdRoom });
            entityBuilder.Property(x => x.IdService).IsRequired();
            entityBuilder.Property(x => x.IdRoom).IsRequired();
        }

    }
}
