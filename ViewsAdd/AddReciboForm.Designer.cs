namespace TP_POO_R.ViewsAdicionar
{
    partial class AddReciboForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtIdRecibo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtImovelId;
        private System.Windows.Forms.TextBox txtInquilinoId;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpData; // Adicionar DateTimePicker

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
            this.txtIdRecibo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtImovelId = new System.Windows.Forms.TextBox();
            this.txtInquilinoId = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker(); // Inicializar DateTimePicker
            this.SuspendLayout();
            // 
            // txtIdRecibo
            // 
            this.txtIdRecibo.Location = new System.Drawing.Point(12, 12);
            this.txtIdRecibo.Name = "txtIdRecibo";
            this.txtIdRecibo.Size = new System.Drawing.Size(200, 20);
            this.txtIdRecibo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtImovelId
            // 
            this.txtImovelId.Location = new System.Drawing.Point(12, 64);
            this.txtImovelId.Name = "txtImovelId";
            this.txtImovelId.Size = new System.Drawing.Size(200, 20);
            this.txtImovelId.TabIndex = 2;
            // 
            // txtInquilinoId
            // 
            this.txtInquilinoId.Location = new System.Drawing.Point(12, 90);
            this.txtInquilinoId.Name = "txtInquilinoId";
            this.txtInquilinoId.Size = new System.Drawing.Size(200, 20);
            this.txtInquilinoId.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 116);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 20);
            this.txtValor.TabIndex = 4;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(12, 142);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 5;
            // 
            // AddReciboForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtInquilinoId);
            this.Controls.Add(this.txtImovelId);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtIdRecibo);
            this.Name = "AddReciboForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
