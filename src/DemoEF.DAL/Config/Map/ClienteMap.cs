using DemoEF.DAL.Entidade;
using System.Data.Entity.ModelConfiguration;

namespace DemoEF.DAL.Config.Map
{
    public class ClienteMap:EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {

            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("TabCli");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("Nome").HasColumnType("varchar");
            this.Property(t => t.Nascimento).HasColumnName("Nascimento").HasColumnType("datetime");

        }
    }
}
