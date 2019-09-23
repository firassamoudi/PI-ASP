using NeoXam.Domain.Entities;
using NeoXam.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoXam.Data.Infrastructure;

namespace NeoXam.Service.Recrutement
{
    class LangageService : Service<langage_naturel>, IService<langage_naturel>
    {
        public LangageService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}
