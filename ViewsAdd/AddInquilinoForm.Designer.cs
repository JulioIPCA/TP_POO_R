namespace TP_POO_R.ViewsAdicionar
{
    partial class AddInquilinoForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNIF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.ComboBox cmbImovel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNIF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            cmbImovel = new System.Windows.Forms.ComboBox();
            btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Depth = 0;
            txtNome.Hint = "Nome";
            txtNome.Location = new Point(99, 119);
            txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 0;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtNIF
            // 
            txtNIF.Depth = 0;
            txtNIF.Hint = "NIF";
            txtNIF.Location = new Point(99, 148);
            txtNIF.MouseState = MaterialSkin.MouseState.HOVER;
            txtNIF.Name = "txtNIF";
            txtNIF.PasswordChar = '\0';
            txtNIF.SelectedText = "";
            txtNIF.SelectionLength = 0;
            txtNIF.SelectionStart = 0;
            txtNIF.Size = new Size(200, 23);
            txtNIF.TabIndex = 1;
            txtNIF.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Depth = 0;
            txtTelefone.Hint = "Telefone";
            txtTelefone.Location = new Point(99, 177);
            txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.Size = new Size(200, 23);
            txtTelefone.TabIndex = 2;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // cmbImovel
            // 
            cmbImovel.Location = new Point(99, 81);
            cmbImovel.Name = "cmbImovel";
            cmbImovel.Size = new Size(200, 23);
            cmbImovel.TabIndex = 3;
            cmbImovel.Text = "IdImovel";
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(90, 220);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Primary = true;
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Depth = 0;
            btnCancelar.Location = new Point(212, 220);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AddInquilinoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 316);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cmbImovel);
            Controls.Add(txtTelefone);
            Controls.Add(txtNIF);
            Controls.Add(txtNome);
            Name = "AddInquilinoForm";
            Text = "Adicionar Inquilino";
            ResumeLayout(false);
        }

        #endregion
    }
}
