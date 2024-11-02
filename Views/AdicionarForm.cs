using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    public partial class AdicionarForm : Form
    {
        public AdicionarForm()
        {
            InitializeComponent();
        }

        private void btnAdicionarContrato_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de adicionar contrato
            ContratoForm contratoForm = new ContratoForm();
            contratoForm.ShowDialog();
        }

        private void btnAdicionarDespesa_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de adicionar despesa
            DespesaForm despesaForm = new DespesaForm();
            despesaForm.ShowDialog();
        }

        private void btnAdicionarImovel_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de adicionar imóvel
            ImovelForm imovelForm = new ImovelForm();
            imovelForm.ShowDialog();
        }

        private void btnAdicionarInquilino_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de adicionar inquilino
            InquilinoForm inquilinoForm = new InquilinoForm();
            inquilinoForm.ShowDialog();
        }

        private void btnAdicionarRecibo_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de adicionar recibo
            ReciboForm reciboForm = new ReciboForm();
            reciboForm.ShowDialog();
        }

        private void btnAdicionarSenhorio_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de adicionar senhorio
            SenhorioForm senhorioForm = new SenhorioForm();
            senhorioForm.ShowDialog();
        }
    }
}