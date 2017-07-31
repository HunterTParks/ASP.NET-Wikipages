using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wikipages.Models
{
    public class BusinessContext : DbContext
    {
        public virtual DbSet<Business> Businesses { get; set; }

        //Change this to an override method after everything is done
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Category;integrated security=True");
        }
    }
}
