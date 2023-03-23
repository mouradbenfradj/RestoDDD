using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
   public class Passager
    {
        public int? id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }

        public string cin { get; set; }
        public string tel { get; set; }
        public string login { get; set; }

        public string mdp { get; set; }

        public int id_aff { get; set; }

        public virtual Affectation affectation { get; set; }
    }
}
