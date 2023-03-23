﻿using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interface.Service
{
    public interface IPassagerService : IServiceBase<Passager>
    {
        string GetName(int id);
        IEnumerable<Passager> GetAllAu();
        bool Remove2(Passager obj);
    }
}
