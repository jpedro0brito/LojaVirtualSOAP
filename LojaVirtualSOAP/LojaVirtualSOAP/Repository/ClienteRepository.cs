using LojaVirtualSOAP.Context;
using LojaVirtualSOAP.Models;
using LojaVirtualSOAP.Repository.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtualSOAP.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(LojaVirtualDbContext context) : 
            base(context) {}

        public Cliente BuscaClientePorID(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<Cliente> BuscaTodosOsClientes()
        {
            return DbSet.ToList();
        }
    }
}