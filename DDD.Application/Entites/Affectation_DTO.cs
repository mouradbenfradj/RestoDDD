using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Entites
{
    public class Affectation_DTO
    {
        public Affectation_DTO()
        {
            this.passagers_DTO = new List<Passager_DTO>();
        }
        public int? id { get; set; }

        public string villedep { get; set; }
        public string villearr { get; set; }
        public int? nbrplace { get; set; }

        public int id_conduc { get; set; }

        public virtual Conducteur_DTO conducteur_DTO { get; set; }
        public virtual ICollection<Passager_DTO> passagers_DTO { get; set; }
    }
}
