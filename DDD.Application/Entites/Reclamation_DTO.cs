using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Entites
{
    public class Reclamation_DTO
    {
        public int? id { get; set; }

        public string description { get; set; }

        public int id_conduc { get; set; }

        public virtual Conducteur_DTO conducteur_DTO { get; set; }
    }
}
