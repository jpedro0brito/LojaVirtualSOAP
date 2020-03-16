using LojaVirtualSOAP.Helps;
using LojaVirtualSOAP.Models;
using LojaVirtualSOAP.Repository;
using LojaVirtualSOAP.Repository.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LojaVirtualSOAP.WebService
{
    /// <summary>
    /// Descrição resumida de Cliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class Cliente : System.Web.Services.WebService
    {
        private readonly IClienteRepository _repository;
        public Cliente()
        {
            _repository = new ClienteRepository();
        }

        [WebMethod]
        public List<XmlCliente> BuscaTodosOsClientes()
        {
            return _repository
                .BuscaTodosOsClientes()
                .Select(c => c.ToXmlCliente())
                .ToList();
        }
    }
}
