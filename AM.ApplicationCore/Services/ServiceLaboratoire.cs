﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class ServiceLaboratoire : Service<Laboratoire>, IServiceLaboratoire
    {
        public ServiceLaboratoire(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
