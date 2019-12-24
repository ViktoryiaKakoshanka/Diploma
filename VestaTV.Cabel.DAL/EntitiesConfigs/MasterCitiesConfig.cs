using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.EntitiesConfigs
{
    class MasterCitiesConfig : IEntityTypeConfiguration<MasterCities>
    {
        public void Configure(EntityTypeBuilder<MasterCities> builder)
        {
            builder.HasKey(e => new { e.MasterId, e.CityId })
                    .HasName("PK_dbo.MasterCities");

            builder.HasIndex(e => e.CityId)
                .HasName("IX_City_Id");

            builder.HasIndex(e => e.MasterId)
                .HasName("IX_Master_Id");

            builder.Property(e => e.MasterId).HasColumnName("Master_Id");

            builder.Property(e => e.CityId).HasColumnName("City_Id");

            builder.HasOne(d => d.City)
                .WithMany(p => p.Masters)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_dbo.MasterCities_dbo.Cities_City_Id");

            builder.HasOne(d => d.Master)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK_dbo.MasterCities_dbo.Masters_Master_Id");
        }
    }
}
