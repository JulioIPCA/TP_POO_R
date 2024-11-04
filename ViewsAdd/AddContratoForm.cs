using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddContratoForm : MaterialForm
    {
        public AddContratoForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar um objeto contrato com os dados do formulário
                var contrato = new Contrato
                {
                    IdImovel = txtIdImovel.Text,
                    Data = dtpData.Value,
                    Nome = txtNome.Text,
                    Valor = txtValor.Text,
                    DataCessacao = dtpDataCessacao.Value
                };

                // Caminho do arquivo JSON
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contratos.json");

                // Ler a lista existente de contratos
                List<Contrato> contratos;
                if (File.Exists(filePath))
                {
                    var existingJson = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(existingJson))
                    {
                        contratos = JsonSerializer.Deserialize<List<Contrato>>(existingJson) ?? new List<Contrato>();
                    }
                    else
                    {
                        contratos = new List<Contrato>();
                    }
                }
                else
                {
                    contratos = new List<Contrato>();
                }

                // Adicionar o novo contrato à lista
                contratos.Add(contrato);

                // Serializar a lista atualizada de contratos para JSON
                var json = JsonSerializer.Serialize(contratos, new JsonSerializerOptions { WriteIndented = true });

                // Salvar o JSON no arquivo
                File.WriteAllText(filePath, json);

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

    public class Contrato
    {
        public string IdImovel { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;
        public DateTime DataCessacao { get; set; }
    }
}
