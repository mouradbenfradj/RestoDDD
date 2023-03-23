using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
    public class Affectation
    {
        public Affectation()
        {
            this.passagers = new List<Passager>();
        }
        public int? id { get; set; }

        public string villedep { get; set; }
        public string villearr { get; set; }
        public int? nbrplace { get; set; }

        public int id_conduc { get; set; }

        public virtual Conducteur conducteur { get; set; }
        public virtual ICollection<Passager> passagers { get; set; }
    }
}
