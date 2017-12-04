using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            //else if (cmbCampo.Text == "Telefone")
            //{
            //    resultado = contatos.ListaDeContatos.FindAll(c => c.ListaDeTelefones.Where(tel => tel.Numero.Contains(cmbCampo.Text))).ToList<Contato>();
            //}

            FiltroContatos.Filtro = resultado;
            this.Close();
        }
    }
}
