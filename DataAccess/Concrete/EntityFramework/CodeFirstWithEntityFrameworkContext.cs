using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CodeFirstWithEntityFrameworkContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AHNUQF4\SQLEXPRESS; Database=CodeFirstWithEF; Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
