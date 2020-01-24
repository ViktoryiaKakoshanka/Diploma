using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.EntitiesConfigs
{
    class OrderRepairAndRestructionConfig : IEntityTypeConfiguration<OrderRepairAndRestructionEntity>
    {
        public void Configure(EntityTypeBuilder<OrderRepairAndRestructionEntity> builder)
        {
            builder.HasIndex(e => e.CityId)
                    .HasName("IX_CityId");

            builder.HasIndex(e => e.MasterPerformerId)
                .HasName("IX_MasterPerformerId");

            builder.HasIndex(e => e.ResponsibleMasterId)
                .HasName("IX_ResponsibleMasterId");

            builder.HasIndex(e => e.StreetId)
                .HasName("IX_StreetId");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_UserId");

            builder.Property(e => e.DateOfCallback).HasColumnType("datetime");

            builder.Property(e => e.DateOfCreation).HasColumnType("datetime");

            builder.Property(e => e.DateOfExecution).HasColumnType("datetime");

            builder.Property(e => e.EstimatedCompletionDate).HasColumnType("datetime");

            builder.HasOne(d => d.City)
                .WithMany(p => p.OrderRepairAndRestructions)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Cities_CityId");

            builder.HasOne(d => d.MasterPerformer)
                .WithMany(p => p.OrderRepairAndRestructionsMasterPerformer)
                .HasForeignKey(d => d.MasterPerformerId)
                .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Masters_MasterPerformerId");

            builder.HasOne(d => d.ResponsibleMaster)
                .WithMany(p => p.OrderRepairAndRestructionsResponsibleMaster)
                .HasForeignKey(d => d.ResponsibleMasterId)
                .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Masters_ResponsibleMasterId");

            builder.HasOne(d => d.Street)
                .WithMany(p => p.OrderRepairAndRestructions)
                .HasForeignKey(d => d.StreetId)
                .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Streets_StreetId");

            builder.HasOne(d => d.User)
                .WithMany(p => p.OrderRepairAndRestructions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Users_UserId");
        }
    }
}
