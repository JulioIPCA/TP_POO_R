using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Controllers;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.Views
{
    public partial class ReciboForm : Form
    {
        private ReciboController reciboController = new ReciboController();

        public ReciboForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Recibo recibo = new Recibo
            {
                Descricao = txtDescricao.Text,
                Valor = decimal.Parse(txtValor.Text),
                Data = dtpData.Value
            };

            reciboController.AdicionarRecibo(recibo);
            MessageBox.Show("Recibo adicionado com sucesso!");
            this.Close();
        }
    }
}