using LojaVirtualSOAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtualSOAP.Helps
{
    public static class ClienteExtensions
    {
        public static Cliente ToCliente(this XmlCliente xmlCliente)
        {
            return new Cliente
            {
                CPF = xmlCliente.CPF,
                Nome = xmlCliente.Nome,
                Email = xmlCliente.Email,
                Telefone = xmlCliente.Telefone,
                Enderecos = xmlCliente.XmlEnderecos != null
                    ? xmlCliente.XmlEnderecos.Select(e => e.ToEndereco()).ToList()
                    : null
            };
        }

        public static XmlCliente ToXmlCliente(this Cliente cliente)
        {
            return new XmlCliente
            {
                CPF = cliente.CPF,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                XmlEnderecos = cliente.Enderecos != null
                    ? cliente.Enderecos.Select(e => e.ToXmlEndereco()).ToList() 
                    : null
            };
        }
    }
}