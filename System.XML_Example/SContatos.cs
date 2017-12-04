using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace System.XML_Example
{
    public class LeitorXmlAgenda
    {

        static string arquivo = @"C:\Estudos\NET\Agenda.xml";
        static XmlDocument xmlDoc = new XmlDocument();
        static XElement xDoc;
        static Contatos contatos;

        public LeitorXmlAgenda()
        {
        }

        public static Contatos Read()
        {
            VerificaArquivo();
            xDoc = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xDoc);
            return contatos;
        }

        public static void Write(Contatos contatos)
        {
            XElement xmlReturn = Serializer.Serialize<Contatos>(contatos);

            xmlReturn.Save(arquivo);
        }

        public static List<Contato> GetList()
        {
            return contatos.ListaDeContatos;
        }

        private static void VerificaArquivo()
        {
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xmlDoc.CreateElement("Contatos");
                xmlDoc.AppendChild(nodeRoot);
                xmlDoc.Save(arquivo);
            }
        }

    }
}
