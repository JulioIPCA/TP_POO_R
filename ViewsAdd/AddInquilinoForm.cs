using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddInquilinoForm : MaterialForm
    {
        public AddInquilinoForm()
        {
            InitializeComponent();
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

                // Caminho do arquivo JSON
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inquilinos.json");

                // Ler a lista existente de inquilinos
                List<Inquilino> inquilinos;
                if (File.Exists(filePath))
                {
                    var existingJson = File.ReadAllText(filePath);
                    inquilinos = JsonSerializer.Deserialize<List<Inquilino>>(existingJson) ?? new List<Inquilino>();
                }
                else
                {
                    inquilinos = new List<Inquilino>();
                }

                // Adicionar o novo inquilino à lista
                inquilinos.Add(inquilino);

                // Serializar a lista atualizada de inquilinos para JSON
                var json = JsonSerializer.Serialize(inquilinos, new JsonSerializerOptions { WriteIndented = true });

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

    public class Inquilino
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string NIF { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
    }
}
