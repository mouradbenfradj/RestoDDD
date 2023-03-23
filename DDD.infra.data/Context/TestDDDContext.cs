using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DDD.Domain.Entities;
using DDD.infra.data.EntityConfig;

namespace DDD.infra.data.Context
{
    public partial class TestDDDContext : DbContext
    {
        static TestDDDContext()
        {
            Database.SetInitializer<TestDDDContext>(null);
        }
        


        public TestDDDContext()
            : base("Name=TestDDDContext")
        {
           // Database.SetInitializer<TestDDDContext>(new CreateDatabaseIfNotExists<TestDDDContext>());
        }

       
        public DbSet<Admin> admins { get; set; }
        public DbSet<Conducteur> conducteurs { get; set; }
        public DbSet<Passager> passsagers { get; set; }
        public DbSet<Affectation> affectations { get; set; }
        public DbSet<Reclamation> reclamations { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

           
            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new ConducteurMap());
            modelBuilder.Configurations.Add(new PassagerMap());
            modelBuilder.Configurations.Add(new AffectationMap());
            modelBuilder.Configurations.Add(new ReclamationMap());
        }
    }
}