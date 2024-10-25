namespace TP_POO_R.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Button btnImovel;
        private System.Windows.Forms.Button btnInquilino;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnSenhorio;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnContrato = new Button();
            btnDespesa = new Button();
            btnImovel = new Button();
            btnInquilino = new Button();
            btnRecibo = new Button();
            btnSenhorio = new Button();
            SuspendLayout();
            // 
            // btnContrato
            // 
            btnContrato.Location = new Point(116, 109);
            btnContrato.Name = "btnContrato";
            btnContrato.Size = new Size(557, 23);
            btnContrato.TabIndex = 0;
            btnContrato.Text = "Adicionar Contrato";
            btnContrato.UseVisualStyleBackColor = true;
            btnContrato.Click += btnContrato_Click;
            // 
            // btnDespesa
            // 
            btnDespesa.Location = new Point(116, 159);
            btnDespesa.Name = "btnDespesa";
            btnDespesa.Size = new Size(557, 23);
            btnDespesa.TabIndex = 1;
            btnDespesa.Text = "Adicionar Despesa";
            btnDespesa.UseVisualStyleBackColor = true;
            btnDespesa.Click += btnDespesa_Click;
            // 
            // btnImovel
            // 
            btnImovel.Location = new Point(116, 212);
            btnImovel.Name = "btnImovel";
            btnImovel.Size = new Size(557, 23);
            btnImovel.TabIndex = 2;
            btnImovel.Text = "Adicionar Imóvel";
            btnImovel.UseVisualStyleBackColor = true;
            btnImovel.Click += btnImovel_Click;
            // 
            // btnInquilino
            // 
            btnInquilino.Location = new Point(116, 269);
            btnInquilino.Name = "btnInquilino";
            btnInquilino.Size = new Size(557, 23);
            btnInquilino.TabIndex = 3;
            btnInquilino.Text = "Adicionar Inquilino";
            btnInquilino.UseVisualStyleBackColor = true;
            btnInquilino.Click += btnInquilino_Click;
            // 
            // btnRecibo
            // 
            btnRecibo.Location = new Point(116, 313);
            btnRecibo.Name = "btnRecibo";
            btnRecibo.Size = new Size(557, 23);
            btnRecibo.TabIndex = 4;
            btnRecibo.Text = "Adicionar Recibo";
            btnRecibo.UseVisualStyleBackColor = true;
            btnRecibo.Click += btnRecibo_Click;
            // 
            // btnSenhorio
            // 
            btnSenhorio.Location = new Point(116, 355);
            btnSenhorio.Name = "btnSenhorio";
            btnSenhorio.Size = new Size(557, 23);
            btnSenhorio.TabIndex = 5;
            btnSenhorio.Text = "Adicionar Senhorio";
            btnSenhorio.UseVisualStyleBackColor = true;
            btnSenhorio.Click += btnSenhorio_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 481);
            Controls.Add(btnSenhorio);
            Controls.Add(btnRecibo);
            Controls.Add(btnInquilino);
            Controls.Add(btnImovel);
            Controls.Add(btnDespesa);
            Controls.Add(btnContrato);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
    }
}
