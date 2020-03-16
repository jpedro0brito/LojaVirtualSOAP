using LojaVirtualSOAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtualSOAP.Helps
{
    public static class EnderecoExtensions
    {
        public static Endereco ToEndereco(this XmlEndereco xmlEndereco) 
        {
            return new Endereco
            {
                UF = xmlEndereco.UF,
                Rua = xmlEndereco.Rua,
                Numero = xmlEndereco.Numero,
                Cidade = xmlEndereco.Cidade,
                Bairro = xmlEndereco.Bairro,
                Complemento = xmlEndereco.Complemento,
                Cliente = xmlEndereco.XmlCliente != null 
                    ? xmlEndereco.XmlCliente.ToCliente()
                    : null
            };
        }

        public static XmlEndereco ToXmlEndereco(this Endereco endereco)
        {
            return new XmlEndereco
            {
                UF = endereco.UF,
                Rua = endereco.Rua,
                Numero = endereco.Numero,
                Cidade = endereco.Cidade,
                Bairro = endereco.Bairro,
                Complemento = endereco.Complemento,
                XmlCliente = endereco.Cliente != null 
                    ? endereco.Cliente.ToXmlCliente()
                    : null
            };
        }
    }
}