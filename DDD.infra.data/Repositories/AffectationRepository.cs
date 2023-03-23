using DDD.Domain.Entities;
using DDD.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.infra.data.Repositories
{
    public class AffectationRepository : RepositoryBase<Affectation>, IAffectationRepository
    {
        public IEnumerable<Affectation> GetAffectationLibre()
{
    //return Db.Set<Affectation>().Where(p => p.nbrplace < 4)
    //  .Select(per => new { per.id, per.villedep, per.villearr, per.conducteur.nom, per.conducteur.prenom, per.conducteur.voiture, per.conducteur.tel }).ToList();                
   return Db.Set<Affectation>().Where(p => p.nbrplace < 4).ToList();
        
        }

       

    }
}
