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
    public class PassagerService : ServiceBase<Passager>, IPassagerService
    {
        private readonly IPassagerRepository _PassagerRepository;
        public PassagerService(IPassagerRepository PassagerRepository)
            : base(PassagerRepository)
        {
            _PassagerRepository = PassagerRepository;
        }
        public string GetName(int id)
        {
            return _PassagerRepository.GetName(id);
        }
        public IEnumerable<Passager> GetAllAu()
        {
            return _PassagerRepository.GetAllAu();
        }
        public bool Remove2(Passager obj)
        {
            return _PassagerRepository.Remove2(obj);
        }
    }
}
