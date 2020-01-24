using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.EntitiesConfigs
{
    class UserHistoryConfig : IEntityTypeConfiguration<UserHistoryEntity>
    {
        public void Configure(EntityTypeBuilder<UserHistoryEntity> builder)
        {
            builder.ToTable("UserAction");

            builder.HasIndex(e => e.UserId)
                .HasName("IX_UserId");

            builder.Property(e => e.DateOfAction).HasColumnType("datetime");

            builder.HasOne(d => d.User)
                .WithMany(p => p.UserHistory)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.UserActions_dbo.Users_UserId");
        }
    }
}
