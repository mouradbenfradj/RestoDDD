using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Entites
{
    public class Conducteur_DTO
    {
        public Conducteur_DTO()
        {
            this.affectations_DTO = new List<Affectation_DTO>();
            this.reclamations_DTO = new List<Reclamation_DTO>();
        }
       
        public int? id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public string cin { get; set; }
        public string tel { get; set; }
        public string login { get; set; }
        public string mdp { get; set; }
        public string voiture { get; set; }
        public ICollection<Affectation_DTO> affectations_DTO { get; set; }
        public virtual ICollection<Reclamation_DTO> reclamations_DTO { get; set; }
    }
}
