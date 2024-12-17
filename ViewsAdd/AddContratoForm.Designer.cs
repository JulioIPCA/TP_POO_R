namespace TP_POO_R.ViewsAdicionar
{
    partial class AddContratoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbIdImovel;
        private System.Windows.Forms.ComboBox cmbIdInquilino;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpDataCessacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblIdImovel;
        private System.Windows.Forms.Label lblIdInquilino;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDataCessacao;

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
            this.cmbIdImovel = new System.Windows.Forms.ComboBox();
            this.cmbIdInquilino = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpDataCessacao = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblIdImovel = new System.Windows.Forms.Label();
            this.lblIdInquilino = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataCessacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbIdImovel
            // 
            this.cmbIdImovel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdImovel.FormattingEnabled = true;
            this.cmbIdImovel.Location = new System.Drawing.Point(120, 30);
            this.cmbIdImovel.Name = "cmbIdImovel";
            this.cmbIdImovel.Size = new System.Drawing.Size(200, 21);
            this.cmbIdImovel.TabIndex = 0;
            // 
            // cmbIdInquilino
            // 
            this.cmbIdInquilino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdInquilino.FormattingEnabled = true;
            this.cmbIdInquilino.Location = new System.Drawing.Point(120, 70);
            this.cmbIdInquilino.Name = "cmbIdInquilino";
            this.cmbIdInquilino.Size = new System.Drawing.Size(200, 21);
            this.cmbIdInquilino.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(120, 250);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(120, 110);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 4;
            // 
            // dtpDataCessacao
            // 
            this.dtpDataCessacao.Location = new System.Drawing.Point(120, 190);
            this.dtpDataCessacao.Name = "dtpDataCessacao";
            this.dtpDataCessacao.Size = new System.Drawing.Size(200, 20);
            this.dtpDataCessacao.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(120, 230);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 20);
            this.txtValor.TabIndex = 7;
            // 
            // lblIdImovel
            // 
            this.lblIdImovel.AutoSize = true;
            this.lblIdImovel.Location = new System.Drawing.Point(30, 30);
            this.lblIdImovel.Name = "lblIdImovel";
            this.lblIdImovel.Size = new System.Drawing.Size(50, 13);
            this.lblIdImovel.TabIndex = 8;
            this.lblIdImovel.Text = "Id Imóvel";
            // 
            // lblIdInquilino
            // 
            this.lblIdInquilino.AutoSize = true;
            this.lblIdInquilino.Location = new System.Drawing.Point(30, 70);
            this.lblIdInquilino.Name = "lblIdInquilino";
            this.lblIdInquilino.Size = new System.Drawing.Size(58, 13);
            this.lblIdInquilino.TabIndex = 9;
            this.lblIdInquilino.Text = "Id Inquilino";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(30, 110);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 150);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(30, 230);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor";
            // 
            // lblDataCessacao
            // 
            this.lblDataCessacao.AutoSize = true;
            this.lblDataCessacao.Location = new System.Drawing.Point(30, 190);
            this.lblDataCessacao.Name = "lblDataCessacao";
            this.lblDataCessacao.Size = new System.Drawing.Size(84, 13);
            this.lblDataCessacao.TabIndex = 13;
            this.lblDataCessacao.Text = "Data Cessação";
            // 
            // AddContratoForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.lblDataCessacao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblIdInquilino);
            this.Controls.Add(this.lblIdImovel);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpDataCessacao);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbIdInquilino);
            this.Controls.Add(this.cmbIdImovel);
            this.Name = "AddContratoForm";
            this.Text = "Adicionar Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
