using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
   public class Office2RoomEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Office2RoomEntity> entityBuilder)
        {
            entityBuilder.ToTable("Office2Room");

            entityBuilder.HasOne(x => x.Office).WithMany(x => x.Office2Room).HasForeignKey(x => x.IdOffice);
            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Office2Room).HasForeignKey(x => x.IdRoom);

            entityBuilder.HasKey(x => new { x.IdOffice, x.IdRoom });
            entityBuilder.Property(x => x.IdOffice).IsRequired();
            entityBuilder.Property(x => x.IdRoom).IsRequired();
        }

    }
}
