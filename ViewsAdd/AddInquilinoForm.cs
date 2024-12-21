using MaterialSkin.Controls;
using TP_POO_R.Controllers; // Certifique-se de que este namespace está correto
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
            CarregarImoveis(); // Carrega a lista de imóveis
        }

        // Carrega a lista de imóveis no ComboBox
        private void CarregarImoveis()
        {
            var imoveis = _imovelController.ObterTodosImoveis();
            cmbImovel.DataSource = imoveis;
            cmbImovel.DisplayMember = "Descricao"; // Supondo que Imovel tem uma propriedade Descricao
            cmbImovel.ValueMember = "IdImovel";
        }

        // Evento disparado ao clicar no botão de salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um objeto inquilino com os dados do formulário
                var inquilino = new Inquilino
                {
                    Nome = txtNome.Text,
                    NIF = txtNIF.Text,
                    Telefone = txtTelefone.Text
                };

                // Associa o IdImovel selecionado
                inquilino.AssociarImovel(cmbImovel.SelectedValue != null ? (int)cmbImovel.SelectedValue : 0);

                // Valida os campos antes de adicionar
                if (!inquilino.ValidarCampos())
                {
                    throw new ArgumentException("Todos os campos devem ser preenchidos corretamente.");
                }

                // Adiciona o novo inquilino
                _inquilinoController.AdicionarInquilino(inquilino);

                this.DialogResult = DialogResult.OK;
                this.Close(); // Fecha o formulário
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento disparado ao clicar no botão de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Fecha o formulário
        }
    }
}

