using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities
{
    public class Reclamation
    {
        public int? id { get; set; }

        public string description { get; set; }

        public int id_conduc { get; set; }

        public virtual Conducteur conducteur { get; set; }
    }
}
