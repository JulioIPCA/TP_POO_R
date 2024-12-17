namespace TP_POO_R.Views
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNIF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNIF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Depth = 0;
            txtNome.Hint = "Nome";
            txtNome.Location = new Point(77, 48);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(303, 23);
            txtNome.TabIndex = 0;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtNIF
            // 
            txtNIF.Depth = 0;
            txtNIF.Hint = "NIF";
            txtNIF.Location = new Point(77, 91);
            txtNIF.Margin = new Padding(4, 3, 4, 3);
            txtNIF.MouseState = MaterialSkin.MouseState.HOVER;
            txtNIF.Name = "txtNIF";
            txtNIF.PasswordChar = '\0';
            txtNIF.SelectedText = "";
            txtNIF.SelectionLength = 0;
            txtNIF.SelectionStart = 0;
            txtNIF.Size = new Size(303, 23);
            txtNIF.TabIndex = 1;
            txtNIF.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Depth = 0;
            txtTelefone.Hint = "Telefone";
            txtTelefone.Location = new Point(77, 138);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.Size = new Size(303, 23);
            txtTelefone.TabIndex = 2;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.Depth = 0;
            txtPassword.Hint = "Password";
            txtPassword.Location = new Point(77, 179);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(303, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Depth = 0;
            btnRegister.Location = new Point(292, 234);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.Primary = true;
            btnRegister.Size = new Size(88, 27);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 307);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtTelefone);
            Controls.Add(txtNIF);
            Controls.Add(txtNome);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterForm";
            Text = "Registrar Senhorio";
            ResumeLayout(false);
        }
    }
}
