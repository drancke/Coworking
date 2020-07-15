using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
   public class AdminEntityConfig
    {

        public static void SetEntityBuilder (EntityTypeBuilder<AdminEntity> entityBuilder)
        {
            entityBuilder.ToTable("Admin");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            entityBuilder
              .HasOne(b => b.Office)
              .WithOne(x => x.Admin)
              .HasForeignKey<OfficeEntity>(x => x.IdAdmin);

        }
    }
}
