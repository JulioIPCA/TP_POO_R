using System;
using System.Windows.Forms;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class ContratoForm : Form
    {
        private readonly ContratoController _controller;

        public ContratoForm()
        {
            InitializeComponent();
            _controller = new ContratoController(dataGridView);
        }

        private void ContratoForm_Load(object sender, EventArgs e)
        {
            _controller.LoadData();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var addContratoForm = new AddContratoForm(_controller);
            addContratoForm.FormClosed += (s, args) => _controller.LoadData(); // Refresh the data after the form is closed
            addContratoForm.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.RemoveSelectedContrato();
        }
    }
}
