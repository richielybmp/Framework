using System.Collections.Generic;
using System.Xml.Serialization;

namespace System.XML_Example.Model
{
    [Serializable()]
    public class Contato
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("Telefone")]
        public List<Telefone> ListaDeTelefones { get; set; }
        [XmlElement("Obs")]
        public string Obs { get; set; }
    }
}
