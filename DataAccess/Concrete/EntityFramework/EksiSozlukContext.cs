using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EksiSozlukContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EksiSozluk;Trusted_Connection=true");
        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }

        public DbSet<PageAbout> PageAbouts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationsClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }



    }
}
