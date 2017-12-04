using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace System.XML_Example
{
    public partial class FormAgenda : Form
    {
        Contatos agenda = null;

        public FormAgenda()
        {
            InitializeComponent();
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            agenda = LeitorXmlAgenda.Read();
            this.BindListBox(agenda.ListaDeContatos);
        }

        private void BindListBox(List<Contato> contatos)
        {
            listBox1.DataSource = contatos;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = this.NextId();
            c.Nome = txtNome.Text;
            c.ListaDeTelefones = new List<Telefone>();
            c.ListaDeTelefones.Add(new Telefone((int)TiposTelefone.Residencial, txtFoneResidencial.Text));
            c.ListaDeTelefones.Add(new Telefone((int)TiposTelefone.Comercial, txtFoneComercial.Text));
            c.ListaDeTelefones.Add(new Telefone((int)TiposTelefone.Celular, txtFoneCelular.Text));
            c.Obs = txtObs.Text;

            agenda.ListaDeContatos.Add(c);

            LeitorXmlAgenda.Write(agenda);

            this.BindListBox(LeitorXmlAgenda.Read().ListaDeContatos);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Contato c = ObtenhaContatoPeloID((int)listBox1.SelectedValue);
                agenda.ListaDeContatos.Remove(c);
                LeitorXmlAgenda.Write(agenda);

                this.BindListBox(LeitorXmlAgenda.Read().ListaDeContatos);
            }
            else
            {
                MessageBox.Show("Nenhum ítem selecionado.");
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato c = ObtenhaContatoPeloID((int)listBox1.SelectedValue);
            MessageBox.Show(ContatoToString(c), "Contato - " + c.Nome);
        }

        private string ContatoToString(Contato contato)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + contato.Nome);
            sb.AppendLine("Telefones: ");
            foreach (var telefone in contato.ListaDeTelefones)
            {
                sb.AppendLine(telefone.Numero);
            }
            if (!string.IsNullOrEmpty(contato.Obs))
            {
                sb.AppendLine("Observações: " + contato.Obs);
            }
            return sb.ToString();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                pnlAlterar.Visible = true;
                pnlIncluir.Visible = false;

                Contato c = ObtenhaContatoPeloID((int)listBox1.SelectedValue);
                txtNome.Text = c.Nome;
                if (c.ListaDeTelefones.Count > 0)
                {
                    txtFoneResidencial.Text = c.ListaDeTelefones[(int)TiposTelefone.Residencial].Numero;
                    txtFoneComercial.Text = c.ListaDeTelefones[(int)TiposTelefone.Comercial].Numero;
                    txtFoneCelular.Text = c.ListaDeTelefones[(int)TiposTelefone.Celular].Numero;
                }
                lblId.Text = c.Id.ToString();
                txtObs.Text = c.Obs;
            }
            else
            {
                MessageBox.Show("Nenhum ítem selecionado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            Contato c = agenda.ListaDeContatos.Find(p => p.Id == id);

            c.Nome = txtNome.Text;
            c.ListaDeTelefones[(int)TiposTelefone.Residencial].Numero = txtFoneResidencial.Text;
            c.ListaDeTelefones[(int)TiposTelefone.Comercial].Numero = txtFoneComercial.Text;
            c.ListaDeTelefones[(int)TiposTelefone.Celular].Numero = txtFoneCelular.Text;
            c.Obs = txtObs.Text;

            LeitorXmlAgenda.Write(agenda);

            this.BindListBox(LeitorXmlAgenda.Read().ListaDeContatos);

            this.btnCancelar_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAlterar.Visible = false;
            pnlIncluir.Visible = true;

            txtNome.Text = txtFoneResidencial.Text =
            txtFoneComercial.Text = txtFoneCelular.Text =
            txtObs.Text = lblId.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar f4 = new FormBuscar();
            f4.FormClosed += f4_FormClosed;
            f4.ShowDialog();
        }

        void f4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FiltroContatos.Filtro.Count > 0)
            {
                btnRemoverFiltro.Visible = true;
                this.BindListBox(FiltroContatos.Filtro);
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado.");
            }
        }

        private void btnRemoverFiltro_Click(object sender, EventArgs e)
        {
            btnRemoverFiltro.Visible = false;
            this.BindListBox(LeitorXmlAgenda.Read().ListaDeContatos);
        }

        private Contato ObtenhaContatoPeloID(int id)
        {
            return agenda.ListaDeContatos.Find(p => p.Id == id);
        }

        private int NextId()
        {
            if (agenda.ListaDeContatos.Count == 0)
            {
                return 1;
            }
            int next = agenda.ListaDeContatos[agenda.ListaDeContatos.Count - 1].Id + 1;
            return next;
        }
    }
}