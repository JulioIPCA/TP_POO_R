using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Models; // Certifique-se de que esta linha está presente

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddImovelForm : Form
    {
        public Imovel NovoImovel { get; private set; }

        public AddImovelForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            NovoImovel = new Imovel
            {
                IdImovel = Guid.NewGuid().ToString(),
                ProprietarioId = txtProprietarioId.Text,
                Tipo = txtTipo.Text,
                Endereco = txtEndereco.Text,
                Valor = decimal.Parse(txtValor.Text),
                RendaMensal = decimal.Parse(txtRendaMensal.Text)
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
