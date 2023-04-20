using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GetDataMvc.BusinessObjects;


namespace GetDataMvc.ORM
{
    public class MssqlDbContext : DbContext
    {

        public DbSet<Flower> Flowers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DELL-PC\\SQL2014SP3; Database=FlowerDB; Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=localhost; Database=FlowerDB; Trusted_Connection=True;");
        }

    }
}
