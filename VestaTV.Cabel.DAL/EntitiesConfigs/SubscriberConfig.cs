using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.EntitiesConfigs
{
    class SubscriberConfig : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            builder.HasIndex(e => e.CityId)
                    .HasName("IX_CityId");

            builder.HasIndex(e => e.NumberOfContract)
                .HasName("IX_NumberOfContract")
                .IsUnique();

            builder.HasIndex(e => e.StreetId)
                .HasName("IX_StreetId");

            builder.Property(e => e.ContractDate).HasColumnType("datetime");

            builder.HasOne(d => d.City)
                .WithMany(p => p.Subscribers)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_dbo.Subscribers_dbo.Cities_CityId");

            builder.HasOne(d => d.Street)
                .WithMany(p => p.Subscribers)
                .HasForeignKey(d => d.StreetId)
                .HasConstraintName("FK_dbo.Subscribers_dbo.Streets_StreetId");
        }
    }
}
