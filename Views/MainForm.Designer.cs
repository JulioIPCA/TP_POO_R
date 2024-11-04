namespace TP_POO_R.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnContrato;
        private MaterialSkin.Controls.MaterialRaisedButton btnDespesa;
        private MaterialSkin.Controls.MaterialRaisedButton btnImovel;
        private MaterialSkin.Controls.MaterialRaisedButton btnInquilino;
        private MaterialSkin.Controls.MaterialRaisedButton btnRecibo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSenhorio;

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
            btnContrato = new MaterialSkin.Controls.MaterialRaisedButton();
            btnDespesa = new MaterialSkin.Controls.MaterialRaisedButton();
            btnImovel = new MaterialSkin.Controls.MaterialRaisedButton();
            btnInquilino = new MaterialSkin.Controls.MaterialRaisedButton();
            btnRecibo = new MaterialSkin.Controls.MaterialRaisedButton();
            btnSenhorio = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // btnContrato
            // 
            btnContrato.Depth = 0;
            btnContrato.Location = new Point(34, 78);
            btnContrato.MouseState = MaterialSkin.MouseState.HOVER;
            btnContrato.Name = "btnContrato";
            btnContrato.Primary = true;
            btnContrato.Size = new Size(169, 36);
            btnContrato.TabIndex = 0;
            btnContrato.Text = "Contrato";
            btnContrato.UseVisualStyleBackColor = true;
            btnContrato.Click += btnContrato_Click;
            // 
            // btnDespesa
            // 
            btnDespesa.Depth = 0;
            btnDespesa.Location = new Point(255, 78);
            btnDespesa.MouseState = MaterialSkin.MouseState.HOVER;
            btnDespesa.Name = "btnDespesa";
            btnDespesa.Primary = true;
            btnDespesa.Size = new Size(169, 36);
            btnDespesa.TabIndex = 1;
            btnDespesa.Text = "Despesa";
            btnDespesa.UseVisualStyleBackColor = true;
            btnDespesa.Click += btnDespesa_Click;
            // 
            // btnImovel
            // 
            btnImovel.Depth = 0;
            btnImovel.Location = new Point(457, 78);
            btnImovel.MouseState = MaterialSkin.MouseState.HOVER;
            btnImovel.Name = "btnImovel";
            btnImovel.Primary = true;
            btnImovel.Size = new Size(169, 36);
            btnImovel.TabIndex = 2;
            btnImovel.Text = "Imovel";
            btnImovel.UseVisualStyleBackColor = true;
            btnImovel.Click += btnImovel_Click;
            // 
            // btnInquilino
            // 
            btnInquilino.Depth = 0;
            btnInquilino.Location = new Point(679, 78);
            btnInquilino.MouseState = MaterialSkin.MouseState.HOVER;
            btnInquilino.Name = "btnInquilino";
            btnInquilino.Primary = true;
            btnInquilino.Size = new Size(169, 36);
            btnInquilino.TabIndex = 3;
            btnInquilino.Text = "Inquilino";
            btnInquilino.UseVisualStyleBackColor = true;
            btnInquilino.Click += btnInquilino_Click;
            // 
            // btnRecibo
            // 
            btnRecibo.Depth = 0;
            btnRecibo.Location = new Point(889, 78);
            btnRecibo.MouseState = MaterialSkin.MouseState.HOVER;
            btnRecibo.Name = "btnRecibo";
            btnRecibo.Primary = true;
            btnRecibo.Size = new Size(169, 36);
            btnRecibo.TabIndex = 4;
            btnRecibo.Text = "Recibo";
            btnRecibo.UseVisualStyleBackColor = true;
            btnRecibo.Click += btnRecibo_Click;
            // 
            // btnSenhorio
            // 
            btnSenhorio.Depth = 0;
            btnSenhorio.Location = new Point(1104, 78);
            btnSenhorio.MouseState = MaterialSkin.MouseState.HOVER;
            btnSenhorio.Name = "btnSenhorio";
            btnSenhorio.Primary = true;
            btnSenhorio.Size = new Size(169, 36);
            btnSenhorio.TabIndex = 5;
            btnSenhorio.Text = "Senhorio";
            btnSenhorio.UseVisualStyleBackColor = true;
            btnSenhorio.Click += btnSenhorio_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 655);
            Controls.Add(btnSenhorio);
            Controls.Add(btnRecibo);
            Controls.Add(btnInquilino);
            Controls.Add(btnImovel);
            Controls.Add(btnDespesa);
            Controls.Add(btnContrato);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion
    }
}
