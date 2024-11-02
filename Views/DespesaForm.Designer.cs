using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    partial class DespesaForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;

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
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            dtpData = new DateTimePicker();
            btnSalvar = new Button();
            lblDescricao = new Label();
            lblValor = new Label();
            lblData = new Label();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(100, 12);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(200, 23);
            txtDescricao.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(100, 38);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 1;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(100, 64);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 90);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 12);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 38);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 64);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 7;
            lblData.Text = "Data";
            // 
            // DespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 416);
            Controls.Add(lblData);
            Controls.Add(lblValor);
            Controls.Add(lblDescricao);
            Controls.Add(btnSalvar);
            Controls.Add(dtpData);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Name = "DespesaForm";
            Text = "Adicionar Despesa";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}