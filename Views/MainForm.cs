using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TP_POO_R.Views
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
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
