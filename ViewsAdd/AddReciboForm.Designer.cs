namespace TP_POO_R.ViewsAdicionar
{
    partial class AddReciboForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.TextBox txtIdRecibo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtImovelId;
        private System.Windows.Forms.TextBox txtInquilinoId;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtData;

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
            txtIdRecibo = new TextBox();
            txtDescricao = new TextBox();
            txtImovelId = new TextBox();
            txtInquilinoId = new TextBox();
            txtValor = new TextBox();
            txtData = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(102, 300);
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
            btnCancelar.Location = new Point(278, 300);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtIdRecibo
            // 
            txtIdRecibo.Location = new Point(118, 50);
            txtIdRecibo.Name = "txtIdRecibo";
            txtIdRecibo.PlaceholderText = "ID do Recibo";
            txtIdRecibo.Size = new Size(250, 23);
            txtIdRecibo.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(118, 90);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(250, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtImovelId
            // 
            txtImovelId.Location = new Point(118, 130);
            txtImovelId.Name = "txtImovelId";
            txtImovelId.PlaceholderText = "ID do Imóvel";
            txtImovelId.Size = new Size(250, 23);
            txtImovelId.TabIndex = 4;
            // 
            // txtInquilinoId
            // 
            txtInquilinoId.Location = new Point(118, 170);
            txtInquilinoId.Name = "txtInquilinoId";
            txtInquilinoId.PlaceholderText = "ID do Inquilino";
            txtInquilinoId.Size = new Size(250, 23);
            txtInquilinoId.TabIndex = 5;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(118, 210);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Valor";
            txtValor.Size = new Size(250, 23);
            txtValor.TabIndex = 6;
            // 
            // txtData
            // 
            txtData.Location = new Point(118, 250);
            txtData.Name = "txtData";
            txtData.PlaceholderText = "Data";
            txtData.Size = new Size(250, 23);
            txtData.TabIndex = 7;
            // 
            // AddReciboForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(txtData);
            Controls.Add(txtValor);
            Controls.Add(txtInquilinoId);
            Controls.Add(txtImovelId);
            Controls.Add(txtDescricao);
            Controls.Add(txtIdRecibo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Name = "AddReciboForm";
            Text = "Adicionar Recibo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
