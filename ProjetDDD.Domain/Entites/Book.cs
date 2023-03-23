using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDDD.Domain.Entites
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public virtual Author Author { get; set; }
    }
}
