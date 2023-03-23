using RestoDDD.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.App.Entities
{
  public  class Cuisine_DTO
    {
        public Cuisine_DTO()
        {
            this.Menu = new List<Menu_DTO>();
        }
        public int CuisineID { get; set; }
        public string typeCuisine { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Menu_DTO> Menu { get; set; }
        public virtual Restaurant_DTO Restaurant { get; set; }
    }
}
