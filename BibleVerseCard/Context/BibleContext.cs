using BibleVerseCard.Models;
using Microsoft.EntityFrameworkCore;

namespace BibleVerseCard.Context
{
    public  class BibleContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Verse> Verses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Bible.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
