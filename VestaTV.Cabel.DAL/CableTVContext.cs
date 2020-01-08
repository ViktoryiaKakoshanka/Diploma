using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VestaTV.Cabel.DAL.Entities;
using VestaTV.Cabel.DAL.EntitiesConfigs;

namespace VestaTV.Cabel.DAL
{
    public partial class CableTVContext : DbContext
    {
        public CableTVContext()
        {
        }

        public CableTVContext(DbContextOptions<CableTVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CableTvProblemEntity> CableTvproblems { get; set; }
        public virtual DbSet<CityEntity> Cities { get; set; }
        public virtual DbSet<MasterCityEntity> MasterCities { get; set; }
        public virtual DbSet<MasterEntity> Masters { get; set; }
        public virtual DbSet<OrderOnCableTVEntity> OrderOnCableTvs { get; set; }
        public virtual DbSet<OrderRepairAndRestructionEntity> OrderRepairAndRestructions { get; set; }
        public virtual DbSet<StreetEntity> Streets { get; set; }
        public virtual DbSet<SubscriberRelationshipEntity> SubscriberRelationships { get; set; }
        public virtual DbSet<SubscriberEntity> Subscribers { get; set; }
        public virtual DbSet<UserHistoryEntity> UserActions { get; set; }
        public virtual DbSet<UserEntity> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CableTvProblemEntity>(entity =>
            {
                entity.ToTable("CableTVProblems");
            });

            modelBuilder.ApplyConfiguration(new MasterCitiesConfig());
            modelBuilder.ApplyConfiguration(new OrderOnCableTVConfig());
            modelBuilder.ApplyConfiguration(new OrderRepairAndRestructionConfig());
            modelBuilder.ApplyConfiguration(new StreetConfig());
            modelBuilder.ApplyConfiguration(new SubscriberRelationshipConfig());
            modelBuilder.ApplyConfiguration(new SubscriberConfig());
            modelBuilder.ApplyConfiguration(new UserHistoryConfig());
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
