using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public partial class BlogContext : DbContext
    {
        public BlogContext()
        {
        }
        
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.id)
                    .HasMaxLength(30);
                
                entity.Property(e => e.blogtext)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.category)
                    .HasMaxLength(15)
                    .IsUnicode(false);
                
                entity.Property(e => e.title)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}