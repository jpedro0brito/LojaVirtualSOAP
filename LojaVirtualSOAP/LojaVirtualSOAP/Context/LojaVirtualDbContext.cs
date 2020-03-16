using LojaVirtualSOAP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaVirtualSOAP.Context
{
    public class LojaVirtualDbContext : DbContext
    {
        public LojaVirtualDbContext(): base("LojaVirtualDbContext")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}