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
    public class ProfilePicturesConfiguration: IEntityTypeConfiguration<ProfilePictures>
    {
        public void Configure(EntityTypeBuilder<ProfilePictures> builder)
        {
            builder.Property(m => m.Images).IsRequired().HasMaxLength(50);
            builder.Property(m => m.ProfileId).IsRequired().HasDefaultValue(1);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CreateDate).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
