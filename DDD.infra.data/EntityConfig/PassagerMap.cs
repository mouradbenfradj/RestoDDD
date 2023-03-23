using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.infra.data.EntityConfig
{
    public class PassagerMap : EntityTypeConfiguration<Passager>
    {
        public PassagerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.nom)
                 .IsRequired()
                 .HasMaxLength(50);
            this.Property(t => t.prenom)
            .IsRequired()
            .HasMaxLength(50);
            this.Property(t => t.cin)
          .IsRequired()
          .HasMaxLength(100);
            this.Property(t => t.tel)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.login)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(t => t.mdp)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Passager");
            

            //relationShips
            this.HasRequired(t => t.affectation)
                .WithMany(t => t.passagers)
                .HasForeignKey(t => t.id_aff);
        }
    }
}
