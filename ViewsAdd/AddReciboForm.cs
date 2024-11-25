using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddReciboForm : Form
    {
        public Recibo? NovoRecibo { get; private set; }

        public AddReciboForm()
        {
            InitializeComponent();
            NovoRecibo = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Aqui você pode adicionar a lógica para salvar os dados inseridos
                // Exemplo:
                int idRecibo = int.Parse(txtIdRecibo.Text);
                string descricao = txtDescricao.Text;
                int imovelId = int.Parse(txtImovelId.Text);
                int inquilinoId = int.Parse(txtInquilinoId.Text);
                decimal valor = decimal.Parse(txtValor.Text);
                DateTime data = DateTime.Parse(txtData.Text);

                // Validação básica
                if (string.IsNullOrWhiteSpace(descricao) ||
                    imovelId <= 0 || inquilinoId <= 0 || valor <= 0 || data == default)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Criar um novo recibo
                NovoRecibo = new Recibo
                {
                    IdRecibo = idRecibo,
                    Descricao = descricao,
                    ImovelId = imovelId,
                    InquilinoId = inquilinoId,
                    Valor = valor,
                    Data = data
                };

                MessageBox.Show("Recibo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formatação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o recibo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
