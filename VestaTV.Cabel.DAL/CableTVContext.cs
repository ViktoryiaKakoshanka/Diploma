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

        public virtual DbSet<CableTvProblem> CableTvproblems { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<MasterCities> MasterCities { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<OrderOnCableTV> OrderOnCableTvs { get; set; }
        public virtual DbSet<OrderRepairAndRestruction> OrderRepairAndRestructions { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<SubscriberRelationship> SubscriberRelationships { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<UserHistory> UserActions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CableTvProblem>(entity =>
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
