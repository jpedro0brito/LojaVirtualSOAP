using LojaVirtualSOAP.Helps;
using LojaVirtualSOAP.Models;
using LojaVirtualSOAP.Repository.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LojaVirtualSOAP.WebService
{
    /// <summary>
    /// Descrição resumida de Endereco
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class Endereco : System.Web.Services.WebService
    {
        private readonly IEnderecoRepository _repository;
        public Endereco(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        [WebMethod]
        public XmlEndereco BuscaEnderecoID(int id)
        {
            return _repository.BuscaEnderecoPorID(id).ToXmlEndereco();
        }
    }
}
