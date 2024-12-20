using MaterialSkin.Controls;
using TP_POO_R.Controllers; // Ensure this namespace is correct
using TP_POO_R.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddInquilinoForm : MaterialForm
    {
        private readonly InquilinoController _inquilinoController;
        private readonly ImovelController _imovelController;

        public AddInquilinoForm()
        {
            InitializeComponent();
            _inquilinoController = new InquilinoController();
            _imovelController = new ImovelController();
            CarregarImoveis();
        }

        private void CarregarImoveis()
        {
            var imoveis = _imovelController.ObterTodosImoveis();
            cmbImovel.DataSource = imoveis;
            cmbImovel.DisplayMember = "Descricao"; // Assuming Imovel has a property Descricao
            cmbImovel.ValueMember = "IdImovel";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an inquilino object with form data
                var inquilino = new Inquilino
                {
                    Nome = txtNome.Text,
                    NIF = txtNIF.Text,
                    Telefone = txtTelefone.Text,
                    IdImovel = cmbImovel.SelectedValue != null ? (int)cmbImovel.SelectedValue : 0 // Associate the selected IdImovel
                };

                // Add the new inquilino
                _inquilinoController.AdicionarInquilino(inquilino);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
