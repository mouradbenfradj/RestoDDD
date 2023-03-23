using DDD.Domain.Entities;
using DDD.Domain.Interface;
using DDD.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Service
{
    public class ReclamationService: ServiceBase<Reclamation>, IReclamationService

    {
        public ReclamationService(IReclamationRepository ReclamationRepository)
            : base(ReclamationRepository)
        {
            
        }
    }
}
