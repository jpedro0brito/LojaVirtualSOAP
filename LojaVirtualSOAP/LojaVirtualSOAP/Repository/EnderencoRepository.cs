using LojaVirtualSOAP.Context;
using LojaVirtualSOAP.Models;
using LojaVirtualSOAP.Repository.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtualSOAP.Repository
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(LojaVirtualDbContext context) : 
            base(context) {}

        public IEnumerable<Endereco> BuscaEnderecoPorCidade(string cidade)
        {
            return DbSet.Where(e => e.Cidade.Equals(cidade));
        }

        public Endereco BuscaEnderecoPorID(int id)
        {
            return DbSet.Find(id);
        }
    }
}