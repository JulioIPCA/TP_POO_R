using MaterialSkin;
using MaterialSkin.Controls;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            // Configuração do MaterialSkinManager para aplicar o tema e esquema de cores
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        // Abre o formulário de contratos
        private void btnContrato_Click(object sender, EventArgs e)
        {
            ContratoForm contratoForm = new ContratoForm();
            contratoForm.ShowDialog();
        }

        // Abre o formulário de despesas
        private void btnDespesa_Click(object sender, EventArgs e)
        {
            DespesaForm despesaForm = new DespesaForm();
            despesaForm.ShowDialog();
        }

        // Abre o formulário de imóveis
        private void btnImovel_Click(object sender, EventArgs e)
        {
            ImovelForm imovelForm = new ImovelForm();
            imovelForm.ShowDialog();
        }

        // Abre o formulário de inquilinos
        private void btnInquilino_Click(object sender, EventArgs e)
        {
            InquilinoForm inquilinoForm = new InquilinoForm();
            inquilinoForm.ShowDialog();
        }

        // Abre o formulário de recibos
        private void btnRecibo_Click(object sender, EventArgs e)
        {
            ReciboForm reciboForm = new ReciboForm();
            reciboForm.ShowDialog();
        }
    }
}
