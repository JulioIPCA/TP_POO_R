namespace TP_POO_R.ViewsAdicionar
{
    partial class AddInquilinoForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtTelefone;

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
            btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtNIF = new TextBox();
            txtTelefone = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(102, 250);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Primary = true;
            btnSalvar.Size = new Size(100, 36);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Depth = 0;
            btnCancelar.Location = new Point(278, 250);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 83);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID do Inquilino";
            txtId.Size = new Size(250, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(118, 123);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 3;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(118, 164);
            txtNIF.Name = "txtNIF";
            txtNIF.PlaceholderText = "NIF";
            txtNIF.Size = new Size(250, 23);
            txtNIF.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(118, 202);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(250, 23);
            txtTelefone.TabIndex = 5;
            // 
            // AddInquilinoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(txtTelefone);
            Controls.Add(txtNIF);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "AddInquilinoForm";
            Text = "Adicionar Inquilino";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
