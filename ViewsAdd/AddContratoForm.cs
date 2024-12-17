using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using TP_POO_R.Models;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddContratoForm : Form
    {
        private readonly string _filePathImoveis;
        private readonly string _filePathInquilinos;
        private readonly ContratoController _controller;

        public AddContratoForm(ContratoController controller)
        {
            InitializeComponent();
            _filePathImoveis = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imoveis.json");
            _filePathInquilinos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inquilinos.json");
            _controller = controller;
            LoadImoveis();
            LoadInquilinos();
        }

        private void LoadImoveis()
        {
            if (File.Exists(_filePathImoveis))
            {
                var json = File.ReadAllText(_filePathImoveis);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    var imoveis = JsonSerializer.Deserialize<List<Imovel>>(json) ?? new List<Imovel>();
                    cmbIdImovel.DataSource = imoveis;
                    cmbIdImovel.DisplayMember = "IdImovel";
                    cmbIdImovel.ValueMember = "IdImovel";
                }
            }
        }

        private void LoadInquilinos()
        {
            if (File.Exists(_filePathInquilinos))
            {
                var json = File.ReadAllText(_filePathInquilinos);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    var inquilinos = JsonSerializer.Deserialize<List<Inquilino>>(json) ?? new List<Inquilino>();
                    cmbIdInquilino.DataSource = inquilinos;
                    cmbIdInquilino.DisplayMember = "Id";
                    cmbIdInquilino.ValueMember = "Id";
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbIdImovel.SelectedValue == null || cmbIdInquilino.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um imóvel e um inquilino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var contrato = new Contrato
            {
                IdImovel = cmbIdImovel.SelectedValue.ToString(),
                IdInquilino = cmbIdInquilino.SelectedValue.ToString(),
                Data = dtpData.Value,
                Nome = txtNome.Text,
                Valor = txtValor.Text,
                DataCessacao = dtpDataCessacao.Value
            };

            _controller.AddContrato(contrato);
            MessageBox.Show("Contrato adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
