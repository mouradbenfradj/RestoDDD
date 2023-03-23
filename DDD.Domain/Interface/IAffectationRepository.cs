﻿using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interface
{
    public interface IAffectationRepository : IRepositoryBase<Affectation>
    {
        IEnumerable<Affectation> GetAffectationLibre();


    }
}
