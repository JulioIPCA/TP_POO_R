using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    partial class InquilinoForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblTelefone;

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
            txtNome = new TextBox();
            txtNIF = new TextBox();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            lblNome = new Label();
            lblNIF = new Label();
            lblTelefone = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 0;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(100, 38);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(100, 23);
            txtNIF.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(100, 64);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 2;
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
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 12);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblNIF
            // 
            lblNIF.AutoSize = true;
            lblNIF.Location = new Point(12, 38);
            lblNIF.Name = "lblNIF";
            lblNIF.Size = new Size(25, 15);
            lblNIF.TabIndex = 6;
            lblNIF.Text = "NIF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(12, 64);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // InquilinoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 207);
            Controls.Add(lblTelefone);
            Controls.Add(lblNIF);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtNIF);
            Controls.Add(txtNome);
            Name = "InquilinoForm";
            Text = "Adicionar Inquilino";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
