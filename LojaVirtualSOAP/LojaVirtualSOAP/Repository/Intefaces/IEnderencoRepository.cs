using LojaVirtualSOAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualSOAP.Repository.Intefaces
{
    public interface IEnderecoRepository
    {
        IEnumerable<Endereco> BuscaEnderecoPorCidade(string cidade);
        Endereco BuscaEnderecoPorID(int id);
    }
}
