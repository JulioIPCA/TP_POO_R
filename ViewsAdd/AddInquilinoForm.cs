using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TP_POO_R.Controllers; // Certifique-se de que este namespace está correto
using TP_POO_R.Models;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddInquilinoForm : MaterialForm
    {
        private readonly InquilinoController _inquilinoController;

        public AddInquilinoForm()
        {
            InitializeComponent();
            _inquilinoController = new InquilinoController();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar um objeto inquilino com os dados do formulário
                var inquilino = new Inquilino
                {
                    Id = int.Parse(txtId.Text),
                    Nome = txtNome.Text,
                    NIF = txtNIF.Text,
                    Telefone = txtTelefone.Text
                };

                // Adicionar o novo inquilino
                _inquilinoController.AdicionarInquilino(inquilino);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
