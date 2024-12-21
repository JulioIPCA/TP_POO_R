using System;
using System.Windows.Forms;
using TP_POO_R.Models;

namespace TP_POO_R.Views
{
    public partial class RegisterForm : Form
    {
        // Controlador de senhorio
        private SenhorioController senhorioController = new SenhorioController();

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Evento disparado ao clicar no botão de registro
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um novo objeto Senhorio com os dados do formulário
                Senhorio novoSenhorio = new Senhorio
                {
                    Nome = txtNome.Text,
                    NIF = txtNIF.Text,
                    Telefone = txtTelefone.Text,
                    Password = txtPassword.Text
                };

                // Adiciona o novo senhorio usando o controlador
                senhorioController.AdicionarSenhorio(novoSenhorio);
                MessageBox.Show("Senhorio registrado com sucesso!");
                this.Close(); // Fecha o formulário de registro
            }
            catch (ArgumentException ex)
            {
                // Exibe uma mensagem de erro se houver uma exceção de validação
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

