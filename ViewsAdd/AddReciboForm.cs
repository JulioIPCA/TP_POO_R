using System;
using System.Windows.Forms;
using TP_POO_R.Controllers;
using TP_POO_R.Models;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddReciboForm : Form
    {
        public Recibo? NovoRecibo { get; private set; }
        private readonly ReciboController _reciboController;

        public AddReciboForm()
        {
            InitializeComponent();
            NovoRecibo = null;
            _reciboController = new ReciboController();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Coletar dados do formulário
                int idRecibo = int.Parse(txtIdRecibo.Text);
                string descricao = txtDescricao.Text;
                int imovelId = int.Parse(txtImovelId.Text);
                int inquilinoId = int.Parse(txtInquilinoId.Text);
                decimal valor = decimal.Parse(txtValor.Text);
                DateTime data = DateTime.Parse(txtData.Text);

                // Criar e validar o recibo usando o controller
                NovoRecibo = _reciboController.CriarRecibo(idRecibo, descricao, imovelId, inquilinoId, valor, data);

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
