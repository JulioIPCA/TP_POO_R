using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Exibir botões adicionais para adicionar diferentes tipos de itens
            AdicionarForm adicionarForm = new AdicionarForm();
            adicionarForm.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de consulta
            ConsultarForm consultarForm = new ConsultarForm();
            consultarForm.ShowDialog();
        }
    }
}
