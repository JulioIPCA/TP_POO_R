namespace TP_POO_R.ViewsAdicionar
{
    partial class AddContratoForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.TextBox txtIdImovel;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpDataCessacao;

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
            txtIdImovel = new TextBox();
            dtpData = new DateTimePicker();
            txtNome = new TextBox();
            txtValor = new TextBox();
            dtpDataCessacao = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(102, 313);
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
            btnCancelar.Location = new Point(278, 313);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtIdImovel
            // 
            txtIdImovel.Location = new Point(118, 91);
            txtIdImovel.Name = "txtIdImovel";
            txtIdImovel.PlaceholderText = "ID do Imóvel";
            txtIdImovel.Size = new Size(250, 23);
            txtIdImovel.TabIndex = 2;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(118, 129);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(250, 23);
            dtpData.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(118, 176);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(118, 217);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Valor";
            txtValor.Size = new Size(250, 23);
            txtValor.TabIndex = 5;
            // 
            // dtpDataCessacao
            // 
            dtpDataCessacao.Location = new Point(118, 258);
            dtpDataCessacao.Name = "dtpDataCessacao";
            dtpDataCessacao.Size = new Size(250, 23);
            dtpDataCessacao.TabIndex = 6;
            // 
            // AddContrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 451);
            Controls.Add(dtpDataCessacao);
            Controls.Add(txtValor);
            Controls.Add(txtNome);
            Controls.Add(dtpData);
            Controls.Add(txtIdImovel);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "AddContrato";
            Text = "Adicionar Contrato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
