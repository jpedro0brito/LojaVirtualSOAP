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
                Rua = xmlEndereco.Rua,
                Bairro = xmlEndereco.Bairro,
                Cidade = xmlEndereco.Cidade,
                UF = xmlEndereco.UF,
                Complemento = xmlEndereco.Complemento,
                Numero = xmlEndereco.Numero,
                Cliente = xmlEndereco.XmlCliente.ToCliente()
            };
        }

        public static XmlEndereco ToXmlEndereco(this Endereco endereco)
        {
            return new XmlEndereco
            {
                Rua = endereco.Rua,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                UF = endereco.UF,
                Complemento = endereco.Complemento,
                Numero = endereco.Numero,
                XmlCliente = endereco.Cliente.ToXmlCliente()
            };
        }
    }
}