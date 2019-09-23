
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoXam.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        ContextNeoXam DataContext { get; }
    }

}
