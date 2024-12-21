namespace TP_POO_R.ViewsAdicionar
{
    partial class AddContratoForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbInquilinos;
        private DateTimePicker dtpDataInicio;
        private DateTimePicker dtpDataFim;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel lblInquilino;
        private MaterialSkin.Controls.MaterialLabel lblDataInicio;
        private MaterialSkin.Controls.MaterialLabel lblDataFim;

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
            this.cmbInquilinos = new System.Windows.Forms.ComboBox();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblInquilino = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataInicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataFim = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cmbInquilinos
            // 
            this.cmbInquilinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInquilinos.FormattingEnabled = true;
            this.cmbInquilinos.Location = new System.Drawing.Point(99, 119);
            this.cmbInquilinos.Name = "cmbInquilinos";
            this.cmbInquilinos.Size = new System.Drawing.Size(200, 23);
            this.cmbInquilinos.TabIndex = 0;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(99, 177);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpDataInicio.TabIndex = 1;
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(99, 235);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(200, 23);
            this.dtpDataFim.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Depth = 0;
            this.txtValor.Hint = "Valor";
            this.txtValor.Location = new System.Drawing.Point(99, 264);
            this.txtValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(200, 23);
            this.txtValor.TabIndex = 3;
            this.txtValor.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(90, 322);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(212, 322);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblInquilino
            // 
            this.lblInquilino.AutoSize = true;
            this.lblInquilino.Depth = 0;
            this.lblInquilino.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInquilino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInquilino.Location = new System.Drawing.Point(99, 97);
            this.lblInquilino.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInquilino.Name = "lblInquilino";
            this.lblInquilino.Size = new System.Drawing.Size(68, 19);
            this.lblInquilino.TabIndex = 6;
            this.lblInquilino.Text = "Inquilino";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Depth = 0;
            this.lblDataInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataInicio.Location = new System.Drawing.Point(99, 155);
            this.lblDataInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(79, 19);
            this.lblDataInicio.TabIndex = 7;
            this.lblDataInicio.Text = "Data Início";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Depth = 0;
            this.lblDataFim.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataFim.Location = new System.Drawing.Point(99, 213);
            this.lblDataFim.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(68, 19);
            this.lblDataFim.TabIndex = 8;
            this.lblDataFim.Text = "Data Fim";
            // 
            // AddContratoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 361);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblInquilino);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.cmbInquilinos);
            this.Name = "AddContratoForm";
            this.Text = "Adicionar Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
