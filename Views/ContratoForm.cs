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

        private void ContratoForm_Load(object sender, EventArgs e)
        {
            _controller.LoadData();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var addContratoForm = new AddContratoForm(_inquilinoController);
            addContratoForm.FormClosed += (s, args) => _controller.LoadData(); // Refresh the data after the form is closed
            addContratoForm.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.RemoveSelectedContrato();
        }
    }
}
