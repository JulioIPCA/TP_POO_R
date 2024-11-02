namespace TP_POO_R.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConsultar;

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
            btnAdicionar = new Button();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(195, 90);
            btnAdicionar.Margin = new Padding(4, 3, 4, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(233, 27);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(195, 186);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(233, 27);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 299);
            Controls.Add(btnConsultar);
            Controls.Add(btnAdicionar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion
    }
}
