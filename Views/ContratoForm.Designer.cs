using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    partial class ContratoForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtImovelId;
        private System.Windows.Forms.TextBox txtInquilinoId;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblImovelId;
        private System.Windows.Forms.Label lblInquilinoId;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;

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

        private void InitializeComponent()
        {
            txtImovelId = new TextBox();
            txtInquilinoId = new TextBox();
            dtpDataInicio = new DateTimePicker();
            dtpDataFim = new DateTimePicker();
            btnSalvar = new Button();
            lblImovelId = new Label();
            lblInquilinoId = new Label();
            lblDataInicio = new Label();
            lblDataFim = new Label();
            SuspendLayout();
            // 
            // txtImovelId
            // 
            txtImovelId.Location = new Point(100, 12);
            txtImovelId.Name = "txtImovelId";
            txtImovelId.Size = new Size(200, 23);
            txtImovelId.TabIndex = 0;
            // 
            // txtInquilinoId
            // 
            txtInquilinoId.Location = new Point(100, 38);
            txtInquilinoId.Name = "txtInquilinoId";
            txtInquilinoId.Size = new Size(200, 23);
            txtInquilinoId.TabIndex = 1;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(100, 64);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(220, 23);
            dtpDataInicio.TabIndex = 2;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Location = new Point(100, 90);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(220, 23);
            dtpDataFim.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 116);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblImovelId
            // 
            lblImovelId.AutoSize = true;
            lblImovelId.Location = new Point(12, 12);
            lblImovelId.Name = "lblImovelId";
            lblImovelId.Size = new Size(57, 15);
            lblImovelId.TabIndex = 5;
            lblImovelId.Text = "ID Imóvel";
            lblImovelId.Click += lblImovelId_Click;
            // 
            // lblInquilinoId
            // 
            lblInquilinoId.AutoSize = true;
            lblInquilinoId.Location = new Point(12, 38);
            lblInquilinoId.Name = "lblInquilinoId";
            lblInquilinoId.Size = new Size(68, 15);
            lblInquilinoId.TabIndex = 6;
            lblInquilinoId.Text = "ID Inquilino";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Location = new Point(12, 64);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(63, 15);
            lblDataInicio.TabIndex = 7;
            lblDataInicio.Text = "Data Início";
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Location = new Point(12, 90);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(54, 15);
            lblDataFim.TabIndex = 8;
            lblDataFim.Text = "Data Fim";
            // 
            // ContratoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 323);
            Controls.Add(lblDataFim);
            Controls.Add(lblDataInicio);
            Controls.Add(lblInquilinoId);
            Controls.Add(lblImovelId);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataFim);
            Controls.Add(dtpDataInicio);
            Controls.Add(txtInquilinoId);
            Controls.Add(txtImovelId);
            Name = "ContratoForm";
            Text = "Adicionar Contrato";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
