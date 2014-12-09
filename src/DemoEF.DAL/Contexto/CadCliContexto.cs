using System.Data.Entity;

namespace DemoEF.DAL.Contexto
{
    internal class CadCliContexto : DbContext
    {
        static CadCliContexto()
        {
            Database.SetInitializer<CadCliContexto>(new CreateDatabaseIfNotExists<CadCliContexto>());
        }

        public CadCliContexto()
            :base("Name=MinhaConnString")
        {}

        public DbSet<Entidade.Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Config.Map.ClienteMap());
        }
    }
}
