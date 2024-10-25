using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Controllers;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.Views
{
    public partial class DespesaForm : Form
    {
        private DespesaController despesaController = new DespesaController();

        public DespesaForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Despesa despesa = new Despesa
            {
                Descricao = txtDescricao.Text,
                Valor = decimal.Parse(txtValor.Text),
                Data = dtpData.Value
            };

            despesaController.AdicionarDespesa(despesa);
            MessageBox.Show("Despesa adicionada com sucesso!");
            this.Close();
        }
    }
}
