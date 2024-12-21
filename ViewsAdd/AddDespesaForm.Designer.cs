using MaterialSkin.Controls;

namespace TP_POO_R.ViewsAdicionar
{
    partial class AddDespesaForm
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
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
            cmbInquilinos.Location = new Point(99, 119);
            cmbInquilinos.Name = "cmbInquilinos";
            cmbInquilinos.Size = new Size(200, 23);
            cmbInquilinos.TabIndex = 0;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(99, 148);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Depth = 0;
            txtDescricao.Hint = "Descrição";
            txtDescricao.Location = new Point(99, 177);
            txtDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.Size = new Size(200, 23);
            txtDescricao.TabIndex = 2;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtValorLuz
            // 
            txtValorLuz.Depth = 0;
            txtValorLuz.Hint = "Valor Luz";
            txtValorLuz.Location = new Point(99, 206);
            txtValorLuz.MouseState = MaterialSkin.MouseState.HOVER;
            txtValorLuz.Name = "txtValorLuz";
            txtValorLuz.PasswordChar = '\0';
            txtValorLuz.SelectedText = "";
            txtValorLuz.SelectionLength = 0;
            txtValorLuz.SelectionStart = 0;
            txtValorLuz.Size = new Size(200, 23);
            txtValorLuz.TabIndex = 3;
            txtValorLuz.UseSystemPasswordChar = false;
            // 
            // txtValorGas
            // 
            txtValorGas.Depth = 0;
            txtValorGas.Hint = "Valor Gás";
            txtValorGas.Location = new Point(99, 235);
            txtValorGas.MouseState = MaterialSkin.MouseState.HOVER;
            txtValorGas.Name = "txtValorGas";
            txtValorGas.PasswordChar = '\0';
            txtValorGas.SelectedText = "";
            txtValorGas.SelectionLength = 0;
            txtValorGas.SelectionStart = 0;
            txtValorGas.Size = new Size(200, 23);
            txtValorGas.TabIndex = 4;
            txtValorGas.UseSystemPasswordChar = false;
            // 
            // txtValorAgua
            // 
            txtValorAgua.Depth = 0;
            txtValorAgua.Hint = "Valor Água";
            txtValorAgua.Location = new Point(99, 264);
            txtValorAgua.MouseState = MaterialSkin.MouseState.HOVER;
            txtValorAgua.Name = "txtValorAgua";
            txtValorAgua.PasswordChar = '\0';
            txtValorAgua.SelectedText = "";
            txtValorAgua.SelectionLength = 0;
            txtValorAgua.SelectionStart = 0;
            txtValorAgua.Size = new Size(200, 23);
            txtValorAgua.TabIndex = 5;
            txtValorAgua.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(90, 308);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Primary = true;
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Depth = 0;
            btnCancelar.Location = new Point(212, 308);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Primary = true;
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AddDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 361);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtValorAgua);
            Controls.Add(txtValorGas);
            Controls.Add(txtValorLuz);
            Controls.Add(txtDescricao);
            Controls.Add(dtpData);
            Controls.Add(cmbInquilinos);
            Name = "AddDespesaForm";
            Text = "Adicionar Despesa";
            ResumeLayout(false);
        }
        #endregion
    }
}
