using GestaoRendasImoveis.Controllers;
using System;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
//using TP_POO_R.Controllers;

namespace TP_POO_R.Views_Consultar
{
    public partial class ConsultarContratoForm : Form
    {
        private ContratoController contratoController = new ContratoController();

        public ConsultarContratoForm()
        {
            InitializeComponent();
            CarregarContratos();
        }

        private void CarregarContratos()
        {
            // Obter a lista de contratos do controlador
            var contratos = contratoController.ObterTodosContratos();
            dataGridViewContratos.DataSource = contratos;
        }
    }
}