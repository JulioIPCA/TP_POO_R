using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Controllers;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.Views
{
    public partial class ImovelForm : Form
    {
        private ImovelController imovelController = new ImovelController();

        public ImovelForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Imovel imovel = new Imovel
            {
                Endereco = txtEndereco.Text,
                Valor = decimal.Parse(txtValor.Text),
                ProprietarioId = int.Parse(txtProprietarioId.Text)
            };

            imovelController.AdicionarImovel(imovel);
            MessageBox.Show("Imóvel adicionado com sucesso!");
            this.Close();
        }
    }
}
