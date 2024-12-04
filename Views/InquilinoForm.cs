
using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class InquilinoForm : MaterialForm
    {
        private readonly InquilinoController _inquilinoController;

        public InquilinoForm()
        {
            InitializeComponent();
            _inquilinoController = new InquilinoController();
        }

        private void InquilinoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = _inquilinoController.GetInquilinos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddInquilinoForm addInquilinoForm = new AddInquilinoForm();
            if (addInquilinoForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var inquilino = (TP_POO_R.Models.Inquilino)selectedRow.DataBoundItem;

                _inquilinoController.RemoverInquilino(inquilino.Id);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um inquilino para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

