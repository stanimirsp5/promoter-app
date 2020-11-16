//using System;
//using Microsoft.EntityFrameworkCore;
//using promotersapp.Models;

//namespace promotersapp.Contexts
//{

//    public class UserDbContext : DbContext
//    {
//        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) {
//            //Database.Exists();
//           // Database.EnsureCreated();

//        }

//        public virtual DbSet<City> Cities { get; set; }
//        public virtual DbSet<Discussion> Discussions { get; set; }
//        public virtual DbSet<Firm> Firms { get; set; }
//        public virtual DbSet<Message> Messages { get; set; }
//        public virtual DbSet<Payment> Payments { get; set; }
//        public virtual DbSet<Perk> Perks { get; set; }
//        public virtual DbSet<PerksToPromoter> PerksToPromoters { get; set; }
//        public virtual DbSet<PersonalDetail> PersonalDetails { get; set; }
//        public virtual DbSet<Picture> Pictures { get; set; }
//        public virtual DbSet<Promoter> Promoters { get; set; }
//        public virtual DbSet<Schedule> Schedules { get; set; }
//        public virtual DbSet<TestUser> TestUsers { get; set; }
//        public virtual DbSet<User> Users { get; set; }
//        public virtual DbSet<UserType> UserTypes { get; set; }
//        public virtual DbSet<WeekDay> WeekDays { get; set; }

//        //public DbSet<TestUser> TestUser { get; set; }
//        //dotnet ef migrations add InitialCreate
//        // public DbSet<User> User { get; set; }
//    }
//}
