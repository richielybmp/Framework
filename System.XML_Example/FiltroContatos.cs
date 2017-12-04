using System.Collections.Generic;
using System.XML_Example.Model;

namespace System.XML_Example
{
    public class FiltroContatos
    {
        private static List<Contato> filtro;

        public static List<Contato> Filtro
        {
            get
            {
                //Singleton
                if (filtro == null)
                    filtro = new List<Contato>();

                return filtro;
            }
            set { filtro = value; }
        }

    }
}
