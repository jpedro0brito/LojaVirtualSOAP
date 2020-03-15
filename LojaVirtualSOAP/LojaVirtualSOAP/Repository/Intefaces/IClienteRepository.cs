using LojaVirtualSOAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualSOAP.Repository.Intefaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> BuscaTodosOsClientes();
        Cliente BuscaClientePorID(int id);
    }
}
