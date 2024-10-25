using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Controllers;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.Views
{
    public partial class ContratoForm : Form
    {
        private ContratoController contratoController = new ContratoController();

        public ContratoForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contrato contrato = new Contrato
            {
                ImovelId = int.Parse(txtImovelId.Text),
                InquilinoId = int.Parse(txtInquilinoId.Text),
                DataInicio = dtpDataInicio.Value,
                DataFim = dtpDataFim.Value
            };

            contratoController.AdicionarContrato(contrato);
            MessageBox.Show("Contrato adicionado com sucesso!");
            this.Close();
        }

        private void lblImovelId_Click(object sender, EventArgs e)
        {

        }
    }
}