using LojaVirtualSOAP.Context;
using LojaVirtualSOAP.Repository.Intefaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaVirtualSOAP.Repository
{
    public class BaseRepository<Entity>: IDisposable, IBaseRepository<Entity> where Entity: class
    {
        protected readonly LojaVirtualDbContext Context;
        protected readonly DbSet<Entity> DbSet;
        public BaseRepository(LojaVirtualDbContext context)
        {
            Context = context;
            DbSet = context.Set<Entity>();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}