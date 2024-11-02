//using GestaoRendasImoveis.ViewsConsultar; 
using System;
using System.Windows.Forms;
using TP_POO_R.Views_Consultar; // Atualize o namespace para incluir a nova pasta

namespace TP_POO_R.Views
{
    public partial class ConsultarForm : Form
    {
        public ConsultarForm()
        {
            InitializeComponent();
        }

        private void btnConsultarContrato_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de consultar contrato
            ConsultarContratoForm consultarContratoForm = new ConsultarContratoForm();
            consultarContratoForm.ShowDialog();
        }

       /* private void btnConsultarDespesa_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de consultar despesa
            ConsultarDespesaForm consultarDespesaForm = new ConsultarDespesaForm();
            consultarDespesaForm.ShowDialog();
        }

        private void btnConsultarImovel_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de consultar imóvel
            ConsultarImovelForm consultarImovelForm = new ConsultarImovelForm();
            consultarImovelForm.ShowDialog();
        }

        private void btnConsultarInquilino_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de consultar inquilino
            ConsultarInquilinoForm consultarInquilinoForm = new ConsultarInquilinoForm();
            consultarInquilinoForm.ShowDialog();
        }

        private void btnConsultarRecibo_Click(object sender, EventArgs e)
        {
            // Lógica para abrir o formulário de consultar recibo
            ConsultarReciboForm consultarReciboForm = new ConsultarReciboForm();
            consultarReciboForm.ShowDialog();
        }

        private void btnConsultarSenhorio_Click(object sender, EventArgs e)
        {
           // Lógica para abrir o formulário de consultar senhorio
            ConsultarSenhorioForm consultarSenhorioForm = new ConsultarSenhorioForm();
            consultarSenhorioForm.ShowDialog();
        }*/
    }
}
