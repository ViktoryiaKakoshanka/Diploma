using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.EntitiesConfigs
{
    class SubscriberRelationshipConfig : IEntityTypeConfiguration<SubscriberRelationshipEntity>
    {
        public void Configure(EntityTypeBuilder<SubscriberRelationshipEntity> builder)
        {
            builder.HasIndex(e => e.SubscriberId)
                    .HasName("IX_SubscriberId");

            builder.Property(e => e.RelationshipDate).HasColumnType("datetime");

            builder.HasOne(d => d.Subscriber)
                .WithMany(p => p.SubscriberRelationships)
                .HasForeignKey(d => d.SubscriberId)
                .HasConstraintName("FK_dbo.SubscriberRelationships_dbo.Subscribers_SubscriberId");
        }
    }
}
