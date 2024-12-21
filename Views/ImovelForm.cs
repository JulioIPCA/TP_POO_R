
using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.Models;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class ImovelForm : MaterialForm
    {
        private List<Imovel> _imoveis; // Variável de instância para armazenar imóveis
        private readonly ImovelController _imovelController;

        public ImovelForm()
        {
            InitializeComponent();
            _imovelController = new ImovelController();
            _imoveis = new List<Imovel>(); // Inicializar a lista de imóveis
        }

        // Evento disparado quando o formulário é carregado
        private void ImovelForm_Load(object sender, EventArgs e)
        {
            // Configurar colunas da DataGridView
            ConfigureDataGridView();

            // Carregar dados na DataGridView
            LoadData();
        }

        // Configura as colunas da DataGridView
        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;

            // Adicionar colunas ao DataGridView
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdImovel", HeaderText = "ID Imóvel" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tipo", HeaderText = "Tipo" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nquartos", HeaderText = "Número de Quartos" });
        }

        // Carrega os dados na DataGridView
        private void LoadData()
        {
            try
            {
                _imoveis = _imovelController.CarregarImoveis();
                dataGridView.DataSource = _imoveis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView.DataSource = new List<Imovel>();
            }
        }

        // Evento disparado ao clicar no botão de adicionar imóvel
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddImovelForm addImovelForm = new AddImovelForm();
            if (addImovelForm.ShowDialog() == DialogResult.OK)
            {
                // Adicionar o novo imóvel à lista
                var novoImovel = addImovelForm.NovoImovel;
                if (novoImovel != null)
                {
                    // Garantir que o ID do novo imóvel seja o menor número inteiro positivo disponível
                    novoImovel.SetIdImovel(GetNextAvailableId());

                    _imoveis.Add(novoImovel);

                    // Salvar a lista atualizada de imóveis
                    _imovelController.SalvarImoveis(_imoveis);

                    // Recarregar dados após adicionar um novo imóvel
                    LoadData();
                }
            }
        }

        // Obtém o próximo ID disponível para um novo imóvel
        private int GetNextAvailableId()
        {
            if (_imoveis.Count == 0)
                return 1;

            var idsExistentes = _imoveis.Select(i => i.IdImovel).OrderBy(id => id).ToList();
            int nextId = 1;

            foreach (var id in idsExistentes)
            {
                if (id == nextId)
                {
                    nextId++;
                }
                else
                {
                    break;
                }
            }

            return nextId;
        }

        // Evento disparado ao clicar no botão de remover imóvel
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obter o índice da linha selecionada
                var selectedIndex = dataGridView.SelectedRows[0].Index;

                // Remover o imóvel selecionado da lista original
                var imovelToRemove = _imoveis[selectedIndex];
                _imoveis.Remove(imovelToRemove);

                // Salvar a lista atualizada de imóveis
                _imovelController.SalvarImoveis(_imoveis);

                // Recarregar dados após remover o imóvel
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um imóvel para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

