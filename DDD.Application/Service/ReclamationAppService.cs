using DDD.Application.Entites;
using DDD.Application.Interface;
using DDD.Domain.Entities;
using DDD.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Service
{
    public class ReclamationAppService : AppServiceBase<Reclamation, Reclamation_DTO>, IAppReclamationService
    {

        private readonly IReclamationService _ReclamationService;
        public ReclamationAppService(IReclamationService ReclamationService)
            : base(ReclamationService)
        {
            _ReclamationService = ReclamationService;
        }

    }
}
