using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
   public class Conducteur
    {

       public Conducteur()
        {
            this.affectations = new List<Affectation>();
            this.reclamations = new List<Reclamation>();
        }
        public int? id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public string cin { get; set; }
        public string tel { get; set; }
        public string login { get; set; }
        public string mdp { get; set; }
        public string voiture { get; set; }
        public virtual ICollection<Affectation> affectations { get; set; }
        public virtual ICollection<Reclamation> reclamations { get; set; }
    }
}
