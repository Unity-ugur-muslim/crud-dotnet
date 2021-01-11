using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public partial class BlogContext : DbContext
    {
        /*public BlogContext()
        {
        }*/

        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.id)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                
                entity.Property(e => e.email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.title)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.blogText)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
                
                entity.Property(e => e.createdAt)
                    .HasColumnType("datetime");
                
                entity.Property(e => e.updatedAt)
                    .HasColumnType("datetime");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
