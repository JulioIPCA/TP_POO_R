using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            ContratoForm contratoForm = new ContratoForm();
            contratoForm.ShowDialog();
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            DespesaForm despesaForm = new DespesaForm();
            despesaForm.ShowDialog();
        }

        private void btnImovel_Click(object sender, EventArgs e)
        {
            ImovelForm imovelForm = new ImovelForm();
            imovelForm.ShowDialog();
        }

        private void btnInquilino_Click(object sender, EventArgs e)
        {
            InquilinoForm inquilinoForm = new InquilinoForm();
            inquilinoForm.ShowDialog();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            ReciboForm reciboForm = new ReciboForm();
            reciboForm.ShowDialog();
        }

        private void btnSenhorio_Click(object sender, EventArgs e)
        {
            SenhorioForm senhorioForm = new SenhorioForm();
            senhorioForm.ShowDialog();
        }
    }
}
