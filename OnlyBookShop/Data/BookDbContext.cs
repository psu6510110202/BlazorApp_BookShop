using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyBookShop.Data
{
    public class BookDbContext : DbContext
    {
        public DbSet<BookData> BookDatas { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }

        public BookDbContext(DbContextOptions options) : base (options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define a relationship between Transaction and TransactionDetail
            modelBuilder.Entity<TransactionDetail>()
                .HasOne(td => td.Transaction)
                .WithMany(t => t.TransactionDetails)
                .HasForeignKey(td => td.TransactionId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
