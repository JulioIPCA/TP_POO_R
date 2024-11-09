using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class InquilinoForm : MaterialForm
    {
        public InquilinoForm()
        {
            InitializeComponent();
        }

        private void InquilinoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inquilinos.json");
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        var inquilinos = JsonSerializer.Deserialize<List<Inquilino>>(json);
                        dataGridView.DataSource = inquilinos ?? new List<Inquilino>();
                    }
                    else
                    {
                        dataGridView.DataSource = new List<Inquilino>();
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView.DataSource = new List<Inquilino>();
                }
            }
            else
            {
                dataGridView.DataSource = new List<Inquilino>();
            }
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
                var inquilino = (Inquilino)selectedRow.DataBoundItem;

                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inquilinos.json");
                var json = File.ReadAllText(filePath);
                var inquilinos = JsonSerializer.Deserialize<List<Inquilino>>(json);

                if (inquilinos != null)
                {
                    inquilinos.RemoveAll(i => i.Id == inquilino.Id);
                    json = JsonSerializer.Serialize(inquilinos, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Selecione um inquilino para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class Inquilino
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }
        public string Telefone { get; set; }
    }
}
