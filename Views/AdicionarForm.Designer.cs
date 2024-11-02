namespace TP_POO_R.Views
{
    partial class AdicionarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdicionarContrato;
        private System.Windows.Forms.Button btnAdicionarDespesa;
        private System.Windows.Forms.Button btnAdicionarImovel;
        private System.Windows.Forms.Button btnAdicionarInquilino;
        private System.Windows.Forms.Button btnAdicionarRecibo;
        private System.Windows.Forms.Button btnAdicionarSenhorio;

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
            btnAdicionarContrato = new Button();
            btnAdicionarDespesa = new Button();
            btnAdicionarImovel = new Button();
            btnAdicionarInquilino = new Button();
            btnAdicionarRecibo = new Button();
            btnAdicionarSenhorio = new Button();
            SuspendLayout();
            // 
            // btnAdicionarContrato
            // 
            btnAdicionarContrato.Location = new Point(283, 32);
            btnAdicionarContrato.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarContrato.Name = "btnAdicionarContrato";
            btnAdicionarContrato.Size = new Size(233, 27);
            btnAdicionarContrato.TabIndex = 0;
            btnAdicionarContrato.Text = "Adicionar Contrato";
            btnAdicionarContrato.UseVisualStyleBackColor = true;
            btnAdicionarContrato.Click += btnAdicionarContrato_Click;
            // 
            // btnAdicionarDespesa
            // 
            btnAdicionarDespesa.Location = new Point(283, 94);
            btnAdicionarDespesa.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarDespesa.Name = "btnAdicionarDespesa";
            btnAdicionarDespesa.Size = new Size(233, 27);
            btnAdicionarDespesa.TabIndex = 1;
            btnAdicionarDespesa.Text = "Adicionar Despesa";
            btnAdicionarDespesa.UseVisualStyleBackColor = true;
            btnAdicionarDespesa.Click += btnAdicionarDespesa_Click;
            // 
            // btnAdicionarImovel
            // 
            btnAdicionarImovel.Location = new Point(283, 148);
            btnAdicionarImovel.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarImovel.Name = "btnAdicionarImovel";
            btnAdicionarImovel.Size = new Size(233, 27);
            btnAdicionarImovel.TabIndex = 2;
            btnAdicionarImovel.Text = "Adicionar Imóvel";
            btnAdicionarImovel.UseVisualStyleBackColor = true;
            btnAdicionarImovel.Click += btnAdicionarImovel_Click;
            // 
            // btnAdicionarInquilino
            // 
            btnAdicionarInquilino.Location = new Point(283, 205);
            btnAdicionarInquilino.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarInquilino.Name = "btnAdicionarInquilino";
            btnAdicionarInquilino.Size = new Size(233, 27);
            btnAdicionarInquilino.TabIndex = 3;
            btnAdicionarInquilino.Text = "Adicionar Inquilino";
            btnAdicionarInquilino.UseVisualStyleBackColor = true;
            btnAdicionarInquilino.Click += btnAdicionarInquilino_Click;
            // 
            // btnAdicionarRecibo
            // 
            btnAdicionarRecibo.Location = new Point(283, 262);
            btnAdicionarRecibo.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarRecibo.Name = "btnAdicionarRecibo";
            btnAdicionarRecibo.Size = new Size(233, 27);
            btnAdicionarRecibo.TabIndex = 4;
            btnAdicionarRecibo.Text = "Adicionar Recibo";
            btnAdicionarRecibo.UseVisualStyleBackColor = true;
            btnAdicionarRecibo.Click += btnAdicionarRecibo_Click;
            // 
            // btnAdicionarSenhorio
            // 
            btnAdicionarSenhorio.Location = new Point(283, 318);
            btnAdicionarSenhorio.Margin = new Padding(4, 3, 4, 3);
            btnAdicionarSenhorio.Name = "btnAdicionarSenhorio";
            btnAdicionarSenhorio.Size = new Size(233, 27);
            btnAdicionarSenhorio.TabIndex = 5;
            btnAdicionarSenhorio.Text = "Adicionar Senhorio";
            btnAdicionarSenhorio.UseVisualStyleBackColor = true;
            btnAdicionarSenhorio.Click += btnAdicionarSenhorio_Click;
            // 
            // AdicionarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 432);
            Controls.Add(btnAdicionarSenhorio);
            Controls.Add(btnAdicionarRecibo);
            Controls.Add(btnAdicionarInquilino);
            Controls.Add(btnAdicionarImovel);
            Controls.Add(btnAdicionarDespesa);
            Controls.Add(btnAdicionarContrato);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdicionarForm";
            Text = "Adicionar";
            ResumeLayout(false);
        }

        #endregion
    }
}
