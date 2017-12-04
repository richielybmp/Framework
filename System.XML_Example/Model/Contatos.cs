using System.Collections.Generic;
using System.Xml.Serialization;

namespace System.XML_Example.Model
{
    [Serializable()]
    [XmlRoot("Contatos")]
    public class Contatos
    {
        [XmlElement("Contato")]
        public List<Contato> ListaDeContatos;
    }
}
