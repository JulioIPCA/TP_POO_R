namespace TP_POO_R.Views
{
    partial class ConsultarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnConsultarContrato;
        private System.Windows.Forms.Button btnConsultarDespesa;
        private System.Windows.Forms.Button btnConsultarImovel;
        private System.Windows.Forms.Button btnConsultarInquilino;
        private System.Windows.Forms.Button btnConsultarRecibo;
        private System.Windows.Forms.Button btnConsultarSenhorio;

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
            btnConsultarDespesa = new Button();
            btnConsultarImovel = new Button();
            btnConsultarInquilino = new Button();
            btnConsultarRecibo = new Button();
            btnConsultarSenhorio = new Button();
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
            // btnConsultarDespesa
            // 
            btnConsultarDespesa.Location = new Point(0, 0);
            btnConsultarDespesa.Name = "btnConsultarDespesa";
            btnConsultarDespesa.Size = new Size(75, 23);
            btnConsultarDespesa.TabIndex = 0;
            // 
            // btnConsultarImovel
            // 
            btnConsultarImovel.Location = new Point(0, 0);
            btnConsultarImovel.Name = "btnConsultarImovel";
            btnConsultarImovel.Size = new Size(75, 23);
            btnConsultarImovel.TabIndex = 0;
            // 
            // btnConsultarInquilino
            // 
            btnConsultarInquilino.Location = new Point(0, 0);
            btnConsultarInquilino.Name = "btnConsultarInquilino";
            btnConsultarInquilino.Size = new Size(75, 23);
            btnConsultarInquilino.TabIndex = 0;
            // 
            // btnConsultarRecibo
            // 
            btnConsultarRecibo.Location = new Point(0, 0);
            btnConsultarRecibo.Name = "btnConsultarRecibo";
            btnConsultarRecibo.Size = new Size(75, 23);
            btnConsultarRecibo.TabIndex = 0;
            // 
            // btnConsultarSenhorio
            // 
            btnConsultarSenhorio.Location = new Point(0, 0);
            btnConsultarSenhorio.Name = "btnConsultarSenhorio";
            btnConsultarSenhorio.Size = new Size(75, 23);
            btnConsultarSenhorio.TabIndex = 0;
            // 
            // ConsultarForm
            // 
            ClientSize = new Size(492, 343);
            Name = "ConsultarForm";
            ResumeLayout(false);
        }

        #endregion
    }
}
