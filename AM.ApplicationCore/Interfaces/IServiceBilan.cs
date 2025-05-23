﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceBilan : IService<Bilan>
    {
        double CalculerMontantTotal(Bilan bilan);


        public IEnumerable<(Bilan Bilan, IEnumerable<Analyse> AnalysesAnormales)> ObtenirAnalysesAnormalesParBilan(int codePatient);

        public DateTime ObtenirDateRecuperationBilan(Bilan bilan);
    }
}
