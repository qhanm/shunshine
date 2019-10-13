using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using qhnam.Data.Entity.Interfaces;
using shunshine.App.EntityCodeFirst.Entities;
using System;
using System.Linq;

namespace shunshine.App.EntityCodeFirst
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Language> Languages { set; get; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Function> Functions { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Announcement> Announcements { set; get; }
        public DbSet<AnnouncementUser> AnnouncementUsers { set; get; }

        public DbSet<Blog> Bills { set; get; }
        public DbSet<BillDetail> BillDetails { set; get; }
        public DbSet<Blog> Blogs { set; get; }
        public DbSet<BlogTag> BlogTags { set; get; }
        public DbSet<Color> Colors { set; get; }
        public DbSet<Contact> Contacts { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductImage> ProductImages { set; get; }
        public DbSet<ProductQuantity> ProductQuantities { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }

        public DbSet<Size> Sizes { set; get; }
        public DbSet<Slide> Slides { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<WholePrice> WholePrices { get; set; }

        public DbSet<Advertistment> Advertistments { get; set; }
        public DbSet<AdvertistmentPosition> AdvertistmentPositions { get; set; }

        public DbSet<AdvertistmentPage> AdvertistmentPages { get; set; }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Custom Identity Config

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims").HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => new { x.UserId });

            #endregion Custom Identity Config

            #region Custom Id Config

            builder.Entity<AdvertistmentPosition>(config =>
                config.Property(c => c.Id).HasMaxLength(20).IsRequired()
            );

            // multi config using { }
            builder.Entity<BlogTag>(config =>
            {
                config.Property(c => c.TagId).IsRequired().HasMaxLength(50).IsUnicode(false);
            }
            );

            builder.Entity<Contact>(config =>
            {
                config.HasKey(c => c.Id);
                config.Property(c => c.Id).HasMaxLength(255).IsRequired();
            });

            builder.Entity<Footer>(config =>
            {
                config.HasKey(c => c.Id);
                config.Property(c => c.Id).HasMaxLength(255).IsRequired().IsUnicode(false);
            });

            builder.Entity<Function>(config =>
            {
                config.HasKey(c => c.Id);
                config.Property(c => c.Id).IsRequired().HasMaxLength(128).IsUnicode(false);
            });

            builder.Entity<Page>(config =>
            {
                config.HasKey(c => c.Id);
                config.Property(c => c.Id).IsRequired().HasMaxLength(255);
            });

            builder.Entity<ProductTag>(config =>
                config.Property(c => c.Id).HasMaxLength(50).IsRequired().IsUnicode(false)
            );

            builder.Entity<SystemConfig>(config =>
            {
                config.Property(c => c.Id).HasMaxLength(255).IsRequired();
            });

            builder.Entity<Tag>(config =>
                config.Property(c => c.Id).HasMaxLength(50).IsRequired().IsUnicode(false)
            );

            builder.Entity<AppUser>(config =>
                config.Property(c => c.Balance).HasColumnType("decimal(10,3)")
            );

            builder.Entity<BillDetail>(config =>
                config.Property(c => c.Price).HasColumnType("decimal(10,3)")
            );

            builder.Entity<Product>(config =>
            {
                config.Property(c => c.Price).HasColumnType("decimal(10,3)");
                config.Property(c => c.OriginalPrice).HasColumnType("decimal(10,3)");
                config.Property(c => c.PromotionPrice).HasColumnType("decimal(10,3)");
            });

            builder.Entity<WholePrice>(config =>
            {
                config.Property(c => c.Price).HasColumnType("decimal(10,3)");
            });

            builder.Entity<Page>(config =>
                config.Property(c => c.Id).HasColumnType("varchar(20)").HasMaxLength(20)
            );

            builder.Entity<AdvertistmentPage>(config =>
                config.Property(c => c.Id).HasMaxLength(20)
            );

            builder.Entity<Announcement>(config =>
                config.Property(c => c.Id).HasMaxLength(128).HasColumnType("varchar(128)").IsRequired()
            );

            #endregion Custom Id Config

            //base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (EntityEntry item in modified)
            {
                var changOrAddedItem = item.Entity as IDateTracking;

                if (changOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changOrAddedItem.DateCreated = DateTime.Now;
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        changOrAddedItem.DateModified = DateTime.Now;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}