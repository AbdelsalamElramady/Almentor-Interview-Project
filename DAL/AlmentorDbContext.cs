using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Types.DbModels;

namespace DAL
{
    public class AlmentorDbContext : DbContext
    {
        public AlmentorDbContext(DbContextOptions<AlmentorDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}
