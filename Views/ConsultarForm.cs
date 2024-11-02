using System;
using System.Windows.Forms;
using TP_POO_R.Views_Consultar;

namespace TP_POO_R.Views
{
    public partial class ConsultarForm : Form
    {
        public ConsultarForm()
        {
            InitializeComponent();
        }

        private void btnConsultarContrato_Click(object sender, EventArgs e)
        {
            // Abrir o formulário ConsultarContratoForm
            ConsultarContratoForm consultarContratoForm = new ConsultarContratoForm();
            consultarContratoForm.ShowDialog();
        }
    }
}
