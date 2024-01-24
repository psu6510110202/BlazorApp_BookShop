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

        public BookDbContext(DbContextOptions options) : base (options) 
        {

        }
    }
}
