﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
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

        private void ImovelForm_Load(object sender, EventArgs e)
        {
            // Configurar colunas da DataGridView
            ConfigureDataGridView();

            // Carregar dados na DataGridView
            LoadData();
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;

            // Adicionar colunas ao DataGridView
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdImovel", HeaderText = "ID Imóvel" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProprietarioId", HeaderText = "Proprietário ID" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tipo", HeaderText = "Tipo" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RendaMensal", HeaderText = "Renda Mensal" });
        }

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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddImovelForm addImovelForm = new AddImovelForm();
            if (addImovelForm.ShowDialog() == DialogResult.OK)
            {
                // Adicionar o novo imóvel à lista
                var novoImovel = addImovelForm.NovoImovel;
                if (novoImovel != null)
                {
                    _imoveis.Add(novoImovel);

                    // Salvar a lista atualizada de imóveis
                    _imovelController.SalvarImoveis(_imoveis);

                    // Recarregar dados após adicionar um novo imóvel
                    LoadData();
                }
            }
        }

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
