using System;
using System.Windows.Forms;
using TP_POO_R.Models;

namespace TP_POO_R.Views
{
    public partial class LoginForm : Form
    {
        private SenhorioController senhorioController = new SenhorioController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nif = txtNIF.Text;
            string password = txtPassword.Text;

            if (senhorioController.AutenticarSenhorio(nif, password))
            {
                MessageBox.Show("Login bem-sucedido!");
                // Abrir o formulário principal da aplicação
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("NIF ou palavra-passe incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}