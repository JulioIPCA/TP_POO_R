namespace TP_POO_R.Views_Consultar
{
    partial class ConsultarContratoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewContratos;

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
            this.dataGridViewContratos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContratos
            // 
            this.dataGridViewContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContratos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewContratos.Name = "dataGridViewContratos";
            this.dataGridViewContratos.Size = new System.Drawing.Size(760, 437);
            this.dataGridViewContratos.TabIndex = 0;
            // 
            // ConsultarContratoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewContratos);
            this.Name = "ConsultarContratoForm";
            this.Text = "Consultar Contratos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContratos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

