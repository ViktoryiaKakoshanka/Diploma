using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.EntitiesConfigs
{
    class StreetConfig : IEntityTypeConfiguration<Street>
    {
        public void Configure(EntityTypeBuilder<Street> builder)
        {
            builder.HasIndex(e => e.CityId)
                    .HasName("IX_City_Id");

            builder.Property(e => e.CityId).HasColumnName("City_Id");

            builder.HasOne(d => d.City)
                .WithMany(p => p.Streets)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_dbo.Streets_dbo.Cities_City_Id");
        }
    }
}
