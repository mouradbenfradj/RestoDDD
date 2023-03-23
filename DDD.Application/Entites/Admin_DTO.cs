using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Entites
{
    public class Admin_DTO
    {
        public int? id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public string login { get; set; }
        public string mdp { get; set; }

    }
}
