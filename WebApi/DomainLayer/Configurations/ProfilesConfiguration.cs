using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class ProfilesConfiguration : IEntityTypeConfiguration<Profiles>
    {
        public void Configure(EntityTypeBuilder<Profiles> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(200);
            builder.Property(m => m.Age).IsRequired().HasDefaultValue(1);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CreateDate).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
