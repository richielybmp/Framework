using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.XML_Example.Model;

namespace System.XML_Example
{
    public partial class FormBuscar : Form
    {
        Contatos contatos = null;
        List<Contato> resultado = null;

        public FormBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contatos = LeitorXmlAgenda.Read();
            if (cmbCampo.Text == "Nome")
            {
                resultado = contatos.ListaDeContatos.Where(p => p.Nome.Contains(txtBusca.Text)).ToList<Contato>();
            }
            else if (cmbCampo.Text == "Telefone")
            {
                resultado = contatos.ListaDeContatos.Where(ct => ct.ListaDeTelefones.All(tel => tel.Numero.Contains(txtBusca.Text))).ToList<Contato>();
            }

            FiltroContatos.Filtro = resultado;
            this.Close();
        }
    }
}
