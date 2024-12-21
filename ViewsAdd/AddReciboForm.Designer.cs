namespace TP_POO_R.ViewsAdicionar
{
    partial class AddReciboForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.ComboBox comboBoxContratos;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;

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
            comboBoxContratos = new ComboBox();
            txtDescricao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            dateTimePickerData = new DateTimePicker();
            btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // comboBoxContratos
            // 
            comboBoxContratos.FormattingEnabled = true;
            comboBoxContratos.Location = new Point(53, 89);
            comboBoxContratos.Margin = new Padding(4, 3, 4, 3);
            comboBoxContratos.Name = "comboBoxContratos";
            comboBoxContratos.Size = new Size(303, 23);
            comboBoxContratos.Text = "Inquilino";
            comboBoxContratos.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Depth = 0;
            txtDescricao.Hint = "Descrição";
            txtDescricao.Location = new Point(53, 118);
            txtDescricao.Margin = new Padding(4, 3, 4, 3);
            txtDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.Size = new Size(303, 23);
            txtDescricao.TabIndex = 1;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(53, 147);
            dateTimePickerData.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(303, 23);
            dateTimePickerData.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Depth = 0;
            btnSalvar.Location = new Point(268, 186);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Primary = true;
            btnSalvar.Size = new Size(88, 27);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // AddReciboForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 246);
            Controls.Add(btnSalvar);
            Controls.Add(dateTimePickerData);
            Controls.Add(txtDescricao);
            Controls.Add(comboBoxContratos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddReciboForm";
            Text = "Adicionar Recibo";
            Load += AddReciboForm_Load;
            ResumeLayout(false);
        }
        #endregion
    }
}
