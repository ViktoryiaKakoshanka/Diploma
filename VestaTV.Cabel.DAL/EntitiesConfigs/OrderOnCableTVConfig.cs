using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.EntitiesConfigs
{
    internal class OrderOnCableTVConfig : IEntityTypeConfiguration<OrderOnCableTV>
    {
        public void Configure(EntityTypeBuilder<OrderOnCableTV> builder)
        {
            builder.ToTable("OrderOnCableTVs");

            builder.HasIndex(e => e.CableTvproblemId)
                .HasName("IX_CableTVProblemId");

            builder.HasIndex(e => e.MasterId)
                .HasName("IX_MasterId");

            builder.HasIndex(e => e.SubscriberId)
                .HasName("IX_SubscriberId");

            builder.Property(e => e.CableTvproblemId).HasColumnName("CableTVProblemId");

            builder.Property(e => e.CallbackDate).HasColumnType("datetime");

            builder.Property(e => e.CreationDate).HasColumnType("datetime");

            builder.Property(e => e.EstimatedCompletionDate).HasColumnType("datetime");

            builder.Property(e => e.ExecutionDate).HasColumnType("datetime");

            builder.HasOne(d => d.CableTvproblem)
                .WithMany(p => p.OrderOnCableTvs)
                .HasForeignKey(d => d.CableTvproblemId)
                .HasConstraintName("FK_dbo.OrderOnCableTVs_dbo.CableTVProblems_CableTVProblemId");

            builder.HasOne(d => d.Master)
                .WithMany(p => p.OrderOnCableTvs)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK_dbo.OrderOnCableTVs_dbo.Masters_MasterId");

            builder.HasOne(d => d.Subscriber)
                .WithMany(p => p.OrderOnCableTvs)
                .HasForeignKey(d => d.SubscriberId)
                .HasConstraintName("FK_dbo.OrderOnCableTVs_dbo.Subscribers_SubscriberId");
        }
    }
}
