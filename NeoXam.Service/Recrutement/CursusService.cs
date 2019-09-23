using NeoXam.Domain.Entities;
using NeoXam.Service.Recrutement.Interfaces;
using NeoXam.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoXam.Data.Infrastructure;

namespace NeoXam.Service.Recrutement
{
    public class CursusService : Service<cursus>, ICursusService
    {
        public CursusService(IUnitOfWork utwk) : base(utwk)
        {

        }
    }
}
