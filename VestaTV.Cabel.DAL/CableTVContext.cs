using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VestaTV.Cabel.DAL.Entities;

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
        public virtual DbSet<UserAction> UserActions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewCityTest> ViewCityTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CableTV;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CableTvProblem>(entity =>
            {
                entity.ToTable("CableTVProblems");
            });

            modelBuilder.Entity<MasterCities>(entity =>
            {
                entity.HasKey(e => new { e.MasterId, e.CityId })
                    .HasName("PK_dbo.MasterCities");

                entity.HasIndex(e => e.CityId)
                    .HasName("IX_City_Id");

                entity.HasIndex(e => e.MasterId)
                    .HasName("IX_Master_Id");

                entity.Property(e => e.MasterId).HasColumnName("Master_Id");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MasterCities)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.MasterCities_dbo.Cities_City_Id");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.MasterCities)
                    .HasForeignKey(d => d.MasterId)
                    .HasConstraintName("FK_dbo.MasterCities_dbo.Masters_Master_Id");
            });

            modelBuilder.Entity<OrderOnCableTV>(entity =>
            {
                entity.ToTable("OrderOnCableTVs");

                entity.HasIndex(e => e.CableTvproblemId)
                    .HasName("IX_CableTVProblemId");

                entity.HasIndex(e => e.MasterId)
                    .HasName("IX_MasterId");

                entity.HasIndex(e => e.SubscriberId)
                    .HasName("IX_SubscriberId");

                entity.Property(e => e.CableTvproblemId).HasColumnName("CableTVProblemId");

                entity.Property(e => e.CallbackDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.HasOne(d => d.CableTvproblem)
                    .WithMany(p => p.OrderOnCableTvs)
                    .HasForeignKey(d => d.CableTvproblemId)
                    .HasConstraintName("FK_dbo.OrderOnCableTVs_dbo.CableTVProblems_CableTVProblemId");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.OrderOnCableTvs)
                    .HasForeignKey(d => d.MasterId)
                    .HasConstraintName("FK_dbo.OrderOnCableTVs_dbo.Masters_MasterId");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.OrderOnCableTvs)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("FK_dbo.OrderOnCableTVs_dbo.Subscribers_SubscriberId");
            });

            modelBuilder.Entity<OrderRepairAndRestruction>(entity =>
            {
                entity.HasIndex(e => e.CityId)
                    .HasName("IX_CityId");

                entity.HasIndex(e => e.MasterPerformerId)
                    .HasName("IX_MasterPerformerId");

                entity.HasIndex(e => e.ResponsibleMasterId)
                    .HasName("IX_ResponsibleMasterId");

                entity.HasIndex(e => e.StreetId)
                    .HasName("IX_StreetId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.DateOfCallback).HasColumnType("datetime");

                entity.Property(e => e.DateOfCreation).HasColumnType("datetime");

                entity.Property(e => e.DateOfExecution).HasColumnType("datetime");

                entity.Property(e => e.EstimatedCompletionDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.OrderRepairAndRestructions)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Cities_CityId");

                entity.HasOne(d => d.MasterPerformer)
                    .WithMany(p => p.OrderRepairAndRestructionsMasterPerformer)
                    .HasForeignKey(d => d.MasterPerformerId)
                    .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Masters_MasterPerformerId");

                entity.HasOne(d => d.ResponsibleMaster)
                    .WithMany(p => p.OrderRepairAndRestructionsResponsibleMaster)
                    .HasForeignKey(d => d.ResponsibleMasterId)
                    .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Masters_ResponsibleMasterId");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.OrderRepairAndRestructions)
                    .HasForeignKey(d => d.StreetId)
                    .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Streets_StreetId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderRepairAndRestructions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.OrderRepairAndRestructions_dbo.Users_UserId");
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.HasIndex(e => e.CityId)
                    .HasName("IX_City_Id");

                entity.Property(e => e.CityId).HasColumnName("City_Id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Streets)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.Streets_dbo.Cities_City_Id");
            });

            modelBuilder.Entity<SubscriberRelationship>(entity =>
            {
                entity.HasIndex(e => e.SubscriberId)
                    .HasName("IX_SubscriberId");

                entity.Property(e => e.RelationshipDate).HasColumnType("datetime");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.SubscriberRelationships)
                    .HasForeignKey(d => d.SubscriberId)
                    .HasConstraintName("FK_dbo.SubscriberRelationships_dbo.Subscribers_SubscriberId");
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.HasIndex(e => e.CityId)
                    .HasName("IX_CityId");

                entity.HasIndex(e => e.NumberOfContract)
                    .HasName("IX_NumberOfContract")
                    .IsUnique();

                entity.HasIndex(e => e.StreetId)
                    .HasName("IX_StreetId");

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Subscribers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.Subscribers_dbo.Cities_CityId");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.Subscribers)
                    .HasForeignKey(d => d.StreetId)
                    .HasConstraintName("FK_dbo.Subscribers_dbo.Streets_StreetId");
            });

            modelBuilder.Entity<UserAction>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.DateOfAction).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserActions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserActions_dbo.Users_UserId");
            });

            modelBuilder.Entity<ViewCityTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_City_Test");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
