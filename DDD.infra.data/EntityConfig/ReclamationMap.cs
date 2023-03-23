using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.infra.data.EntityConfig
{
    public class ReclamationMap : EntityTypeConfiguration<Reclamation>

    {
        public ReclamationMap()
        {

            // Primary Key
            this.HasKey(t => t.id);

            // Properties

            this.Property(t => t.description)
          .IsRequired()
          .HasMaxLength(100);


            // Table & Column Mappings
            this.ToTable("Reclamation");
         



            //relationShips
            this.HasRequired(t => t.conducteur)
                .WithMany(t => t.reclamations)
                .HasForeignKey(t => t.id_conduc)
                .WillCascadeOnDelete(true);
        }
    }
}
