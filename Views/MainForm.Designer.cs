namespace TP_POO_R.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;

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
            btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Depth = 0;
            btnAdicionar.Location = new Point(195, 118);
            btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Primary = true;
            btnAdicionar.Size = new Size(233, 36);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Depth = 0;
            btnConsultar.Location = new Point(195, 186);
            btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Primary = true;
            btnConsultar.Size = new Size(233, 36);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 341);
            Controls.Add(btnConsultar);
            Controls.Add(btnAdicionar);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion
    }
}
