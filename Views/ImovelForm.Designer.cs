using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    partial class ImovelForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtProprietarioId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblProprietarioId;

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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtProprietarioId = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblProprietarioId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 12);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(100, 12);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 38);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(100, 38);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblProprietarioId
            // 
            this.lblProprietarioId.AutoSize = true;
            this.lblProprietarioId.Location = new System.Drawing.Point(12, 64);
            this.lblProprietarioId.Name = "lblProprietarioId";
            this.lblProprietarioId.Size = new System.Drawing.Size(70, 13);
            this.lblProprietarioId.TabIndex = 7;
            this.lblProprietarioId.Text = "Proprietário ID";
            // 
            // txtProprietarioId
            // 
            this.txtProprietarioId.Location = new System.Drawing.Point(100, 64);
            this.txtProprietarioId.Name = "txtProprietarioId";
            this.txtProprietarioId.Size = new System.Drawing.Size(100, 20);
            this.txtProprietarioId.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 90);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ImovelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 130);
            this.Controls.Add(this.lblProprietarioId);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtProprietarioId);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtEndereco);
            this.Name = "ImovelForm";
            this.Text = "Adicionar Imóvel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}