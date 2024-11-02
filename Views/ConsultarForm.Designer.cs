namespace TP_POO_R.Views
{
    partial class ConsultarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnConsultarContrato;

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
            btnConsultarContrato = new Button();
            SuspendLayout();
            // 
            // btnConsultarContrato
            // 
            btnConsultarContrato.Location = new Point(12, 12);
            btnConsultarContrato.Name = "btnConsultarContrato";
            btnConsultarContrato.Size = new Size(200, 23);
            btnConsultarContrato.TabIndex = 0;
            btnConsultarContrato.Text = "Consultar Contrato";
            btnConsultarContrato.UseVisualStyleBackColor = true;
            btnConsultarContrato.Click += btnConsultarContrato_Click;
            // 
            // ConsultarForm
            // 
            ClientSize = new Size(468, 212);
            Controls.Add(btnConsultarContrato);
            Name = "ConsultarForm";
            Text = "Consultar";
            ResumeLayout(false);
        }

        #endregion
    }
}
