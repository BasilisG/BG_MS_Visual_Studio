

namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using Models;
    using System.Data.Entity.ModelConfiguration.Conventions;
    
    public partial class GarageContext : DbContext
    {

        public GarageContext()
            : base("name=Garage_Studio_Machine_CF")
        {
            //Disable initializer
            //Database.SetInitializer<SchoolContext>(null);
        }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Vat> Vats { get; set; }
        public DbSet<Proffesion> Proffesions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
