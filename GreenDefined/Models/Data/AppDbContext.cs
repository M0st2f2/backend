using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GreenDefined.Models.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ClassificationImage> ClassificationImages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<React> Reacts { get; set; }
        public DbSet<NotificationTransaction> notificationTransactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define relationships using Fluent API

            // One-to-many relationship between ApplicationUser and Post
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(user => user.Posts)
                .WithOne(post => post.User)
                .HasForeignKey(post => post.userId);

            // One-to-many relationship between Post and Comment
            modelBuilder.Entity<Post>()
                .HasMany(post => post.Comments)
                .WithOne(comment => comment.Post)
                .HasForeignKey(comment => comment.PostID);

            // One-to-one relationship between Post and React (one react per post)
            modelBuilder.Entity<Post>()
                .HasOne(post => post.React)
                .WithOne(react => react.Post)
                .HasForeignKey<React>(react => react.PostId);
        }


    }
}
