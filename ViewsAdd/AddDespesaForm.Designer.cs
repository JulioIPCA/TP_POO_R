namespace TP_POO_R.ViewsAdicionar
{
    partial class AddDespesa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtIdInquilino;
        private System.Windows.Forms.TextBox txtIdImovel;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValorLuz;
        private System.Windows.Forms.TextBox txtValorGas;
        private System.Windows.Forms.TextBox txtValorAgua;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;

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
            txtIdInquilino = new TextBox();
            txtIdImovel = new TextBox();
            dtpData = new DateTimePicker();
            txtDescricao = new TextBox();
            txtValorLuz = new TextBox();
            txtValorGas = new TextBox();
            txtValorAgua = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtIdInquilino
            // 
            txtIdInquilino.Location = new Point(12, 12);
            txtIdInquilino.Name = "txtIdInquilino";
            txtIdInquilino.PlaceholderText = "ID Inquilino";
            txtIdInquilino.Size = new Size(200, 23);
            txtIdInquilino.TabIndex = 0;
            // 
            // txtIdImovel
            // 
            txtIdImovel.Location = new Point(12, 38);
            txtIdImovel.Name = "txtIdImovel";
            txtIdImovel.PlaceholderText = "ID Imóvel";
            txtIdImovel.Size = new Size(200, 23);
            txtIdImovel.TabIndex = 1;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(12, 64);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 90);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(200, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtValorLuz
            // 
            txtValorLuz.Location = new Point(12, 116);
            txtValorLuz.Name = "txtValorLuz";
            txtValorLuz.PlaceholderText = "Valor Luz";
            txtValorLuz.Size = new Size(200, 23);
            txtValorLuz.TabIndex = 4;
            // 
            // txtValorGas
            // 
            txtValorGas.Location = new Point(12, 142);
            txtValorGas.Name = "txtValorGas";
            txtValorGas.PlaceholderText = "Valor Gás";
            txtValorGas.Size = new Size(200, 23);
            txtValorGas.TabIndex = 5;
            // 
            // txtValorAgua
            // 
            txtValorAgua.Location = new Point(12, 168);
            txtValorAgua.Name = "txtValorAgua";
            txtValorAgua.PlaceholderText = "Valor Água";
            txtValorAgua.Size = new Size(200, 23);
            txtValorAgua.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 194);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(137, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AddDespesa
            // 
            ClientSize = new Size(238, 252);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtValorAgua);
            Controls.Add(txtValorGas);
            Controls.Add(txtValorLuz);
            Controls.Add(txtDescricao);
            Controls.Add(dtpData);
            Controls.Add(txtIdImovel);
            Controls.Add(txtIdInquilino);
            Name = "AddDespesa";
            Text = "Adicionar Despesa";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
