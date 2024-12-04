
using MaterialSkin.Controls;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class ContratoForm : MaterialForm
    {
        private readonly ContratoController _controller;

        public ContratoForm()
        {
            InitializeComponent();
            _controller = new ContratoController(dataGridView);
        }

        private void ContratoForm_Load(object sender, EventArgs e)
        {
            // Carregar dados na DataGridView
            _controller.LoadData();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddContratoForm addContratoForm = new AddContratoForm();
            if (addContratoForm.ShowDialog() == DialogResult.OK)
            {
                // Recarregar dados após adicionar um novo contrato
                _controller.LoadData();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            _controller.RemoveSelectedContrato();
        }
    }
}
