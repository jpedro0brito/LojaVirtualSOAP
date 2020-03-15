using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LojaVirtualSOAP.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public IList<Endereco> Enderecos { get; set; }

        internal XmlCliente ToXmlEndereco()
        {
            throw new NotImplementedException();
        }
    }

    [XmlRoot("WSClientes"), XmlType("Cliente")]
    public class XmlCliente 
    {
        [XmlElement("CPF")]
        public string CPF { get; set; }
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("Email")]
        public string Email { get; set; }
        [XmlElement("Telefone")]
        public string Telefone { get; set; }
        public List<XmlEndereco> XmlEnderecos { get; set; }
    }
}