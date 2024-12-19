namespace TP_POO_R.ViewsAdicionar
{
    partial class AddInquilinoForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cmbImovel; // Adicionando ComboBox para Imovel

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
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cmbImovel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(102, 300);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(100, 36);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(278, 300);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(250, 23);
            this.txtNome.TabIndex = 3;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(118, 164);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.PlaceholderText = "NIF";
            this.txtNIF.Size = new System.Drawing.Size(250, 23);
            this.txtNIF.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(118, 202);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PlaceholderText = "Telefone";
            this.txtTelefone.Size = new System.Drawing.Size(250, 23);
            this.txtTelefone.TabIndex = 5;
            // 
            // cmbImovel
            // 
            this.cmbImovel.Location = new System.Drawing.Point(118, 81);
            this.cmbImovel.Name = "cmbImovel";
            this.cmbImovel.Size = new System.Drawing.Size(250, 23);
            this.cmbImovel.TabIndex = 0;
            // 
            // AddInquilinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 404);
            this.Controls.Add(this.cmbImovel);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "AddInquilinoForm";
            this.Text = "Adicionar Inquilino";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
