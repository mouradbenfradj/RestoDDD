using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Entites
{
    public class Passager_DTO
    {
        public int? id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }

        public string cin { get; set; }
        public string tel { get; set; }
        public string login { get; set; }

        public string mdp { get; set; }

        public int id_aff { get; set; }

        public virtual Affectation_DTO affectation_DTO { get; set; }
    }
}
