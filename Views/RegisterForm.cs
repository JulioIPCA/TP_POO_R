using System;
using System.Windows.Forms;
using TP_POO_R.Models;

namespace TP_POO_R.Views
{
    public partial class RegisterForm : Form
    {
        private SenhorioController senhorioController = new SenhorioController();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Senhorio novoSenhorio = new Senhorio
                {
                    Nome = txtNome.Text,
                    NIF = txtNIF.Text,
                    Telefone = txtTelefone.Text,
                    Password = txtPassword.Text
                };

                senhorioController.AdicionarSenhorio(novoSenhorio);
                MessageBox.Show("Senhorio registrado com sucesso!");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
