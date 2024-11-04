using System;
using System.Windows.Forms;
using TP_POO_R.Views; // Adicione esta linha

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddDespesa : Form
    {
        public Despesa NovaDespesa { get; private set; }

        public AddDespesa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            NovaDespesa = new Despesa
            {
                
                IdInquilino = txtIdInquilino.Text,
                IdImovel = txtIdImovel.Text,
                Data = dtpData.Value,
                Descricao = txtDescricao.Text,
                ValorLuz = decimal.Parse(txtValorLuz.Text),
                ValorGas = decimal.Parse(txtValorGas.Text),
                ValorAgua = decimal.Parse(txtValorAgua.Text)
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
