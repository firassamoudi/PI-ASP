
using NeoXam.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoXam.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ContextNeoXam dataContext;
        public ContextNeoXam DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new ContextNeoXam();
        }
        public DatabaseFactory(DbContext dbc)
        {
            dataContext =(ContextNeoXam) dbc;
        }
        protected override void DisposeCore()
        {
            // libérer espace mémoire du context
            if(DataContext!=null)
            DataContext.Dispose();
        }
    }

}
