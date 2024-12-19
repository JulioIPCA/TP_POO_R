using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;
using System.Windows.Forms;

namespace TP_POO_R.ViewsAdicionar
{
    partial class AddDespesa : MaterialForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbInquilinos;
        private DateTimePicker dtpData;
        private MaterialSingleLineTextField txtDescricao;
        private MaterialSingleLineTextField txtValorLuz;
        private MaterialSingleLineTextField txtValorGas;
        private MaterialSingleLineTextField txtValorAgua;
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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );

            cmbInquilinos = new ComboBox();
            dtpData = new DateTimePicker();
            txtDescricao = new MaterialSingleLineTextField();
            txtValorLuz = new MaterialSingleLineTextField();
            txtValorGas = new MaterialSingleLineTextField();
            txtValorAgua = new MaterialSingleLineTextField();
            btnSalvar = new MaterialRaisedButton();
            btnCancelar = new MaterialRaisedButton();
            SuspendLayout();
            // 
            // cmbInquilinos
            // 
            cmbInquilinos.Location = new Point(12, 70);
            cmbInquilinos.Name = "cmbInquilinos";
            cmbInquilinos.Size = new Size(200, 23);
            cmbInquilinos.TabIndex = 0;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(12, 130);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Hint = "Descrição";
            txtDescricao.Location = new Point(12, 160);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(200, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtValorLuz
            // 
            txtValorLuz.Hint = "Valor Luz";
            txtValorLuz.Location = new Point(12, 190);
            txtValorLuz.Name = "txtValorLuz";
            txtValorLuz.Size = new Size(200, 23);
            txtValorLuz.TabIndex = 4;
            // 
            // txtValorGas
            // 
            txtValorGas.Hint = "Valor Gás";
            txtValorGas.Location = new Point(12, 220);
            txtValorGas.Name = "txtValorGas";
            txtValorGas.Size = new Size(200, 23);
            txtValorGas.TabIndex = 5;
            // 
            // txtValorAgua
            // 
            txtValorAgua.Hint = "Valor Água";
            txtValorAgua.Location = new Point(12, 250);
            txtValorAgua.Name = "txtValorAgua";
            txtValorAgua.Size = new Size(200, 23);
            txtValorAgua.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(12, 280);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Primary = true;
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Depth = 0;
            btnCancelar.Location = new Point(137, 280);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AddDespesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 320);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtValorAgua);
            Controls.Add(txtValorGas);
            Controls.Add(txtValorLuz);
            Controls.Add(txtDescricao);
            Controls.Add(dtpData);
            Controls.Add(cmbInquilinos);
            Name = "AddDespesa";
            Text = "Adicionar Despesa";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
