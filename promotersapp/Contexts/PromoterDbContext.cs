using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using promotersapp.Models;

#nullable disable

namespace promotersapp.Contexts
{
    public partial class PromoterDbContext : DbContext
    {
        public PromoterDbContext()
        {
        }

        public PromoterDbContext(DbContextOptions<PromoterDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Discussion> Discussions { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Perk> Perks { get; set; }
        public virtual DbSet<PerksToPromoter> PerksToPromoters { get; set; }
        public virtual DbSet<PersonalDetail> PersonalDetails { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Promoter> Promoters { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<WeekDay> WeekDays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=Promoter_DB_TEST;User=sa;Password=sql67ServerPassword;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Discussion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.PromoterId).HasColumnName("PromoterID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Discussions)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discussions_To_Firms");

                entity.HasOne(d => d.Promoter)
                    .WithMany(p => p.Discussions)
                    .HasForeignKey(d => d.PromoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discussions_To_Promoters");
            });

            modelBuilder.Entity<Firm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rating)
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Firms)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Firms_To_Cities");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Firms)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Firms_To_Users");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DiscussionId).HasColumnName("DiscussionID");

                entity.Property(e => e.Message1)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Message");

                entity.Property(e => e.Notify)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Discussion)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.DiscussionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messages_To_Discussions");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.IsSubscribed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentCode).HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payments_To_Firms");
            });

            modelBuilder.Entity<Perk>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PerkName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PerksToPromoter>(entity =>
            {
                entity.ToTable("PerksToPromoter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PerkId).HasColumnName("PerkID");

                entity.Property(e => e.PromoterId).HasColumnName("PromoterID");

                entity.HasOne(d => d.Perk)
                    .WithMany(p => p.PerksToPromoters)
                    .HasForeignKey(d => d.PerkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerksToPromoter_To_Perks");

                entity.HasOne(d => d.Promoter)
                    .WithMany(p => p.PerksToPromoters)
                    .HasForeignKey(d => d.PromoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerksToPromoter_To_Promoters");
            });

            modelBuilder.Entity<PersonalDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EyeColor).HasMaxLength(20);

                entity.Property(e => e.ForeignLanguage).HasMaxLength(20);

                entity.Property(e => e.ForeignLanguage2).HasMaxLength(20);

                entity.Property(e => e.ForeignLanguage3).HasMaxLength(20);

                entity.Property(e => e.MotherLanguage)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PromoterId).HasColumnName("PromoterID");

                entity.HasOne(d => d.Promoter)
                    .WithMany(p => p.PersonalDetails)
                    .HasForeignKey(d => d.PromoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalDetails_To_Promoters");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileContent)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pictures)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pictures_To_Users");
            });

            modelBuilder.Entity<Promoter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Promoters)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Promoters_To_Cities");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Promoters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Promoters_To_Users");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FreeFrom).HasColumnType("datetime");

                entity.Property(e => e.FreeTo).HasColumnType("datetime");

                entity.Property(e => e.IsStatic).HasColumnName("isStatic");

                entity.Property(e => e.PromoterId).HasColumnName("PromoterID");

                entity.Property(e => e.WeekDayId).HasColumnName("WeekDayID");

                entity.HasOne(d => d.Promoter)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.PromoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedules_To_Promoters");

                entity.HasOne(d => d.PromoterNavigation)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.PromoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedules_To_WeekDays");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_To_UserTypes");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Weekday1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Weekday");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
