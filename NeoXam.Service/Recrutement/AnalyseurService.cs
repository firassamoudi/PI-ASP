
using NeoXam.Domain.Entities;
using NeoXam.Data.Infrastructure;

using NeoXam.ServicePattern;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoXam.Service.Recrutement
{
    public class AnalyseurService : Service<analyseur>, IService<analyseur>
    {
        public AnalyseurService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}
