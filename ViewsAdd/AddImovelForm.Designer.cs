namespace TP_POO_R.ViewsAdicionar
{
    partial class AddImovelForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.TextBox txtProprietarioId;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtRendaMensal;

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
            txtProprietarioId = new TextBox();
            txtTipo = new TextBox();
            txtEndereco = new TextBox();
            txtValor = new TextBox();
            txtRendaMensal = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(50, 202);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Primary = true;
            btnSalvar.Size = new Size(100, 36);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Depth = 0;
            btnCancelar.Location = new Point(210, 202);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtProprietarioId
            // 
            txtProprietarioId.Location = new Point(50, 12);
            txtProprietarioId.Name = "txtProprietarioId";
            txtProprietarioId.PlaceholderText = "Proprietário ID";
            txtProprietarioId.Size = new Size(260, 23);
            txtProprietarioId.TabIndex = 0;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(50, 41);
            txtTipo.Name = "txtTipo";
            txtTipo.PlaceholderText = "Tipo";
            txtTipo.Size = new Size(260, 23);
            txtTipo.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(50, 70);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço";
            txtEndereco.Size = new Size(260, 23);
            txtEndereco.TabIndex = 2;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(50, 99);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Valor";
            txtValor.Size = new Size(260, 23);
            txtValor.TabIndex = 3;
            // 
            // txtRendaMensal
            // 
            txtRendaMensal.Location = new Point(50, 139);
            txtRendaMensal.Name = "txtRendaMensal";
            txtRendaMensal.PlaceholderText = "Renda Mensal";
            txtRendaMensal.Size = new Size(260, 23);
            txtRendaMensal.TabIndex = 4;
            // 
            // AddImovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 303);
            Controls.Add(txtRendaMensal);
            Controls.Add(txtValor);
            Controls.Add(txtEndereco);
            Controls.Add(txtTipo);
            Controls.Add(txtProprietarioId);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "AddImovelForm";
            Text = "Adicionar Imóvel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
