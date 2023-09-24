using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDemo.Data
{

    public class DemoCRUDContext : DbContext
    {

        public DemoCRUDContext() : base("demoCRUDConnection")
        {
        }

        public DbSet<Student> Student{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
