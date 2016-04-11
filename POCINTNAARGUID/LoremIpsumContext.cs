using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POCINTNAARGUID
{
    public class LoremIpsumContext : DbContext
    {
        public LoremIpsumContext() : base("LoremIpsumContext")
        {
        }

        public DbSet<Lorem> Lorems { get; set; }
        public DbSet<Ipsum> Ipsums { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
