using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace TP_POO_R.ViewsAdicionar
{
    partial class AddImovelForm : MaterialForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSingleLineTextField txtTipo;
        private MaterialSingleLineTextField txtEndereco;
        private MaterialSingleLineTextField txtNQuartos;
        private MaterialRaisedButton btnSalvar;
        private MaterialRaisedButton btnCancelar;

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
            txtTipo = new MaterialSingleLineTextField();
            txtEndereco = new MaterialSingleLineTextField();
            txtNQuartos = new MaterialSingleLineTextField();
            btnSalvar = new MaterialRaisedButton();
            btnCancelar = new MaterialRaisedButton();
            SuspendLayout();
            // 
            // txtTipo
            // 
            txtTipo.Depth = 0;
            txtTipo.Hint = "Tipo";
            txtTipo.Location = new Point(99, 119);
            txtTipo.MouseState = MouseState.HOVER;
            txtTipo.Name = "txtTipo";
            txtTipo.PasswordChar = '\0';
            txtTipo.SelectedText = "";
            txtTipo.SelectionLength = 0;
            txtTipo.SelectionStart = 0;
            txtTipo.Size = new Size(200, 23);
            txtTipo.TabIndex = 0;
            txtTipo.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.Depth = 0;
            txtEndereco.Hint = "Endereço";
            txtEndereco.Location = new Point(99, 148);
            txtEndereco.MouseState = MouseState.HOVER;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.Size = new Size(200, 23);
            txtEndereco.TabIndex = 1;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNQuartos
            // 
            txtNQuartos.Depth = 0;
            txtNQuartos.Hint = "Número de Quartos";
            txtNQuartos.Location = new Point(99, 177);
            txtNQuartos.MouseState = MouseState.HOVER;
            txtNQuartos.Name = "txtNQuartos";
            txtNQuartos.PasswordChar = '\0';
            txtNQuartos.SelectedText = "";
            txtNQuartos.SelectionLength = 0;
            txtNQuartos.SelectionStart = 0;
            txtNQuartos.Size = new Size(200, 23);
            txtNQuartos.TabIndex = 2;
            txtNQuartos.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(90, 220);
            btnSalvar.MouseState = MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Primary = true;
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Depth = 0;
            btnCancelar.Location = new Point(212, 220);
            btnCancelar.MouseState = MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AddImovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 316);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtNQuartos);
            Controls.Add(txtEndereco);
            Controls.Add(txtTipo);
            Name = "AddImovelForm";
            Text = "Adicionar Imóvel";
            ResumeLayout(false);
        }
    }
}
