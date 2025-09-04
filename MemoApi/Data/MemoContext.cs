using MemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MemoApi.Data
{
    public class MemoContext : DbContext
    {
        public MemoContext(DbContextOptions<MemoContext> options) : base(options)
        {
        }

        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Memo> Memos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relation Compte <-> Memo
            modelBuilder.Entity<Memo>()
                        .HasOne(m => m.Compte)
                        .WithMany(c => c.Memos) 
                        .HasForeignKey(m => m.IdCompte)
                        .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
