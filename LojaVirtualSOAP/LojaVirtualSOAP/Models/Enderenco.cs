using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LojaVirtualSOAP.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        public int EnderecoID { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        [ForeignKey("ClienteID")]
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }

    [XmlRoot("WSEnderecos"), XmlType("Endereco")]
    public class XmlEndereco
    {
        [XmlElement("Rua")]
        public string Rua { get; set; }
        [XmlElement("Bairro")]
        public string Bairro { get; set; }
        [XmlElement("Cidade")]
        public string Cidade { get; set; }
        [XmlElement("UF")]
        public string UF { get; set; }
        [XmlElement("Complemento")]
        public string Complemento { get; set; }
        [XmlElement("Numero")]
        public string Numero { get; set; }
        [XmlElement("Cliente")]
        public XmlCliente XmlCliente { get; set; }
    }
}