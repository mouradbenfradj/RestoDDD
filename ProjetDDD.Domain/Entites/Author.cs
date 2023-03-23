using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDDD.Domain.Entites
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Forenames { get; set; }
        public string Surname { get; set; }
    }
}
