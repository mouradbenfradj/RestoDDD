using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.infra.data.EntityConfig
{
    public class AffectationMap : EntityTypeConfiguration<Affectation>
    {
        public AffectationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties

            this.Property(t => t.villedep)
          .IsRequired()
          .HasMaxLength(100);
            this.Property(t => t.villearr)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.nbrplace)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Affectation");
           
            

            //relationShips
            this.HasRequired(t => t.conducteur)
                .WithMany(t => t.affectations)
                .HasForeignKey(t => t.id_conduc)
                .WillCascadeOnDelete(true);
        }
    }
}
