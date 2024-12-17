namespace TP_POO_R.Views
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNIF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
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
            txtNIF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // txtNIF
            // 
            txtNIF.Depth = 0;
            txtNIF.Hint = "NIF";
            txtNIF.Location = new Point(104, 76);
            txtNIF.Margin = new Padding(4, 3, 4, 3);
            txtNIF.MouseState = MaterialSkin.MouseState.HOVER;
            txtNIF.Name = "txtNIF";
            txtNIF.PasswordChar = '\0';
            txtNIF.SelectedText = "";
            txtNIF.SelectionLength = 0;
            txtNIF.SelectionStart = 0;
            txtNIF.Size = new Size(303, 23);
            txtNIF.TabIndex = 0;
            txtNIF.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.Depth = 0;
            txtPassword.Hint = "Password";
            txtPassword.Location = new Point(104, 161);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(303, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Depth = 0;
            btnLogin.Location = new Point(117, 229);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.Primary = true;
            btnLogin.Size = new Size(88, 27);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Depth = 0;
            btnRegister.Location = new Point(308, 229);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.Primary = true;
            btnRegister.Size = new Size(88, 27);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 336);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtNIF);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
        }
    }
}
