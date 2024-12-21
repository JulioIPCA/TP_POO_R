using System;
using System.Windows.Forms;
using TP_POO_R.ViewsAdicionar;
using TP_POO_R.Controllers;

namespace TP_POO_R.Views
{
    public partial class ContratoForm : Form
    {
        private readonly ContratoController _controller;
        private readonly InquilinoController _inquilinoController;

        public ContratoForm()
        {
            InitializeComponent();
            _controller = new ContratoController(dataGridView);
            _inquilinoController = new InquilinoController();
        }

        // Evento disparado quando o formulário é carregado
        private void ContratoForm_Load(object sender, EventArgs e)
        {
            _controller.LoadData();
        }

        // Evento disparado ao clicar no botão de adicionar contrato
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var addContratoForm = new AddContratoForm(_inquilinoController, _controller))
            {
                if (addContratoForm.ShowDialog() == DialogResult.OK)
                {
                    if (addContratoForm.NovoContrato != null)
                    {
                        _controller.AddContrato(addContratoForm.NovoContrato);
                    }
                }
            }
        }

        // Evento disparado ao clicar no botão de remover contrato
        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.RemoveSelectedContrato();
        }
    }
}
