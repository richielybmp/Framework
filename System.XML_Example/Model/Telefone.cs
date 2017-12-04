using System.Xml.Serialization;

namespace System.XML_Example.Model
{
    [Serializable()]
    public class Telefone
    {
        public Telefone() { }

        public Telefone(int tipo, string numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        [XmlElement("Tipo")]
        public int Tipo { get; set; }
        [XmlElement("Numero")]
        public string Numero { get; set; }
    }
}
