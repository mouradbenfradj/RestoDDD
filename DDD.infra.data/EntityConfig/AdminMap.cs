using DDD.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DDD.infra.data.EntityConfig
{
    public class AdminMap : EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.nom)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.prenom)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(t => t.login)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(t => t.mdp)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Admin");
           
        }
    }
}